using static System.Console;

namespace Chapter_3
{
    /// <summary>
    /// Шаблон сарая
    /// </summary>
	public class Shed
    {
        #region Values
        int width, height;
        static int ObjectsNumber = 0;

        public int Width
        {
            get
            { return width; }
            set
            { width = value; }
        }

        public int Height
        {
            get
            { return height; }
            set
            { height = value; }
        }

        public int Lenghtwise { get; set; }
        #endregion

        public Shed()
        {
            ObjectsNumber++;
            Console.WriteLine($"base class is '{typeof(Shed).Name}'");
        }

        public int GetSize()
        {
            return Width * Height * Lenghtwise;
        }

        public int GetObjectsNumber()
        {
            return ObjectsNumber;
        }

        public void ExpandSize(int x, int y, int h)
        {
            Width += x;
            Height += h;
            Lenghtwise += y;
        }

        public void ExpandTroughSum(ref int x, ref int y, ref int h, out int result)
        {
            result = (Width += x) * (Lenghtwise += y) * (Height += h);
        }
        
        public void SetDimensions(params int[] values)
        {
            Width = values[0];
            Height = values[1];
            Lenghtwise = values[2];
        }

        public class Window
        {
            public void ShutWindow()
            {
                Console.WriteLine("window now close");
            }

        }

        public Window window = new();

        public Window FrontWindow
        {
            get { return window; }
            set { window = value; }
        }
    }
}

