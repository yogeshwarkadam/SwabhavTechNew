using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictactoeCore
{
    public class Cell
    {
        private MarkType mark;
        public Cell()
        {
            this.mark = MarkType.Empty;
        }

        public bool IsMarked()
        {
            if (mark == MarkType.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsMarkCellTwice(MarkType inputMarkType)
        {
            try
            {
                if (mark == inputMarkType)
                {
                    throw new Exception("you tried to Mark cell twice....try another cell");
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }

        public MarkType Mark
        {
            get
            {
                return mark;
            }
            set
            {
                mark = value;
            }
        }
    }
}
