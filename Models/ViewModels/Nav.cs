using System.Numerics;

namespace BookStore.Models
{
    public static class Nav
    {
        public static string Active(string value, string current) => (value == current) ? "active" : "";     // feltételes kifejezés az kérdőjel

        public static string Active(int value, int current) => (value == current) ? "active" : "";

    }
}
