using System.Reflection.Metadata.Ecma335;

namespace C__OOP_HW006_class_inherit_r00
{
    internal class Material
    {
        private string[] materials;
        public string[] Materials
        {
            get { return materials; }
            set
            {
                materials = new string[value.Length];

                for (int i = 0; i < value.Length; i++)
                {
                    materials[i] = value[i];
                }
            }
        }

        public Material() : this(null) { }

        public Material(params string[]? materials)
        {
            if (materials != null) { this.materials = materials; }
        }

        public string GetInfo()
        {
            string? temp = null;
            for (int i = 0; i < (materials != null ? materials.Length : 0); i++)
            {
                temp += materials[i] + " | ";
            }
            return temp;
        }
    }
}
