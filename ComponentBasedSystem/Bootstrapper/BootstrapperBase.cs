using Autofac;

namespace ComponentBasedSystem.Bootstrapper {
    public abstract class BootstrapperBase {

        public void Run() {
            var builder = new ContainerBuilder();

            ConfigureContainer(builder);

            var container = builder.Build();

            //var viewFactory = container.Resolve<IViewFactory>();
            //MapViewModel2View(viewFactory);

            ConfigureApplication(container);
        }

        protected virtual void ConfigureContainer(ContainerBuilder builder) {
            builder.RegisterModule<CoreModule>();
        }

        //protected abstract void MapViewModel2View(IViewFactory viewFactory);

        protected abstract void ConfigureApplication(IContainer container);
    }


    public class Bootstrapper : BootstrapperBase {

        public Bootstrapper() {

        }

        protected override void ConfigureContainer(ContainerBuilder builder) {
            base.ConfigureContainer(builder);
            builder.RegisterModule<ComponentBasedSystemModule>();
        }

        //protected override void MapViewModel2View(IViewFactory viewFactory) {
        //    viewFactory.Register<StartPageViewModel, StartPageView>();
        //}

        protected override void ConfigureApplication(IContainer container) {
            
            //var viewFactory = container.Resolve<IViewFactory>();
            
        }
    }
}
