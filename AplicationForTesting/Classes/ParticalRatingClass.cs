using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AplicationForTesting
{
    public partial class StudentsResulst
    {

        public SolidColorBrush ResoultColor
        {
            get
            {

                switch (Result)
                {
                    case 2:
                        return Brushes.Red;
                    case 3:
                        return Brushes.Orange;
                    case 4:
                        return Brushes.ForestGreen;
                    case 5:
                        return Brushes.GreenYellow;
                    default:
                        return Brushes.White;
                }

            }
        }
    }
}