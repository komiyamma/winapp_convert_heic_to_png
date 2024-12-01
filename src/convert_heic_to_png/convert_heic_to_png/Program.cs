using ImageMagick;

public class Program
{
    public static void Main(string[] args)
    {
        string? targetDir = Path.GetDirectoryName(args[0]);
        if (targetDir == null)
        {
            return;
        }

        string? targetFile = Path.GetFileNameWithoutExtension(args[0]);
        if (targetFile == null)
        {
            return;
        }

        string inputPath = args[0];
        string outputPath = Path.Combine(targetDir, targetFile + ".png");

        using (var image = new MagickImage(inputPath))
        {
            // image.Resize(output_width, output_height); // 幅と高さを50%に縮小
            image.Write(outputPath);
        }

        Console.WriteLine("変換完了: " + outputPath);
    }
}