namespace C__OOP_HW006_class_inherit_r00.SpaceObject_Base
{
    public class DataObject
    {
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                {
                    speed = Math.Abs(value);
                }
            }
        }

        public string? name { get; set; }

        public DataObject() : this(0, null) { }

        public DataObject(int speed, string? name)
        {
            this.speed = speed;
            this.name = name;
        }

        public string GetInfo()
        {
            return $"name -> {name} | speed -> {speed}";
        }
    }
}
