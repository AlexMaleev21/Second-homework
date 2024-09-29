using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class MusicInstrument
    {
        public string Sounds { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string HistoryText { get; set; }

        public MusicInstrument(string sounds, string name, string description, string historyText)
        {
            Sounds = sounds;
            Name = name;
            Description = description;
            HistoryText = historyText;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"Musical instrument sounds: {Sounds}");
            Console.WriteLine();
        }

        public virtual void Show()
        {
            Console.WriteLine($"Musical instrument name: {Name}");
            Console.WriteLine();
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Musical instrument description: {Description}");
            Console.WriteLine();
        }

        public virtual void History()
        {
            Console.WriteLine($"Musical instrument history: {HistoryText}");
            Console.WriteLine();
        }
    }

    public class Violin: MusicInstrument
    {

        public Violin(string sounds, string name, string description, string historyText): base(sounds, name, description, historyText)
        {
            Sounds = sounds;
            Name = name;
            Description = description;
            HistoryText = historyText;
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name} sounds: {Sounds}");
            Console.WriteLine();
        }

        public override void Show()
        {
            Console.WriteLine($"{Name} name: {Name}");
            Console.WriteLine();
        }

        public override void Desc()
        {
            Console.WriteLine($"{Name} description: {Description}");
            Console.WriteLine();
        }

        public override void History()
        {
            Console.WriteLine($"{Name} historyText: {HistoryText}");
            Console.WriteLine();
        }
    }
    public class Trombone : MusicInstrument
    {

        public Trombone(string sounds, string name, string description, string historyText) : base(sounds, name, description, historyText)
        {
            Sounds = sounds;
            Name = name;
            Description = description;
            HistoryText = historyText;
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name} sounds: {Sounds}");
            Console.WriteLine();
        }

        public override void Show()
        {
            Console.WriteLine($"{Name} name: {Name}");
            Console.WriteLine();
        }

        public override void Desc()
        {
            Console.WriteLine($"{Name} description: {Description}");
            Console.WriteLine();
        }

        public override void History()
        {
            Console.WriteLine($"{Name} historyText: {HistoryText}");
            Console.WriteLine();
        }
    }
    public class Ukulele : MusicInstrument
    {

        public Ukulele(string sounds, string name, string description, string historyText) : base(sounds, name, description, historyText)
        {
            Sounds = sounds;
            Name = name;
            Description = description;
            HistoryText = historyText;
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name} sounds: {Sounds}");
            Console.WriteLine();
        }

        public override void Show()
        {
            Console.WriteLine($"{Name} name: {Name}");
            Console.WriteLine();
        }

        public override void Desc()
        {
            Console.WriteLine($"{Name} description: {Description}");
            Console.WriteLine();
        }

        public override void History()
        {
            Console.WriteLine($"{Name} historyText: {HistoryText}");
            Console.WriteLine();
        }
    }
    public class Cello : MusicInstrument
    {

        public Cello(string sounds, string name, string description, string historyText) : base(sounds, name, description, historyText)
        {
            Sounds = sounds;
            Name = name;
            Description = description;
            HistoryText = historyText;
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name} sounds: {Sounds}");
            Console.WriteLine();
        }

        public override void Show()
        {
            Console.WriteLine($"{Name} name: {Name}");
            Console.WriteLine();
        }

        public override void Desc()
        {
            Console.WriteLine($"{Name} description: {Description}");
            Console.WriteLine();
        }

        public override void History()
        {
            Console.WriteLine($"{Name} historyText: {HistoryText}");
            Console.WriteLine();
        }
    }
    internal class Task2
    {
        MusicInstrument violin = new Violin("Violin sounds", "Violin", "The violin is a small, four-stringed instrument played with a bow, producing a bright and expressive sound across a wide range of musical styles.", "The violin, developed in 16th-century Italy, evolved from earlier string instruments and became a key part of classical and modern music.");
        MusicInstrument trombone = new Trombone("Trombone sounds", "Trombone", "The trombone is a brass instrument with a unique telescoping slide mechanism, producing deep, resonant tones across a wide range of musical genres.", "The trombone, originating in the 15th century as the sackbut, evolved into its modern form during the Renaissance and became a key instrument in orchestras, jazz, and brass bands.");
        MusicInstrument ukulele = new Ukulele("Ukulele sounds", "Ukulele", "The ukulele is a small, four-stringed instrument from Hawaii, known for its bright, cheerful sound and compact size, often used in folk and popular music.", "The ukulele, introduced to Hawaii by Portuguese immigrants in the late 19th century, quickly became a symbol of Hawaiian music and gained worldwide popularity for its light, melodic sound.");
        MusicInstrument cello = new Cello("Cello sounds", "Cello", "The cello is a large, four-stringed bowed instrument from the violin family, known for its rich, deep tones and versatile range, commonly used in classical and modern music.", "The cello, developed in 16th-century Italy as part of the violin family, evolved into a central instrument in orchestras and chamber music due to its deep, resonant sound.");

        public void TestTask2()
        {
            violin.Sound();
            violin.Show();
            violin.Desc();
            violin.History();

            trombone.Sound();
            trombone.Show();
            trombone.Desc();
            trombone.History();

            ukulele.Sound();
            ukulele.Show();
            ukulele.Desc();
            ukulele.History();

            cello.Sound();
            cello.Show();
            cello.Desc();
            cello.History();
        }

    }
}
