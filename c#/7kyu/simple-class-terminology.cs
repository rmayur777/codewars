// In this Kata you will need to fill out the missing components of a class as described below. The behaviour of the various components is not being assessed, instead the validy of declaration (for example, are things private/public).

// The class you are creating (DemoClass) needs:

//     A private int field, called _privateField.

//     A public string field, called PublicField, with a default value of "None".

//     An integer property (called LimitedProperty), that has a public get, and private set.

//     A constructor that take exactly 1 integer argument and uses it as the default value for _privateField.

namespace CustomAccessors 
{
  public class DemoClass
    {
        private int _privateField;
        public string PublicField = "None";
        public int LimitedProperty { get; private set; }
        
        public DemoClass(int privateField)
        {
          _privateField = privateField;
        }
    }
}