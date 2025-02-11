using Lion.AbpPro.LanguageManagement;

namespace Lion.AbpPro
{
    [DependsOn(
        typeof(AbpProDomainModule),
        typeof(AbpProApplicationContractsModule),
        typeof(BasicManagementApplicationModule),
        typeof(DataDictionaryManagementApplicationModule),
        typeof(NotificationManagementApplicationModule),
        typeof(LanguageManagementApplicationModule),
        typeof(AbpProFreeSqlModule)
    )]
    public class AbpProApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options => { options.AddMaps<AbpProApplicationModule>(); });
        }
    }
}