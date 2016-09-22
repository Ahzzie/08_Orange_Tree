using System;

namespace _08_Orange_Tree
{
    internal class OrangeTree
    {
        private int age;
        private int height;

        public OrangeTree(int age, int height)
        {
            this.Age = 0;
            this.Height = 6;
            this.NumOranges = 0;
        }

        public int Age
        {
            get { return age;}
            set { age = value;}
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int NumOranges
        {
            get;
            set;
        }
        private int orangeseaten;
        public int OrangesEaten
        {
            get { return orangeseaten; }
            set { orangeseaten = value; }
        }
        public bool TreeAlive
        {
            get;
            set;
        }

        internal void OneYearPasses()
        {
            Age++;
            Height += 2;
            if (Age<2)
            {
                NumOranges = 0;
            }
            else
            {
                NumOranges = (Age - 1) * 5;
            }
        }

        internal void EatOrange(int v)
        {
            OrangesEaten += v;

            if (NumOranges == 0)
            {
                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            }
        }
    }
}