using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolGate.App_Code.Gates {

    class Gates {

        public Gates() {

        }

        public bool AND(bool one, bool two) {
            if (one && two) {
                return true;
            }
            return false;
        }

        public bool AND(bool one, bool two, bool three) {
            if (one && two && three) {
                return true;
            }
            return false;
        }

        public bool OR(bool one, bool two) {
            if (one || two) {
                return true;
            }
            return false;
        }

        public bool OR(bool one, bool two, bool three) {
            if (one || two || three) {
                return true;
            }
            return false;
        }

        public bool NOT(bool flip) {
            return !flip;
        }

        public bool XOR(bool one, bool two) {
            if (one ^ two) {
                return true;
            }
            return false;
        }

        public bool XOR(bool one, bool two, bool three) {
            if (one ^ two ^ three) {
                return true;
            }
            return false;
        }

        public bool NAND(bool one, bool two) {
            if (one && two) {
                return false;
            }
            return true;
        }

        public bool NAND(bool one, bool two, bool three) {
            if (one && two && three) {
                return false;
            }
            return true;
        }

        public bool NOR(bool one, bool two) {
            if (one || two) {
                return false;
            }
            return true;
        }

        public bool NOR(bool one, bool two, bool three) {
            if (one || two || three) {
                return false;
            }
            return true;
        }

        public bool XNOR(bool one, bool two) {
            if (one ^ two) {
                return false;
            }
            return true;
        }

        public bool XNOR(bool one, bool two, bool three) {
            if (one ^ two ^ three) {
                return false;
            }
            return true;
        }
    }
}
