using Ali.Store.API.Models;
using System.Text.Json;

namespace Ali.Store.API.Shared
{
    public static class Share
    {
        public static AliexpressItem ParseHtml(string content)
        {
            try
            {
                string findFragment = "window.runParams = {\n                            data: ";
                int start = content.IndexOf(findFragment);
                content = content[start..];
                content = content[findFragment.Length..];
                int end = content.IndexOf("};");
                content = content[..(end + 1)];
                content = content.Trim();
                content = content[..^1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            File.WriteAllText("../../g.html", content);
            return JsonSerializer.Deserialize<AliexpressItem>(content);
        }
    }
}
