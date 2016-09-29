using Autofac;
using ComponentBasedSystem.Core.Engine;

namespace ComponentBasedSystem.BootstrapperAndMondules {
    public class ComponentBasedSystemModule : Module {

        protected override void Load(ContainerBuilder builder) {
            base.Load(builder);

            // service registration
            builder.RegisterType<Engine>()
                .As<IEngine>()
                .SingleInstance();

        }
    }
}