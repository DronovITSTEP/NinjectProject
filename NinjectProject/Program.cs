using Ninject;
using NinjectProject.Autofac;

/*using (var kernel = new StandardKernel()) {

    kernel.Bind<ITaxCalculator>().To<TaxCalculate>().WithConstructorArgument("rate", 2M);
    var tc = kernel.Get<ITaxCalculator>();
    Console.WriteLine(tc.CalculateTax(5M));


    kernel.Bind<ITaxCalculator>().To<TaxCalculate>().WithConstructorArgument("rate", 2M);
    var sale = kernel.Get<Sale>();
    sale.GetTotal();

    kernel.Bind<ITaxCalculator>().To<TaxCalculate>().InSingletonScope().WithConstructorArgument("rate", 2M);
    var tc1 = kernel.Get<ITaxCalculator>();
    var tc2 = kernel.Get<ITaxCalculator>();

    kernel.Bind<ITaxCalculator>().To<TaxCalculate>().InScope.WithConstructorArgument("rate", 2M);
}*/

using Autofac;

private static IContainer Container { get; set; }

var builder = new ContainerBuilder();
builder.RegisterType<TodayWriter>().As<IDateWriter>();
builder.RegisterType<ConsoleOutput>().As<IOutput>();

Container = builder.Build();

