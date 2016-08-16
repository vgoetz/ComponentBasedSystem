using Autofac;

namespace ComponentBasedSystem.BootstrapperAndMondules {
    public class CoreModule : Module {

        protected override void Load(ContainerBuilder builder) {

            //// service registration
            //builder.RegisterType<ViewFactory>()
            //    .As<IViewFactory>()
            //    .SingleInstance();
        }
    }
}