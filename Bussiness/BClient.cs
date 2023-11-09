﻿using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class BClient
    {

        public List<Client> GetByName(string Name)
        {

            List<Client> result = new List<Client>();

            DClient dClient = new DClient();

            var client = dClient.ListarClientes();

            foreach (var item in client) 
            {
                
                if (item.Name == Name)
                {

                    result.Add(item);

                }

            }

            return result;

        }

        public List<Client> GetById(int id)
        {

            List<Client> result = new List<Client>();

            DClient dClient = new DClient();

            var client = dClient.ListarClientes();

            foreach (var item in client)
            {

                if (item.Id == id)
                {

                    result.Add(item);

                }

            }

            return result;

        }

        public List<Client> GetAll()
        {
            List<Client> result = new List<Client>();
            DClient dClient = new DClient();
            var client = dClient.ListarClientes();

            foreach (var item in client)
            {
                result.Add(item);

            }
            return result;
        }

    }
}
