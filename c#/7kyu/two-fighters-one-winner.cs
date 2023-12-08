// Create a function that returns the name of the winner in a fight between two fighters.

// Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.

// Each fighter will be a Fighter object/instance. See the Fighter class below in your chosen language.

// Both health and damagePerAttack (damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.

// Your function also receives a third argument, a string, with the name of the fighter that attacks first.

using System;
public class Kata {
  public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker) {
    Fighter attacker = (firstAttacker == fighter1.Name) ?  fighter1 : fighter2;
    Fighter defender = (firstAttacker == fighter1.Name) ? fighter2 : fighter1;
    
    while ((attacker.Health > 0) && (defender.Health > 0))
    {
    		defender.Health -= attacker.DamagePerAttack;
        if(defender.Health > 0)
        {
        		attacker.Health -= defender.DamagePerAttack;
        }
    }
    
    return (attacker.Health > defender.Health) ? attacker.Name : defender.Name;    
  }
}