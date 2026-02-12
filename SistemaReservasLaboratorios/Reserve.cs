using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservasLaboratorios
{
    internal class Reserve
    {
        
            public string Name { get; set; }
            public string Laboratory { get; set; }
            public DateTime Date_start { get; set; }
            public DateTime Date_end { get; set; }
            public string IdUser { get; set; }
            public string IdLab { get; set; }

            public Reserve() { }

            public Reserve(string name, string laboratory, DateTime Date_start, DateTime Date_end, string IdUser, string IdLab)
            {
                this.Name = name;
                this.Laboratory = laboratory;
                this.Date_start = Date_start;
                this.Date_end = Date_end;
                this.IdUser = IdUser;
                this.IdLab = IdLab;
            }
        }
    }

