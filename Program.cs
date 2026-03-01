using System.Text.RegularExpressions;

namespace regxPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "안녕하세요 저의 번호는 12345678910입니다.";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine($"{matchCollection.Count}만큼 {text}에서 패턴을 발견했습니다.");

            foreach(Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"{group[0].Value}는 {group[0].Index}에 위치해있습니다.");
                Console.WriteLine(hit.Value  + hit.Index);
            }
        }
    }
}
