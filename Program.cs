namespace MapGenerator;

class Program
{
    static void Main(string[] args)
    {
        File.WriteAllLines("/home/poci/Desktop/C++/renderer/map.txt", GenerateMap(24, 24));
    }

    static string[] GenerateMap(int width, int height)
    {
        string[] map = new string[height];
        for (int i = 0; i < height; i++)
        {
            string line = "";
            for (int j = 0; j < width; j++)
            {
                if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                {
                    line += "1,255,0,0;";
                }
                else
                {
                    line += "0;";
                }
            }

            map[i] = line;
        }

        return map;
    }
}