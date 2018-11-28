namespace human
    {
  using System;
  using System.Collections.Generic;
      
    public class Human
    {
        public string HumanName;
        public int Strength { get; set; }
        public int Intelligence {get; set; }
        public int Dexterity {get; set; }
        public int Health {get; set; }
        public Human(string name)
        {
            HumanName = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Human(int strength, int intelligence, int dexterity, int health, string name)
        {                   
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
            HumanName = name;
        }

    public Human()
    {
    }

    public void attack(Human humanToBeAttacked)
        {
            int damage = 5 * this.Strength;
            humanToBeAttacked.Health -= damage;
        }
    }
    public class Wizard : Human
        { 
          public Wizard(string name) : base(name)
          {
            Intelligence = 25;
            Health = 50;
                
          }
          public void heal()
          {
            Health += (10 * Intelligence);
          }
          public void fireball(Human humanToBeAttacked)
          {
            Random rand = new Random();
            humanToBeAttacked.Health -= rand.Next(20, 51);
          }

        }
    public class Ninja : Human
    {
      public Ninja(string name) : base(name)
      {
        Dexterity = 175;
      }
      public void steal(Human humanToBeAttacked)
      {
        attack(humanToBeAttacked);
        Health += 10;
      }
      public void get_away()
      {
        Health -= 15;
      }
    }

    public class Samurai : Human
    {
      public Samurai(string name) : base(name)
      {
        Health = 200;
        
      }

      public void death_blow(Human humanToBeAttacked)
      {
        if (humanToBeAttacked.Health < 50)
        {
          humanToBeAttacked.Health = 0;
        }
      }
      public void meditate()
      {
        Health = 200;
      }
    }
    }  
