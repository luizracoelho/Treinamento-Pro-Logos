using Dommel;
using Microsoft.Extensions.Configuration;
using ProLogos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace ProLogos.DAL.Base
{
    public class BaseDao<T> : IBaseDao<T> where T : class, IBaseDomain
    {
        protected readonly string ConnectionString;
        public BaseDao()
        {
            var config = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();

            ConnectionString = config.GetConnectionString("Conexao");
        }

        public IList<T> Listar()
        {
            using (var db = new SqlConnection(ConnectionString))
                return db.GetAll<T>().ToList();
        }

        public T Encontrar(long id)
        {
            using (var db = new SqlConnection(ConnectionString))
                return db.Get<T>(id);
        }

        public long Inserir(T entidade)
        {
            using (var db = new SqlConnection(ConnectionString))
                return (long)db.Insert(entidade);
        }

        public void Alterar(T entidade)
        {
            using (var db = new SqlConnection(ConnectionString))
                db.Update(entidade);
        }

        public void Remover(T entidade)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    db.Delete(entidade);
                }
            }
            catch (SqlException)
            {
                throw new Exception("Não é possível remover esse registro, pois ele está ligado a outro (s).");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
