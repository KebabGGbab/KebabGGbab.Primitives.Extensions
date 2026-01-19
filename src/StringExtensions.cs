using System.Text;

namespace KebabGGbab.Primitives.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Преобразовать объект типа <see cref="string"/> в объект типа <see cref="Stream"/>.
        /// </summary>
        /// <param name="str">Строка, которая будет преобразована.</param>
        /// <param name="encoding">Кодировка строки. По умолчанию UTF-8.</param>
        /// <returns>Объект типа <see cref="Stream"/>, содержащий переданную строку.</returns>
        public static Stream ToStream(this string str, Encoding? encoding = null)
        {
            ArgumentNullException.ThrowIfNull(str, nameof(str));

            return new MemoryStream((encoding ?? Encoding.UTF8).GetBytes(str));
        }

        /// <summary>
        /// Заменяет все вхождения символов, содержащихся в <see cref="IEnumerable{T}"/> на указанный символ. 
        /// </summary>
        /// <param name="str">Строка, в которой будут происходить замены.</param>
        /// <param name="oldChars">Перечисление символов, подлежащих замене.</param>
        /// <param name="newChar">Символ, на который будут заменены символы, подлежащие замене.</param>
        /// <returns>Строка, в которой все старые символы были заменены на новый.</returns>
        public static string Replace(this string str, IEnumerable<char> oldChars, char newChar)
        {
            ArgumentNullException.ThrowIfNull(str, nameof(str)) ;
            ArgumentNullException.ThrowIfNull(oldChars, nameof(oldChars));

            foreach (char c in oldChars)
            {
                str = str.Replace(c, newChar);
            }

            return str;
        }
    }
}
