using System;

namespace Accounting.DAL.Entities
{
    public class Administrator : User
    {
        public string Department { get; set; }
        public string Position { get; set; }
    }
}
