using System;
using System.Text;

namespace Base64EncodeStudy;

class Program
{
    static void Main(string[] args)
    {
        string originalString = "あいうえお";
        Console.WriteLine("元の文字列 : " + originalString);

        byte[] originalByte = Encoding.UTF8.GetBytes(originalString);
        Console.WriteLine("元のバイト文字列 : " + BitConverter.ToString(originalByte));

        string encodeString = Convert.ToBase64String(originalByte);
        Console.WriteLine("エンコードした文字列 : " + encodeString);

        byte[] decodeByte = Convert.FromBase64String(encodeString);
        Console.WriteLine("デコードしたバイト配列 : " + BitConverter.ToString(decodeByte));

        string decodeString = Encoding.UTF8.GetString(decodeByte);
        Console.WriteLine("デコードした文字列 : " + decodeString);
    }
}
