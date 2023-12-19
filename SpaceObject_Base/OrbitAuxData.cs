using System.Numerics;

namespace C__OOP_HW006_class_inherit_r00.SpaceObject_Base
{
    public class OrbitAuxData
    {
        public int phase { get; set; }

        private readonly int PHASE_SIZE = 4;
        public readonly int[,] MFACTORS;
        public readonly int lengthV;

        public int countV { get; set; }
        public int indexV { get; set; }

        public OrbitAuxData(in int lengthV)
        {
            phase = 0;
            countV = 0;
            indexV = -1;
            PHASE_SIZE = 4;
            MFACTORS = new int[,] { { -1, 1 }, { 1, 1 }, { 1, -1 }, { -1, -1 } };
            this.lengthV = lengthV;
        }

        public void UpdateIndexV()
        {
            phase += countV == lengthV ? 1 : 0;
            bool flag = phase % 2 == 0; ;

            phase = phase == PHASE_SIZE ? 0 : phase;

            if (flag && countV == lengthV) { indexV = -1; }
            else if (!flag && countV == lengthV) { indexV = lengthV; }

            countV = countV == lengthV ? 0 : countV;

            countV += 1;

            indexV += flag ? +1 : -1;
        }

    }
}
