using System.Collections.Generic;

namespace Travel.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTourPackagesFile(IEnumerable<TourPackageRecord> records);
    }
}
