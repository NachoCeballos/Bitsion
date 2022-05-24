using Microsoft.Extensions.Configuration;
using PruebaTecnica.DataAccess;
using PruebaTecnica.DataAccess.Common;
using PruebaTecnica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PruebaTecnica.Repositories
{
    public class ClientRepository
    {
        private readonly IAppSettings _appSettings;
        public ClientRepository(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }
        public List<Client> GetAll()
        {
            List<Client> clients;

            using (AppDbContext db = new AppDbContext(_appSettings))
            {
                clients = db.Clients.ToList();
            }

            return clients;
        }

        public void Insert(Client entity)
        {
            using (AppDbContext db = new AppDbContext(_appSettings))
            {
                db.Clients.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(Client entity)
        {
            using (AppDbContext db = new AppDbContext(_appSettings))
            {
                db.Clients.Update(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Client entity)
        {
            using (AppDbContext db = new AppDbContext(_appSettings))
            {
                db.Clients.Remove(entity);
                db.SaveChanges();
            }
        }
    }
}
