using Autofac;

namespace ComponentBasedSystem.BootstrapperAndMondules {
    public class Bootstrapper : BootstrapperBase {

        public Bootstrapper() {
            // save reference to mainGameClass if needed (e.g. for configuration)
        }

        /// <summary>
        /// Register all special modules
        /// </summary>
        /// <param name="builder"></param>
        protected override void ConfigureContainer(ContainerBuilder builder) {
            base.ConfigureContainer(builder);
            builder.RegisterModule<ComponentBasedSystemModule>();
        }

        /// <summary>
        /// Set defaults in Application class like "MyGame", if needed 
        /// </summary>
        /// <param name="container"></param>
        protected override void ConfigureApplication(IContainer container) { }
    }
}