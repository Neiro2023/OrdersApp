using Orders.MainContexts;

namespace Orders
{
    public class Base : Form
    {
        internal static MainContexts.ApplicationContext appContext = new();
        internal static DataService dataService = new(appContext);
        internal RegClient reg = new();
    }
}
