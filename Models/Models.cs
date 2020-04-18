using System.Collections.Generic;
using System.Linq;

namespace lesson3.Models
{
    public class Models : IQueryable<Models>
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int CompanyId { get; set; }
        public Company _Company { get; set; }

        public int InsertOne(Models model)
        {
            throw new System.NotImplementedException();
        }

        public List<Models> SelectAll()
        {
            throw new System.NotImplementedException();
        }

        public Models SelectById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}