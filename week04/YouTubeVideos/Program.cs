using System;

class Program
{
    static void Main(string[] args)
    {
        Comment com1 = new Comment("Carlos","First");
        Comment com2 = new Comment("VivaLaSpain", "like this one");
        Comment com3 = new Comment("redScyth","Beautiful");

        Comment com4 = new Comment("User1","Great video! I learned so much from this. Keep up the awesome work! 👏");
        Comment com5 = new Comment("TechieTom","This tutorial was super helpful! Thanks for breaking everything down so clearly. 😎");
        Comment com6 = new Comment("MusicLover22","I love your content! Always bringing something new and exciting. Can't wait for the next one! 🎶");

        Comment com7 = new Comment("GamerXpress","Awesome gameplay! Your skills are insane. Definitely subscribing for more! 🎮");
        Comment com8 = new Comment("VlogMaster","Such a fun and entertaining vlog! You always put a smile on my face. 😊");
        Comment com9 = new Comment("FoodieFan","This recipe looks delicious! I’m definitely going to try it out. Thanks for sharing! 🍴");


        Video vid1 = new Video("Owl's song","nifty", 8.00);
        vid1._comment.Add(com1);
        vid1._comment.Add(com2);
        vid1._comment.Add(com3);
        vid1.Display();

        Video vid2 = new Video("How to Make the Perfect Chocolate Cake – Easy Recipe!","SweetTreatsChef", 12.35);
        vid2._comment.Add(com9);
        vid2._comment.Add(com5);
        vid2._comment.Add(com4);
        vid2.Display();

        Video vid3 = new Video("Epic Gaming Skills – Insane Gameplay Moments!","ProGamerAce", 8.45);
        vid3._comment.Add(com6);
        vid3._comment.Add(com7);
        vid3._comment.Add(com8);
        vid3.Display();

    }
}