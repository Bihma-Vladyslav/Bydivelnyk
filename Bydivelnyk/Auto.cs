using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bydivelnyk
{
    public interface Builder
    {
        string Info();
        void set_radio(string r);
        void set_tone(int t);
        void set_capacity(double c);
        void set_engine(string e);
    }
    //Director
   public abstract class Auto : Builder
    {
        public Auto()
        {

        }
        public Auto(Auto a)
        {
            this.engine = a.engine;
            this.type_of_radio = a.type_of_radio;
            this.tone = a.tone;
            this.tank_capacity = a.tank_capacity;
        }
       public abstract Auto Clone();
        public string Info() 
        {
            return "Версія: " + version + "\nТип радіо: " + type_of_radio + "\nРівень затонованості скла: " 
                + tone + "\nОб'єм бензобаку: " + tank_capacity + "Litr.\nТип двигуна: " + engine;
        }
        protected string version = "";
        protected string type_of_radio = "";
        protected int tone = 1;
        protected double tank_capacity = 1;
        protected string engine = "";
        public void set_radio(string r)
        {
            type_of_radio = r;
        }
        public void set_tone(int t)
        {
            tone = t;
        }
        public void set_capacity(double c)
        {
            tank_capacity = c;
        }
        public void set_engine(string e)
        {
            engine = e;
        }
    }
    public class Auto1 : Auto
    {
        public Auto1()
        {
            version = "E153-42";
        }
        public Auto1(Auto aa): base(aa)
        {
            version = "D64-88";
        }
        public override Auto Clone()
        {
            return new Auto1(this);
        }
    }
    public class Auto2 : Auto
    {
        public Auto2()
        {
            version = "E153-43";
        }
        public Auto2(Auto aa) : base(aa)
        {
            version = "T72-108";
        }
        public override Auto Clone()
        {
            return new Auto2(this);
        }
    }
    public class Auto3 : Auto
    {
        public Auto3()
        {
            version = "E153-44";
        }
        public Auto3(Auto aa) : base(aa)
        {
            version = "B7R-420-Ultra";
        }
        public override Auto Clone()
        {
            return new Auto2(this);
        }
    }
}
