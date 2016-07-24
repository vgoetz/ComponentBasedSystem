using Autofac;

namespace ComponentBasedSystem.Bootstrapper {
    public class CoreModule : Module {

        protected override void Load(ContainerBuilder builder) {

            //// service registration
            //builder.RegisterType<ViewFactory>()
            //    .As<IViewFactory>()
            //    .SingleInstance();
        }
    }
}