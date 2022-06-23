using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Travel.Application.Common.Interfaces;

namespace Travel.Application.TourLists.Queries.ExportTours
{
    public class ExportToursQuery : IRequest<ExportToursVm>
    {
        public int ListId { get; set; }
    }

    public class ExportToursQueryHandler : IRequestHandler<ExportToursQuery, ExportToursVm>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _context;
        private readonly ICsvFileBuilder _fileBuilder;

        public ExportToursQueryHandler(IMapper mapper, IApplicationDbContext context, ICsvFileBuilder fileBuilder)
        {
            _context = context;
            _mapper = mapper;
            _fileBuilder = fileBuilder;
        }

        public async Task<ExportToursVm> Handle(ExportToursQuery request, CancellationToken cancellationToken)
        {
            var records = await _context.TourPackages
                .Where(t => t.ListId == request.ListId)
                .ProjectTo<TourPackageRecord>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            var vm = new ExportToursVm
            {
                Content = _fileBuilder.BuildTourPackagesFile(records.AsEnumerable()),
                ContentType = "text/csv",
                FileName = "TourPackages.csv"
            };
            return await Task.FromResult(vm);
        }
    }
}
