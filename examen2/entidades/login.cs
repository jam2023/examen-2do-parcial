namespace entidades
{
    public  class login
    {
        public string CodigoUsuario { get; set; }
        public string Contraseña { get; set; }

        public login()
        {
        }

        public login(string codigoUsuario, string contraseña)
        {
            CodigoUsuario = codigoUsuario;
            Contraseña = contraseña;
        }
    }
}
