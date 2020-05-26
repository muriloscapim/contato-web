using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContatoWeb.Models
{
    public class ContatoRepository : AbstractRepository<Contato, int>
    {
        public override void Delete(Contato entity)
        {
            throw new NotImplementedException();
        }

        public override void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Contato> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Contato GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Save(Contato entity)
        {
            using (var conn = new NpgsqlConnection(StringConn))
            {
                string sql = "INSERT INTO tb_contato (nome, email, telefone)" +
                             "VALUES (@nome, @email, @telefone);";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", entity.Nome);
                cmd.Parameters.AddWithValue("@email", entity.Email);
                cmd.Parameters.AddWithValue("@telefone", entity.Telefone);
            }
        }

        public override void Update(Contato entity)
        {
            throw new NotImplementedException();
        }
    }
}