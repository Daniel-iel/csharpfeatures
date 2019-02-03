using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace csharp6Features.AwaitInCatchAndFinallyBlocks
{
    public class FileHelper
    {
        public async Task WriteAsync(string path, string text)
        {
            byte[] encodedText = Encoding.Unicode.GetBytes(text);

            try
            {
                using (var sourceStream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true))
                {
                    await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
                };
            }
            catch (System.Exception ex)
            {
                await LogAsync(ex.ToString());
            }
            finally
            {
                await LogAsync($"end method {nameof(FileHelper.WriteAsync)}");
            }
        }

        private async Task LogAsync(string text)
        {

        }
    }
}
