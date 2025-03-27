using DataBase.Config;
using DataBase.Models;
using DataBase.Repository.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repository.implementations
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DbConfig dbConfig, DbContext context) : base(dbConfig, context)
        {
        }
    }
}
