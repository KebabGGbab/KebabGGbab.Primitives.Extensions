using System.Globalization;
using System.Text;
using KebabGGbab.Primitives.Extensions;
using KebabGGbab.Primitives.Extensions.Resources;

namespace KebabGGbab.Primitives.Extensions
{
    public static class PathExtensions
    {
        private static readonly CompositeFormat _invalidReplacementSymbol = CompositeFormat.Parse(S_PathExtensions.InvalidReplacementSymbol);

        extension(Path)
        {
            /// <summary>
            /// Заменяет в строке все символы, являющиеся невалидными для имени файла, на определенный символ.
            /// </summary>
            /// <param name="fileName">Строка, в которой могут находиться символы, запрещенные для использования в имени файла.</param>
            /// <param name="correctSymbol">Символ, на который будут заменены все невалидные символы.</param>
            /// <returns>Строка, в который все невалидные символы были заменены на валидный.</returns>
            /// <exception cref="InvalidOperationException"></exception>
            public static string CorrectFileName(string fileName, char correctSymbol = '_')
            {
                ArgumentNullException.ThrowIfNull(fileName, nameof(fileName));

                char[] invalidChars = Path.GetInvalidFileNameChars();

                if (invalidChars.Contains(correctSymbol))
                {
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, _invalidReplacementSymbol, correctSymbol));
                }

                return fileName.Replace(invalidChars, correctSymbol);
            }
        }
    }
}
