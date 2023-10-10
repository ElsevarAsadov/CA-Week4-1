using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Person p = new("Elsevar   Asadov sahib", 0, "xxx-yy-zz");
        Console.WriteLine(p.FullName);
        p.Age = -14;
        Console.WriteLine(p.Age);
        Console.WriteLine(p.Phone);
    }
}

 public class Person
    {

        private int _age;
        private string _fullName;
        public string FullName {
            get=>this._fullName; 
            set=>this._fullNameValidation(value); 
            
        }
        public int Age { 
            get=>this._age; 
            set=>this._ageValidation(value); 
            
        }
        
        public string Phone { get; set; }
        
        private void _ageValidation(int x) {
            this._age = x > 0 ? x : 0;
        }

        private void _fullNameValidation(string input)
        {
        int wordCount = 0;
        bool inWord = false;
        string currentWord = "";
        string[] words = new string[10];

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
            {
                //when ever cursor (i) is on the word
                if (inWord)
                {
                    inWord = false;
                    wordCount++;
                    
                    //this.Capitalize1(ref currentWord);
                    this.Capitalize2(ref currentWord);
                    words[wordCount] = currentWord;

                    //after push word to array we reset current word
                    currentWord = "";
                }
            }
            else
            {
                //if the current cursor(i) is not whitespace it means we on the word.
                inWord = true;
                currentWord += input[i];
            }
        }

        //after loop end we check if we was on the word on the last iteration then it means we have a word
        if (inWord)
        {  
            wordCount++;    
            this.Capitalize1(ref currentWord);
            words[wordCount] = currentWord;
        }
        
        if(wordCount < 2){
            Console.WriteLine("Fullname should be at least 2 words");
            return;
        }
         //pack all strings into one string then assing to private prop   
        string result = "";
        foreach(string i in words){
            result += i + " ";
        }
        this._fullName = result;
        }

         //capitalize's string using ascii table order
        public void Capitalize1(ref string r){
            
            string x = "";
            //lower to upper
            if((int) r[0] > 96 && (int) r[0] < 123){
                x += (char)( (int) r[0] - 32 );
            }else{
                x+= r[0];
            }
            
            
            for(int i = 1; i < r.Length; i++){
                x+= r[i];
            }
            r = x;
      
        }

        public Person(string fullName, int age, string phone ) {
            this.FullName = fullName;
            this.Age = age;
            this.Phone = phone;
            
        }
        //Stupid method but works :)
        public void Capitalize2(ref string x)
{
    string r = "";
    switch (x[0])
    {
        case 'a':
            r += 'A';
            break;
        case 'b':
            r += 'B';
            break;
        case 'c':
            r += 'C';
            break;
        case 'd':
            r += 'D';
            break;
        case 'e':
            r += 'E';
            break;
        case 'f':
            r += 'F';
            break;
        case 'g':
            r += 'G';
            break;
        case 'h':
            r += 'H';
            break;
        case 'i':
            r += 'I';
            break;
        case 'j':
            r += 'J';
            break;
        case 'k':
            r += 'K';
            break;
        case 'l':
            r += 'L';
            break;
        case 'm':
            r += 'M';
            break;
        case 'n':
            r += 'N';
            break;
        case 'o':
            r += 'O';
            break;
        case 'p':
            r += 'P';
            break;
        case 'q':
            r += 'Q';
            break;
        case 'r':
            r += 'R';
            break;
        case 's':
            r += 'S';
            break;
        case 't':
            r += 'T';
            break;
        case 'u':
            r += 'U';
            break;
        case 'v':
            r += 'V';
            break;
        case 'w':
            r += 'W';
            break;
        case 'x':
            r += 'X';
            break;
        case 'y':
            r += 'Y';
            break;
        case 'z':
            r += 'Z';
            break;
        default:
            //if char is not ascii value then take the whatever char is
            r += x[0];
            break;
    }
    //in this section we pack strings except 0 index
    for (int i = 1; i < x.Length; i++)
    {
        r += x[i];
    }
    //assing ref to result
    x = r;
}
    }
