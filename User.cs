using System;

namespace EntityFrameworkDateQuery
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AddedDate { get; set; }

        public override string ToString()
        {
            return $"{Id} --- {Name} --- {AddedDate}";
        }
    }
}