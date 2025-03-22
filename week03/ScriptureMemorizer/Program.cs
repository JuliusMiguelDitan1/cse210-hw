using System;

// This program  is based on this code https://github.com/glaubervilane/CSE210/blob/main/TeamActivity/Week06/Scripture.cs

class Program
{
    static void Main(string[] args)
    {
        Databank library = new Databank();

        library.AddScripture(new Reference("John", 3, 16), "¶ For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        library.AddScripture(new Reference("Proverbs", 3, 5, 6), "My son, forget not my law; but let thine heart keep my commandments: For length of days, and long life, and peace, shall they add to thee. Let not mercy and truth forsake thee: bind them about thy neck; write them upon the table of thine heart:");
        library.AddScripture(new Reference("Alma", 48, 19), "Now behold, Helaman and his brethren were no less serviceable unto the people than was Moroni; for they did preach the word of God, and they did baptize unto repentance all men whosoever would hearken unto their words.");
        library.AddScripture(new Reference("Isaiah", 40, 31), "But those who hope in the Lord will renew their strength.");
        library.AddScripture(new Reference("Matthew", 11, 28), "Come to me, all you who are weary and burdened, and I will give you rest.");
        library.AddScripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me.");
        library.AddScripture(new Reference("2 Thessalonians ", 3, 13), "But ye, brethren, be not weary in well doing.");

       while (true)
        {
            Console.Clear();

            Scripture scripture = library.SelectRandomScripture();


            if (scripture != null)
            {
                // Display and interact with the selected scripture
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(scripture.Displayall());


                    Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        return;

                    scripture.HideRandomWords();

                    if (scripture.IsCompletelyHidden())
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("The scripture library is empty. Add scriptures or load them from files.");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                return;
            }
         }
    }
}