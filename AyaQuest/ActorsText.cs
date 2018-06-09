using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyaQuest
{
    public enum TextStatus
    {
        none,
        bad,
        good
    }

    public enum Actors
    {
        Aya,
        Nobody,
        Somebody,
        Arost,
        elph,
        graph,
        pharlan,
        saver,
        severein,
        man
    }

    public class QText
    {
        public QText(Actors actor, TextStatus status, string text)
        {
            Note = text;
            Status = status;
            Actor = actor;
        }
        public TextStatus Status { get; }
        public string Note { get; }
        public QActor Actor { get; }
    }

    public class QActor
    {
        public QActor(Actors Actor)
        {
            this.Actor = Actor;
        }

        public Actors Actor { get; }

        public string GetName()
        {
            switch (Actor)
            {
                case Actors.Aya:
                    return "Ая";
                case Actors.Arost:
                    return "Аристократ";
                case Actors.elph:
                    return "Эльф";
                case Actors.graph:
                    return "Граф Вейланд";
                case Actors.man:
                    return "Мужчина";
                case Actors.Nobody:
                    return "Незнакомец";
                case Actors.pharlan:
                    return "Фарлан";
                case Actors.saver:
                    return "Хранитель";
                case Actors.severein:
                    return "севирейн";
                case Actors.Somebody:
                    return "Кто-то";
                default:
                    return "АКТЕР НЕ ВЫБРАН";
            }
        }

        public override string ToString()
        {
            return GetName();
        }

        public static implicit operator QActor(Actors Actor)
        {
            return new QActor(Actor);
        }
    }

    public static class ActorsText
    {
        static readonly QText[] Aya = new QText[]
        {
            //new QText(Actors.Aya, TextStatus.none, ""),
            //new QText(Actors.Aya, TextStatus.none, ""),
            //new QText(Actors.Aya, TextStatus.none, ""),
            //new QText(Actors.Aya, TextStatus.none, ""),
            //new QText(Actors.Aya, TextStatus.none, ""),
            //...
        };
    }
}
