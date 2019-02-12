namespace ConsoleApp1
{
    public class Rettangolo : IRettangolo
    {
        public int Perimetro(int latoBase, int latoAltezza)
        {
            return (latoBase + latoAltezza) * 2;
        }

        public int Area(int latoBase, int latoAltezza)
        {
            return (latoBase * latoAltezza);
        }
    }
}
