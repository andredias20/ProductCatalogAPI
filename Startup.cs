namespace ProductCatalogAPI
{
    public class Startup
    {

        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration= configuration;
        }



    }
}
