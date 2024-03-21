// In this first kata in the series, you need to define a Hero class to be used in a terminal game. The hero should have the following attributes:
// attribute 	type 	value
// Name 	string 	user argument or "Hero"
// Position 	string 	"00"
// Health 	float 	100
// Damage 	float 	5
// Experience 	int 	0

namespace Solution
{
    public class Hero
    {
        public Hero(string name= "Hero", string pos = "00", float health = 100, float damage = 5, int exp = 0)
        {
            Name = name;
            Position = pos;
            Health = health;
            Damage = damage;
            Experience = exp;
        }
      
        public string Name { get; set; }
        public string Position { get; set; }
        public float Health { get; set; }
        public float Damage { get; set; }
        public int Experience { get; set; }
    }
}