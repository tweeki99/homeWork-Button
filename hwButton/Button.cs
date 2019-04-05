using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hwButton
{
    public delegate void ButtonEventHandler();

    public class Button
    {
        public event ButtonEventHandler Click;
        
        public int Lenght { get; set; }
        public int Width { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        
        public Button(int lenght, int width, int left, int top)
        {
            Click += OnClick;

            Lenght = lenght;
            Width = width;
            Left = left;
            Top = top;

            ShowButton('*');
        }

        public void ReadButton()
        {
            while (true)
            {
                var dfg = Console.ReadKey();
                if (dfg.KeyChar == '\r')
                Click?.Invoke();
            }
        }

        public void OnClick()
        {
            ShowButton('#');
            Thread.Sleep(500);
            ShowButton('*');
        }

        public void ShowButton(char symbol)
        {
            for (int j = 0; j < Width; j++)
            {
                Console.SetCursorPosition(Left, Top + j);
                for (int i = 0; i < Lenght; i++)
                {
                    if (j == 0 || j == Width - 1) Console.Write(symbol);
                    else if (i == 0 || i == Lenght - 1) Console.Write(symbol);
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
