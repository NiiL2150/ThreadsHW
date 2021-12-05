using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsHW
{
    [Obsolete]
    public partial class Form1 : Form
    {
        PrimeNumberFinder primeFinder;
        FibonacciNumberFinder fibonacciFinder;

        Thread primeNumbers;
        Thread fibonacciNumbers;

        public Form1()
        {
            InitializeComponent();

            primeFinder = new PrimeNumberFinder();
            fibonacciFinder = new FibonacciNumberFinder();

            primeNumbers = new Thread(CalculatePrime);
            fibonacciNumbers = new Thread(CalculateFibonacci);
        }

        private void AddIntegerToTextBox(int i)
        {
            textBoxMain.Text += i;
            textBoxMain.Text += "; ";
        }

        private void buttonClearMain_Click(object sender, EventArgs e)
        {
            textBoxMain.Clear();
        }

        private void CalculateFibonacci()
        {
            while (true)
            {
                AddIntegerToTextBox(fibonacciFinder.Next());
                Thread.Sleep(1000);
            }
        }

        private void CalculatePrime()
        {
            int? i;
            while((i = primeFinder.NextPrime()) != null)
            {
                AddIntegerToTextBox((int)i);
                Thread.Sleep(1000);
            }
        }

        private void buttonStartPrime_Click(object sender, EventArgs e)
        {
            textBoxPrimeStart.Enabled = false;
            textBoxPrimeFinish.Enabled = false;
            buttonStartPrime.Enabled = false;
            buttonStopPrime.Enabled = true;
            buttonContinuePrime.Enabled = false;
            buttonPausePrime.Enabled = true;

            short min = 0, max = 0;
            primeNumbers = new Thread(CalculatePrime);
            primeFinder.FindPrime
                (Int16.TryParse(textBoxPrimeStart.Text, out min) ? (Int32)min : 1,
                Int16.TryParse(textBoxPrimeFinish.Text, out max) ? (Int32)max : Int16.MaxValue);
            primeNumbers.Start();
        }

        private void buttonStopPrime_Click(object sender, EventArgs e)
        {
            textBoxPrimeStart.Enabled = true;
            textBoxPrimeFinish.Enabled = true;
            buttonStartPrime.Enabled = true;
            buttonStopPrime.Enabled = false;
            buttonContinuePrime.Enabled = false;
            buttonPausePrime.Enabled = false;

            if(primeNumbers.ThreadState == ThreadState.Suspended)
            {
                primeNumbers.Resume();
            }
            primeNumbers.Abort();
        }

        private void buttonPausePrime_Click(object sender, EventArgs e)
        {
            buttonPausePrime.Enabled = false;
            buttonContinuePrime.Enabled = true;

            primeNumbers.Suspend();
        }

        private void buttonContinuePrime_Click(object sender, EventArgs e)
        {
            buttonPausePrime.Enabled = true;
            buttonContinuePrime.Enabled = false;

            primeNumbers.Resume();
        }

        private void buttonStartFibonacci_Click(object sender, EventArgs e)
        {
            buttonStartFibonacci.Enabled = false;
            buttonStopFibonacci.Enabled = true;
            buttonContinueFibonacci.Enabled = false;
            buttonPauseFibonacci.Enabled = true;

            fibonacciNumbers = new Thread(CalculateFibonacci);
            fibonacciFinder.Reset();
            fibonacciNumbers.Start();
        }

        private void buttonStopFibonacci_Click(object sender, EventArgs e)
        {
            buttonStartFibonacci.Enabled = true;
            buttonStopFibonacci.Enabled = false;
            buttonContinueFibonacci.Enabled = false;
            buttonPauseFibonacci.Enabled = false;

            if (fibonacciNumbers.ThreadState == ThreadState.Suspended)
            {
                fibonacciNumbers.Resume();
            }
            fibonacciNumbers.Abort();
        }

        private void buttonPauseFibonacci_Click(object sender, EventArgs e)
        {
            buttonPauseFibonacci.Enabled = false;
            buttonContinueFibonacci.Enabled = true;

            fibonacciNumbers.Suspend();
        }

        private void buttonContinueFibonacci_Click(object sender, EventArgs e)
        {
            buttonPauseFibonacci.Enabled = true;
            buttonContinueFibonacci.Enabled = false;

            fibonacciNumbers.Resume();
        }
    }
}
