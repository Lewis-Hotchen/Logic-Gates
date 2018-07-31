using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoolGate.App_Code.Gates;

namespace BoolGate {
    public partial class Form1 : Form {
        static Gates gates = new Gates();
        bool x, y, z;
        bool res;

        public delegate bool ExecuteCircuit(bool x, bool y, bool z);
        public delegate bool ExecuteFlip(bool flip);
        public List<GATES> gateTypes;
        ExecuteCircuit ec;
        ExecuteFlip ef;


        public bool executeGate(bool x, bool y, GATES.GATETYPE gatetype) {
            switch (gatetype) {
                case GATES.GATETYPE.AND:
                    return gates.AND(x, y);

                case GATES.GATETYPE.NAND:
                    return gates.NAND(x, y);

                case GATES.GATETYPE.NOR:
                    return gates.NOR(x, y);

                case GATES.GATETYPE.OR:
                    return gates.OR(x, y);

                case GATES.GATETYPE.XNOR:
                    return gates.XNOR(x, y);

                case GATES.GATETYPE.XOR:
                    return gates.XOR(x, y);
                default:
                    MessageBox.Show("Error!!!");
                    return false;
            }
        }

        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void chkInputX_CheckedChanged(object sender, EventArgs e) {
            if (chkInputX.Checked) {
                x = true;
            } else {
                x = false;
            }
        }

        private void chkInputY_CheckedChanged(object sender, EventArgs e) {
            if (chkInputY.Checked) {
                y = true;
            } else {
                y = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (chkBoxZ.Checked) {
                z = true;
            } else {
                z = false;
            }
        }

        private void cmbGate2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnSubmit_Click(object sender, EventArgs e) {

            switch (comboBox1.SelectedItem.ToString()) {
                case "AND":
                    ec += gates.AND;
                    break;
                case "OR":
                    ec += gates.OR;
                    break;
                case "NAND":
                    ec += gates.NAND;
                    break;
                case "NOR":
                    ec += gates.NOR;
                    break;
                case "XOR":
                    ec += gates.XOR;
                    break;
                case "XNOR":
                    ec += gates.XNOR;
                    break;
                default:
                    lblOutput.Text = "Invalid!";
                    break;
            }
            if(cmbGate2.SelectedItem != null) {
switch (cmbGate2.SelectedItem.ToString()) {
                case "AND":
                    ec += gates.AND;
                    break;
                case "OR":
                    ec += gates.OR;
                    break;
                case "NAND":
                    ec += gates.NAND;
                    break;
                case "NOR":
                    ec += gates.NOR;
                    break;
                case "XOR":
                    ec += gates.XOR;
                    break;
                case "XNOR":
                    ec += gates.XNOR;
                    break;
                default:
                    lblOutput.Text = "Invalid!";
                    break;
            }
            }
            
            res = ec.Invoke(x, y, z);
            lblOutput.Text = res.ToString();
        }
    }

    public class GATES {
        public enum GATETYPE { AND, OR, NAND, NOR, XOR, XNOR, NOT, EMPTY }
    }
}
