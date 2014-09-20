using System;


namespace DefiningClasses02LaptopShop
{
    class Battery
    {
        private BatteryType type;
        private short cells;
        private ushort capacity;

        public Battery(BatteryType t, short c, ushort ca)
        {
            this.type = t;
            this.Cells = c;
            this.Capacity = ca;
        }

        public short Cells
        {
            get { return this.cells; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("False cells value");
                }
                this.cells = value;
            }
        }

        public ushort Capacity
        {
            get { return this.capacity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("False capacity value");
                }
                this.capacity = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}-cells, {2} mAh", this.type, this.cells, this.capacity);
        }
    }
}
