using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veeam.Tasks._1._1._1._1
{
    public class ImmutableTriangle
    {
        private readonly double _length;
        private readonly double _heigth;

        public double Length => _length;
        public double Heigth => _heigth;

        public ImmutableTriangle(double length, double heigth)
        {
            if (length <= 0 || heigth <= 0)
                throw new ArgumentException("Not valid length/heigth for triange!");
            _length = length;
            _heigth = heigth;
        }

        public ImmutableTriangle ChangeHeight(int coefficient)
            => new ImmutableTriangle(_length, _heigth * coefficient);

        public ImmutableTriangle ChangeLength(int coefficient)
            => new ImmutableTriangle(_length * coefficient, _heigth);
    }
}
