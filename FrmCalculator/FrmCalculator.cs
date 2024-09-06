using Calculator;
using System.Runtime.CompilerServices;

namespace FrmCalculator
{
    public partial class FrmCalculator : Form
    {
        private bool LabelOverwrite = true; //表示ラベルの上書き
        private bool NumPlus = true; // +/- ボタンの正負判定
        private bool NumDot = false; // .ドット の有無判定
        private double dNum; //ラベルをdouble型に格納する変数
        private double dNumPool; //ラベルの数字をプールする変数
        private ICalc? Methods = null;//計算方法

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
            //計算を行う
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


        //ログデータの書き込み
        private void writeLogs(string logText)
        {
            //ログの表示
            if (txtLog.Text == "")
            {
                txtLog.Text = logText;
            }
            else
            {
                txtLog.Text += Environment.NewLine + logText;
            }

            //コンソールへログ情報を出力
            //log4netで場合分け設定が上手く行かなかったので、Debug.WriteLineで直接書き込み
            System.Diagnostics.Debug.WriteLine(logText);

            //ログファイルへの書き込み
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
