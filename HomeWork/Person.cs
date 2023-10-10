
namespace homework
{
    public class Person
    {

        private int _age;
        private string _fullName;
        public string FullName { get=>this._fullName; set=>this._fullNameValidation(value); }
        public int Age { get=>this._age; set=>this._ageValidation(value); }
        public string Phone { get; set; }
        
        private void _ageValidation(int x) {
            this._age = x > 0 ? x : 0;
        }

        private void _fullNameValidation(string x)
        {
            string currentWord = String.Empty;
            string[] words = new string[9];
            int wordCount = 0;
            bool success = true;
            for(int cursor = 0; cursor < x.Length; cursor++)
            {
                //if we have more than 10 words in fullname.
                if(wordCount > 10)
                {
                    success = false;
                    break;
                }
                //char is not whitespace means cursor still on the word.
                if (x[cursor] != ' ' )
                {
                    currentWord += x[cursor];
                }
                //when char is white space means that the current word stack is end.
                if (x[cursor] == ' ' && currentWord.Length > 0)
                {
                    words[wordCount] = currentWord;
                    currentWord = String.Empty;
                    wordCount++;
                }
            }
            //when we have less than 1 word or more than 10 (wordCount is based on index!)
            if (wordCount < 1 || (currentWord.Length > 0 && words.Length > 9) )
            {
                success = false;
            }

            if (!success) return;
            
            //if loop is end and there remain a word in the stack
            words[^1] = currentWord;

            this._fullName = x;

            /*foreach(string i in words)
            {
                Console.WriteLine(i);
            }*/
        }

        public Person(string fullName, int age, string phone ) {
            this.FullName = fullName;
            this.Age = age;
            this.Phone = phone;
            
        }
    }
}
