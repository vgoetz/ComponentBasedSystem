using Autofac;

namespace ComponentBasedSystem.BootstrapperAndMondules {
    public abstract class BootstrapperBase {

        public void Run() {
            // register modules
            var builder = new ContainerBuilder();
            ConfigureContainer(builder);

            // configure app defaults
            var container = builder.Build();
            ConfigureApplication(container);
        }

        /// <summary>
        /// Register all basic modules
        /// </summary>
        /// <param name="builder"></param>
        protected virtual void ConfigureContainer(ContainerBuilder builder) {
            builder.RegisterModule<CoreModule>();
        }
        
        /// <summary>
        /// Set defaults, if needed
        /// </summary>
        /// <param name="container"></param>
        protected abstract void ConfigureApplication(IContainer container);
    }
}
