# [0.3.0](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/compare/v0.2.0...v0.3.0) (2022-06-24)


### Features

* **api:** add Serilog package to use as default Logger ([87f362a](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/87f362aaa5ff2e628522fbb2e0addda3f154de49))



# [0.2.0](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/compare/v0.1.0...v0.2.0) (2022-06-24)


### Features

* **api:** add ApiVersion annotation to ApiController ([4ff9472](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/4ff9472a463ac10ceb30f88bc706898cb08cdb9f))
* **api:** add default swagger metadata of the API explorer ([f3ffaba](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/f3ffaba299d1248d1e2b2166797920f0fd0a86e5))
* **api:** add Swagger config for Api versioning documentation ([af87dcd](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/af87dcd82cc7edcf18d67f326988bc660f739fa4))
* **api:** add WeatherForeCast controller ([a813cb8](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/a813cb83229482377aebc7be7f3e23c5e1db98d2))
* **api:** add WeatherForeCastController v2 with breaking change ([e257173](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/e2571734cdc83071083453a9ecaeaf3ef2b6f7ee))
* **api:** update Program.cs to support api versioning documentation with Swagger ([7f54b3d](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/7f54b3d6c98c25710272d36edfd0bfb5fddb9c5f))



# [0.1.0](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/compare/b49bfef944ed28cd03af7e752e6251fe56e218a3...v0.1.0) (2022-06-23)


### Bug Fixes

* **core:** corrected namespace for UpdateTourPackageDetailCommand file ([01ef329](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/01ef32992f980928224596b8bb76f99757f7a5c5))


### Features

* **api:** add ApiController class to add Mediator service to ControllerBase class ([734be13](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/734be1317f5f3e6f0a5cc64f164b22aec896c7f9))
* **api:** add ApiExceptionFilter class to handle controller errors ([33cf7db](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/33cf7dbd594dbd1d844d77a3fc575ee3784e748b))
* **api:** update TourListsController to use Mediator pattern ([70df64f](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/70df64f370f821d74c0fc9a70f3a1bbffa21725c))
* **api:** update TourPackagesController to use Mediator pattern ([ab7341d](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/ab7341d378469b9c3ca5be33f1361866c72b0143))
* **core:** add ApiException for email service ([1f0857e](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/1f0857e12cee4c19fc67731fc80dbfbc942d4a96))
* **core:** add assembly mapper interface. ([8514179](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/8514179620350ec86df62b0f93cdb3e28320dbc5))
* **core:** add command for creating TourPackage ([b2f032b](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/b2f032b3f17a07951aaa5d82a08620403bee5df7))
* **core:** add command for deleting TourList ([5920758](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/5920758fe99c35a30ebde026cffbaebe9499d921))
* **core:** add command for deleting TourPackage ([59d27ad](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/59d27ad7d4cbe77fbe3346e8e5a20097e26d2259))
* **core:** add command for TourList ([44784c9](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/44784c9accc8a14d002fa3d1ab724bff9334fff0))
* **core:** add command for updating existing TourList ([4d194f8](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/4d194f8f85a3c320421b96146998a5fb364ba911))
* **core:** add command for updating TourPackage ([fab25ae](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/fab25ae18cdbfd39ff206b2e5111b7ff158c7136))
* **core:** add command for updating TourPackageDetail ([3b9ab47](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/3b9ab473941f04af419b062509c2f18c18cf4e9e))
* **core:** add DependencyInjection container class for injecting thrid-party libraries in the core application project. ([dd3f0e2](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/dd3f0e2b5d30340f68e718df2300578d5240021e))
* **core:** add email service settings class ([a4b78a8](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/a4b78a8879da42cbec375becd201c7108ef0c6a2))
* **core:** add EmailDto ([6a17306](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/6a173066e62993a9b0a56839aa601da030695745))
* **core:** add ExportTours View Model for file builder ([4720dcc](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/4720dcc8de7e6663d0bb6f618297aefe042f2b1b))
* **core:** add handler for GetToursQuery ([91431d5](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/91431d54989b0b95e02a03c0279a269f31fd9cdb))
* **core:** add IApplicationDbContext contract for TravelDbContext ([dcb6712](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/dcb6712005fbe4689f47a53adc6ad093c9e314bc))
* **core:** add ICsvFileBuilder contract ([c39576f](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/c39576f44cc10adb1036d74c4ca9f83c106366e7))
* **core:** add IDateTime contract ([a8b8259](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/a8b825937365fdd64cbbfb7577cfafa77b9a451a))
* **core:** add IEmailService contract ([14fd03d](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/14fd03df7eeb1d6118dce65aaf979bdacfad0b4a))
* **core:** add mappingProfile ([608a873](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/608a873dee49d910b529e44b7ae391d6e9dec914))
* **core:** add NotFoundException class ([4e59953](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/4e599534138da0090f0e98f697b1fb4fcb374d6e))
* **core:** add query handler for ExportTours ([b295a40](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/b295a40104cd7ee05515059e816d0dac14758a93))
* **core:** add TourItemFileRecord class ([4d7860b](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/4d7860bf7e5070d3cf7d053c92f0ef8b5cdf0694))
* **core:** add TourListDto ([f1a277b](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/f1a277b7fb4d7183564b93e375aeae04b47daf23))
* **core:** add TourPackageDto ([9b2f4bd](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/9b2f4bdf8bc6a84c4f9c365a9b8d260d71825011))
* **core:** add Tours View Model for GetToursQuery ([293908a](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/293908ad54497af55eafb4e78e786b7ab740c21f))
* **core:** add ValidationBehavior pipeline ([29122e4](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/29122e4ca10c134dea15d6ed195ba6e5decd0add))
* **core:** add ValidationException class for ValidationBehavior pipeline ([7289250](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/72892507eef63ebf5b42f9ed1f3b3447963dd492))
* **core:** add validator for CreateTourListCommand ([babdf10](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/babdf103efeb5fd73b4480e1b319821743a3dee1))
* **core:** add validator for UpdateTourListCommand ([80644a7](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/80644a776a234800d8a483bfcbccdb480e8b18e8))
* **core:** add validator for UpdateTourPackageCommand ([e869d1c](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/e869d1c0b73762d7e5e367614c757791a1c6e1f2))
* **core:** add validator for UpdateTourPackageDetailCommand ([4370e02](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/4370e02683670bc2f5ed68b852a19b8218860512))
* **core:** add validtor for CreateTourPackageCommand ([7ef7b58](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/7ef7b58f40b1ac372ca374395cfe0bb1b90f8853))
* **core:** ICsvFileBuilder uses TourPackageRecord class as method parameter ([6179fc6](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/6179fc61813d504f044f04e7c39f992e44ad6806))
* **Core:** add PerformanceBehavior pipeline ([131fb96](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/131fb961442d3bd2329fed522adf1535a9b107bc))
* **Core:** add UnhandledExceptionBehavior pipeline ([2ac1442](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/2ac14421dac59f9320af84d4d644c9e75d0ae910))
* **infra:** add CsvFileBuilder implementation class ([94f4b04](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/94f4b04be5d83617c2519cd87448509b56855718))
* **infra:** add DateTime service implementation ([969c4ec](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/969c4ec753aa1287f0f56672968410db6c7ae500))
* **infra:** add DependencyInjection class for Travel.Shared project ([c9f4d23](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/c9f4d23329e1c89cef8e96a0053998994d283911))
* **infra:** add DependencyInjection class in Travel.Data project ([83c10dd](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/83c10dd6254613bd55cadb7943f69c018f15d0fa))
* add basic crud methods to TourLists controller ([80107a3](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/80107a3a78cc7826e6126833c0e1df44d84b0dd8))
* add basic crud methods to tourPackages controller ([b49bfef](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/b49bfef944ed28cd03af7e752e6251fe56e218a3))
* add EmailService implementation ([e948c08](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/e948c087e7f74efc79753af0d2ea7df83582e6a4))
* add LoggingBehavior ([e3b56a5](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/e3b56a5fa8e32f4483ab80f413119afcc52345d0))
* add requests pipeline files for pre and post-processing ([5ebf4a7](https://github.com/DiegoSalas27/aspnet-core-vuejs-applications/commit/5ebf4a702f48860d9ebd3700b780e1673683952d))



