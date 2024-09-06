using Core8.BusinessLogic;

namespace Core8.MVC.XUnit
{
    public static class RegisterDependencies
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //we will register dependencies from different assembly 
            services.RegisterBusinessLogic();
        }
    }
}
