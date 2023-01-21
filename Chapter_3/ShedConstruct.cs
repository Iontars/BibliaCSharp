using System;
namespace Chapter_3
{
    /// <summary>
    /// Шаблон сарая, игры с конструктором
    /// </summary>
	public class ShedConstruct
	{
        #region Values

        int width, height;

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

        public ShedConstruct(int width, int height, int lenghtwise, string numberOfMessage) : this(numberOfMessage)
		{
            Width = width;
            Height = height;
            Lenghtwise = lenghtwise;
		}
        public ShedConstruct(string numberOfMessage)
        {
            ChooseMessage(numberOfMessage);
        }

        public int GetSize(int w, int h, int l)
        {
            return w * h * l;
        }

        private void ChooseMessage(string value)
        {
            switch (value)
            {
                case "1": ScreenTheMessage(value); break;
                case "2": ScreenTheMessage(value); break;
                case "3": ScreenTheMessage(value); break;
                default: Console.WriteLine("The correct value is not selected");
                    break;
            }
        }

        private void ScreenTheMessage(string value)
        {
            Console.WriteLine($"#{value} Called by the ShedConstruct's class Constructor");
        }
    }
}

