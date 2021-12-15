using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;

public static class FontUtil
{
    public static LoadedFont LoadFont(FileInfo file, int fontSize, FontStyle fontStyle)
    {
        var fontCollection = new PrivateFontCollection();
        fontCollection.AddFontFile(file.FullName);
        if (fontCollection.Families.Length < 0)
        {
            throw new InvalidOperationException("No font familiy found when loading font!");
        }

        var loadedFont = new LoadedFont();
        loadedFont.FontFamily = fontCollection.Families[0];
        loadedFont.Font = new Font(loadedFont.FontFamily, fontSize, fontStyle, GraphicsUnit.Pixel);
        return loadedFont;
    }
}