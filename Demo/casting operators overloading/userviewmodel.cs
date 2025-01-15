using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism.casting_operators_overloading
{
    internal class userviewmodel
    {
        public int Id { get; set; }
        public string? Fname { get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }


        public static explicit operator userviewmodel(user user)
        {

            string[]? Names = user.FullName?.Split(' ');
            return new userviewmodel()
            {
                Id = user?.Id ?? 0,
                Fname = Names?.Length > 0 ? Names[0] : string.Empty,
                LName = Names?.Length > 1 ? Names[1] : string.Empty,
                Email = user?.Email ?? string.Empty,
                Password = user?.Password ?? string.Empty,


            };
        }
    }
}
