

//     Return an array/list where Even numbers come first then odds

//     Since , Men are stronger than Boys , Then Even numbers in ascending order While odds in descending .

//     Array/list size is at least 4 .

//     Array/list numbers could be a mixture of positives , negatives .

//     Have no fear , It is guaranteed that no Zeroes will exists . !alt

//     Repetition of numbers in the array/list could occur , So (duplications are not included when separating).
//     Input >> Output Examples:

// menFromBoys ({7, 3 , 14 , 17}) ==> return ({14, 17, 7, 3}) 

using System.Linq;

public class Kata {
  public static int[] MenFromBoys(int[] a)
  {
    return a.Where(x => x % 2 == 0).OrderBy(x => x).Concat(a.Where(x => x % 2 != 0).OrderByDescending(x => x)).Distinct().ToArray();
  }
}