using System;

namespace Library
{
    public class Car
    {

        public string Color { get; set; }
        public string Brand { get; set; }
        public string year { get; set; }
        public bool IsOn { get; private set; }


        public bool StartEngine()
        {
            if (!this.IsOn)
            {
                this.IsOn = true;
            }
            return true;
        }

        public bool StopEngine()
        {
            if (this.IsOn)
            {
                this.IsOn = false;
            }
            return true;
        }

    }
}
