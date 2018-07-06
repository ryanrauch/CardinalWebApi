using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalWebApi.SeedData
{
    public class RandomNameGenerator
    {
        private Random _random { get; set; }

        public RandomNameGenerator()
        {
            _random = new Random();
        }

        public String GetFirstName()
        {
            return _firstNames[_random.Next(_firstNames.Count - 1)];
        }

        public String GetLastName()
        {
            return _lastNames[_random.Next(_lastNames.Count - 1)];
        }

        private List<String> _lastNames = new List<string>
        {
            "Smith",
            "Johnson",
            "Williams",
            "Jones",
            "Brown",
            "Davis",
            "Miller",
            "Wilson",
            "Moore",
            "Taylor",
            "Anderson",
            "Thomas",
            "Jackson",
            "White",
            "Harris",
            "Martin",
            "Thompson",
            "Garcia",
            "Martinez",
            "Robinson",
            "Clark",
            "Rodriguez",
            "Lewis",
            "Lee",
            "Walker",
            "Hall",
            "Allen",
            "Young",
            "Hernandez",
            "King",
            "Wright",
            "Lopez",
            "Hill",
            "Scott",
            "Green",
            "Adams",
            "Baker",
            "Gonzalez",
            "Nelson",
            "Carter",
            "Mitchell",
            "Perez",
            "Roberts",
            "Turner",
            "Phillips",
            "Campbell",
            "Parker",
            "Evans",
            "Edwards",
            "Collins"
        };
        private List<String> _firstNames = new List<string>
        {
            "James",
            "John",
            "Robert",
            "Michael",
            "William",
            "David",
            "Richard",
            "Charles",
            "Joseph",
            "Thomas",
            "Christopher",
            "Daniel",
            "Paul",
            "Mark",
            "Donald",
            "George",
            "Kenneth",
            "Steven",
            "Edward",
            "Brian",
            "Ronald",
            "Anthony",
            "Kevin",
            "Jason",
            "Matthew",
            "Jessica",
            "Patricia",
            "Linda",
            "Barbara",
            "Elizabeth",
            "Jennifer",
            "Maria",
            "Susan",
            "Margaret",
            "Dorothy",
            "Lisa",
            "Nancy",
            "Karen",
            "Betty",
            "Helen",
            "Sandra",
            "Donna",
            "Carol",
            "Ruth",
            "Sharon",
            "Michelle",
            "Laura",
            "Sarah",
            "Kimberly",
            "Deborah"
        };

        public List<String> DrinkNames = new List<string>
        {
            "Irish Car Bomb",
            "Hurricane",
            "Negroni",
            "Betty",
            "Tequila Sunrise",
            "Electric Lemonade",
            "Mojito",
            "Margarita",
            "Manhattan",
            "Seven and Seven",
            "Sidecar",
            "Boulevardier",
            "Old Fashioned",
            "Dry Gin Martini",
            "Daiquiri"
        };
    }
}
