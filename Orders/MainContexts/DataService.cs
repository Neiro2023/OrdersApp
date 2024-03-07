namespace Orders.MainContexts
{
    internal class DataService
    {
        private readonly ApplicationContext _context;
        public DataService(ApplicationContext context) =>_context = context;

        public DataService(System.Windows.Forms.ApplicationContext appContext) {}

        public void AddEntity(ClientDb clientDb)
        {
            _context.Clients.Add(clientDb);
            _context.SaveChanges();
        }
        public ClientDb UpdateEntity(ClientDb clientDb)
        {
            _context.Clients.Update(clientDb);
            _context.SaveChanges();
            return clientDb;
        }
        public ClientDb? SearchEntity(string pass, string name)
        {
            return _context.Clients.FirstOrDefault(x => x.Pass == pass && x.Name == name);
        }
    }
}
