using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Calender : BaseEntity
    {
        public string Description { get; set; }
        public List<Hold> Hold { get; set; }
        public List<Timeslot> Timeslots { get; set; }
        public Calender()
        {
            Hold = new List<Hold>();
            Timeslots = new List<Timeslot>();
        }
        public async Task AddHold(List<int> Indicies, List<Hold> holdList)
        {
            foreach(var selectedIndex in Indicies)
            {
                var hold = holdList.Where(x => x.Id == selectedIndex).FirstOrDefault();
                Hold.Add(hold);
            }
        }
    }
}
