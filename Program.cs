using System;
using System.IO;
using System.Text;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ディレクトリ作成
             string path = @"C:\Users\<!--あとで考える-->\Desktop\C#\MyTest.rb"; //あとでパスの設定をする
        try
        {
            // ファイルを作成するか、ファイルが存在する場合は上書きします。
            
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("test"); // 中身をutf-8でtxtの中に書き込む
                // ファイルにいくつかの情報を追加します。 
                fs.Write(info, 0, info.Length);
            }

            // ストリームを開いて読み返します。
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
            
        }
    }
}
