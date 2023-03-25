namespace entidades
{
    public  class login
    {
        public string CodigoUsuario { get; set; }
        public string Ccontraseña { get; set; }
        public string Rol { get; set; }

        public login()
        {
        }

        public login(string codigoUsuario, string ccontraseña, string rol)
        {
            CodigoUsuario = codigoUsuario;
            Ccontraseña = ccontraseña;
            Rol = rol;
        }
    }
}
