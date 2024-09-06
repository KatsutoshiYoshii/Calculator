using Calculator;
using System.Runtime.CompilerServices;

namespace FrmCalculator
{
    public partial class FrmCalculator : Form
    {
        private bool LabelOverwrite = true; //�\�����x���̏㏑��
        private bool NumPlus = true; // +/- �{�^���̐�������
        private bool NumDot = false; // .�h�b�g �̗L������
        private double dNum; //���x����double�^�Ɋi�[����ϐ�
        private double dNumPool; //���x���̐������v�[������ϐ�
        private ICalc? Methods = null;//�v�Z���@

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void bOne_Click(object sender, EventArgs e)
        {
            if(LabelOverwrite == true)
            {
                lblDisplay.Text = "1";
                LabelOverwrite = false;
            }
            else
            {
                lblDisplay.Text += "1";
            }
        }

        private void bTwo_Click(object sender, EventArgs e)
        {
            if (LabelOverwrite == true)
            {
                lblDisplay.Text = "2";
                LabelOverwrite = false;
            }
            else
            {
                lblDisplay.Text += "2";
            }
        }

        private void bThree_Click(object sender, EventArgs e)
        {
            if (LabelOverwrite == true)
            {
                lblDisplay.Text = "3";
                LabelOverwrite = false;
            }
            else
            {
                lblDisplay.Text += "3";
            }
        }

        private void bFour_Click(object sender, EventArgs e)
        {
            if (LabelOverwrite == true)
            {
                lblDisplay.Text = "4";
                LabelOverwrite = false;
            }
            else
            {
                lblDisplay.Text += "4";
            }
        }

        private void bFive_Click(object sender, EventArgs e)
        {
            if (LabelOverwrite == true)
            {
                lblDisplay.Text = "5";
                LabelOverwrite = false;
            }
            else
            {
                lblDisplay.Text += "5";
            }
        }

        private void bSix_Click(object sender, EventArgs e)
        {
            if (LabelOverwrite == true)
            {
                lblDisplay.Text = "6";
                LabelOverwrite = false;
            }
            else
            {
                lblDisplay.Text += "6";
            }
        }

        private void bSeven_Click(object sender, EventArgs e)
        {
            if (LabelOverwrite == true)
            {
                lblDisplay.Text = "7";
                LabelOverwrite = false;
            }
            else
            {
                lblDisplay.Text += "7";
            }
        }

        private void bEight_Click(object sender, EventArgs e)
        {
            if (LabelOverwrite == true)
            {
                lblDisplay.Text = "8";
                LabelOverwrite = false;
            }
            else
            {
                lblDisplay.Text += "8";
            }
        }

        private void bNine_Click(object sender, EventArgs e)
        {
            if (LabelOverwrite == true)
            {
                lblDisplay.Text = "9";
                LabelOverwrite = false;
            }
            else
            {
                lblDisplay.Text += "9";
            }
        }

        private void bZero_Click(object sender, EventArgs e)
        {
            if (LabelOverwrite == true)
            {
                lblDisplay.Text = "0";
            }
            else
            {
                lblDisplay.Text += "0";
            }
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            NumDot = false;
            LabelOverwrite = true;
            NumPoolMethods();
            Methods = FactoryCalcMethods.Factory((int)EMethods.Puls);
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            NumDot = false;
            LabelOverwrite = true;
            NumPoolMethods();
            Methods = FactoryCalcMethods.Factory((int)EMethods.Minus);
        }

        private void bMultiply_Click(object sender, EventArgs e)
        {
            NumDot = false;
            LabelOverwrite = true;
            NumPoolMethods();
            Methods = FactoryCalcMethods.Factory((int)EMethods.Multply);
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            NumDot = false;
            LabelOverwrite = true;
            NumPoolMethods();
            Methods = FactoryCalcMethods.Factory((int)EMethods.Division);
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            LabelOverwrite = true;
            NumDot = false;
            dNumPool = 0;
            Methods = null;
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            NumPoolMethods();
            Methods = null;
            NumDot = false;
            LabelOverwrite = true;
        }

        private void NumPoolMethods()
        {
            //�v�Z���s��
            dNum = double.Parse(lblDisplay.Text);
            if (Methods == null)
            {
                dNumPool = dNum;
            }
            else
            {
                writeLogs(dNumPool.ToString() + Methods.symbol + dNum);
        
                try
                {
                    dNumPool = Methods.Calc(dNumPool, dNum);

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                writeLogs("=" + dNumPool.ToString());
              
            }

            lblDisplay.Text = dNumPool.ToString();
        }


        //���O�f�[�^�̏�������
        private void writeLogs(string logText)
        {
            //���O�̕\��
            if (txtLog.Text == "")
            {
                txtLog.Text = logText;
            }
            else
            {
                txtLog.Text += Environment.NewLine + logText;
            }

            //�R���\�[���փ��O�����o��
            //log4net�ŏꍇ�����ݒ肪��肭�s���Ȃ������̂ŁADebug.WriteLine�Œ��ڏ�������
            System.Diagnostics.Debug.WriteLine(logText);

            //���O�t�@�C���ւ̏�������
            log.Debug(logText);
        }


        private void bSign_Click(object sender, EventArgs e)
        {
            if (NumPlus == true)
            {
                lblDisplay.Text = "-" + lblDisplay.Text;
                NumPlus = false;
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text.Replace("-", "");
                NumPlus = true;
            }
        }

        private void bDecimalPoint_Click(object sender, EventArgs e)
        {
            if(NumDot == false)
            {
                lblDisplay.Text = lblDisplay.Text + ".";
                NumDot = true;
                LabelOverwrite = false;
            }
        }
    }
}
