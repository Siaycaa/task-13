using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_1.MVVM.Model.Data
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public List<Position> Positions { get; set; }
        [NotMapped]
        public List<Position> DepartmentPositions 
        {
            get => DataWorker.GetAllPositionsByDepartmentId(ID);
        }
    }
}
