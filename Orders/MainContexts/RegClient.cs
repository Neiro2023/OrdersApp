namespace Orders.MainContexts
{
    internal class RegClient
    {
        public string GetName(string name)
        {
            if (name.Length > 30) name = name.Substring(0, 29).Trim();
            return name;
        }
        public string GetLastname(string lastname)
        {
            if (lastname.Length > 30) lastname = lastname.Substring(0, 29).Trim();
            return lastname;
        }
        public string GetEmail(string email)
        {
            if (email.Length > 30) email = email.Substring(0, 29).Trim();
            return email;
        }
        public string GetPass(string pass)
        {
            if (pass.Length > 30) pass = pass.Substring(0, 29).Trim();
            return pass;
        }
    }
}
