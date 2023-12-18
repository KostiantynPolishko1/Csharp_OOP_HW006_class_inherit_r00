namespace C__OOP_HW006_class_inherit_r00
{
    internal class VectorPoint3D
    {
        private Point3D[]? arrVectors;
        public Point3D[] ArrVectors
        {
            get { return arrVectors; }
            set
            {
                if (value != null)
                {
                    arrVectors = new Point3D[value.Length];
                    for (int i = 0; i < value.Length; i++)
                    {
                        arrVectors[i] = value[i];
                    }
                }
            }
        }

        public VectorPoint3D() : this(null) { }

        public VectorPoint3D(in Point3D[]? ArrVectors)
        {
            this.ArrVectors = ArrVectors;
        }

        public override string ToString()
        {
            if (ArrVectors == null)
                return "no vectors";

            string? temp = null;
            temp += $"{GetType().Name}\n";
            for (int i = 0; i < ArrVectors.Length; i++)
            {
                temp += $"{i + 1} - ({ArrVectors[i].coordX}, {ArrVectors[i].coordY}, {ArrVectors[i].coordZ})\n";
            }
            return temp;
        }

    }
}