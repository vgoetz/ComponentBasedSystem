using Autofac;

namespace ComponentBasedSystem.Bootstrapper {
    public class ComponentBasedSystemModule : Module {

        protected override void Load(ContainerBuilder builder) {
            base.Load(builder);

            // service registration
            //builder.RegisterType<TranslationRepository>()
            //    .As<ITranslationRepository>()
            //    .WithParameters(
            //        new List<Parameter> {
            //            new TypedParameter(typeof (bool), true),
            //            new TypedParameter(typeof (string), "IntelligentTranslator.Repository.Intelligent_translator.xml"),
            //        })
            //    .SingleInstance();


            // view model registration
            //builder.RegisterType<TranslationViewModel>();
            //builder.RegisterType<StartPageViewModel>()
            //    .SingleInstance();


            // view registration
            //builder.RegisterType<StartPageView>()
            //    .SingleInstance();
        }
    }
}