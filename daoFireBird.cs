using System;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;

namespace Agora_Express
{
    /// <summary>
    /// Usa padrão Singleton para obter uma instancia do FireBird
    /// </summary>
    public class daoFireBird
    {
        private static readonly daoFireBird instanciaFireBird = new daoFireBird();

        private daoFireBird() { }

        public static daoFireBird getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            return new FbConnection(conn);
        }
    }
}