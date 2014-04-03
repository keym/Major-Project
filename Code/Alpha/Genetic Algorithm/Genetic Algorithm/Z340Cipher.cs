using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class Z340Cipher : ICipher
    {
        private List<Array> cipher = new List<Array>();

        public List<Array> Cipher
        {
            get { return cipher; }
            set { cipher = value; }
        }

        public Z340Cipher()
        {
            Cipher.Add(new int[] { 1, 50, 301, 327 });
            Cipher.Add(new int[] { 2, 177, 248 });
            Cipher.Add(new int[] { 3, 66, 88, 144, 173, 192, 221, 273 });
            Cipher.Add(new int[] { 4, 99, 249, 324 });
            Cipher.Add(new int[] { 5, 19, 53, 54, 62, 86, 164, 182, 265, 306, 329 });
            Cipher.Add(new int[] { 6, 57, 91, 156, 191, 222, 284 });
            Cipher.Add(new int[] { 7, 56, 89, 160, 226, 266 });
            Cipher.Add(new int[] { 8, 60, 115, 158, 234, 250 });
            Cipher.Add(new int[] { 9, 80, 298 });
            Cipher.Add(new int[] { 10, 84, 97, 309, 330 });
            Cipher.Add(new int[] { 11, 77, 119, 178, 194, 213, 156, 287, 307, 337 });
            Cipher.Add(new int[] { 12, 242, 278 });
            Cipher.Add(new int[] { 13, 47, 118, 135, 277, 289 });
            Cipher.Add(new int[] { 14, 184, 197, 275, 302 });
            Cipher.Add(new int[] { 15, 43, 114, 121, 223, 271 });
            Cipher.Add(new int[] { 16, 68, 100, 110, 122, 145, 188, 229, 272 });
            Cipher.Add(new int[] { 17, 76, 95, 137, 310 });
            Cipher.Add(new int[] { 18, 120, 212, 225, 328 });
            Cipher.Add(new int[] { 20, 40, 64, 65, 72, 81, 105, 128, 133, 140, 142, 159, 162, 172, 201, 211, 237, 238, 255, 276, 282, 290, 291, 320 });
            Cipher.Add(new int[] { 21, 35, 137, 168, 181, 203, 216, 140, 261, 286, 315, 319 });
            Cipher.Add(new int[] { 22, 45, 102, 120, 218, 263, 340 });
            Cipher.Add(new int[] { 23, 48, 103, 126, 210 });
            Cipher.Add(new int[] { 24, 63, 92, 127, 163, 187, 264, 299, 318, 334 });
            Cipher.Add(new int[] { 25, 108 });
            Cipher.Add(new int[] { 26, 101, 179, 326 });
            Cipher.Add(new int[] { 27, 44, 285, 293, 296, 311 });
            Cipher.Add(new int[] { 28, 131, 180, 317 });
            Cipher.Add(new int[] { 29, 116, 200, 232, 258, 267 });
            Cipher.Add(new int[] { 30, 138, 166, 189, 281, 312 });
            Cipher.Add(new int[] { 31, 59, 94, 195, 243, 320 });
            Cipher.Add(new int[] { 32, 67, 106, 153, 186, 262, 338 });
            Cipher.Add(new int[] { 33, 124, 227, 268 });
            Cipher.Add(new int[] { 34, 46, 288, 292, 305 });
            Cipher.Add(new int[] { 36, 149, 169, 209, 239 });
            Cipher.Add(new int[] { 37, 244 });
            Cipher.Add(new int[] { 38, 112, 148, 190, 217, 233, 257, 274, 297, 323 });
            Cipher.Add(new int[] { 39, 71, 139, 185, 199, 269, 325 });
            Cipher.Add(new int[] { 41, 111, 157, 171, 251 });
            Cipher.Add(new int[] { 42, 143, 252, 333 });
            Cipher.Add(new int[] { 49, 73, 117, 132, 155, 205, 260, 295, 332 });
            Cipher.Add(new int[] { 51, 123, 161, 193, 300 });
            Cipher.Add(new int[] { 52, 208, 331 });
            Cipher.Add(new int[] { 55, 165, 313 });
            Cipher.Add(new int[] { 58, 87, 220, 335 });
            Cipher.Add(new int[] { 61, 259 });
            Cipher.Add(new int[] { 69, 129, 316 });
            Cipher.Add(new int[] { 70, 136, 207, 246 });
            Cipher.Add(new int[] { 74, 176, 236, 314 });
            Cipher.Add(new int[] { 75, 125 });
            Cipher.Add(new int[] { 78, 104, 175, 196, 214, 228, 253 });
            Cipher.Add(new int[] { 79, 90, 98, 146, 167, 204, 215, 224, 283, 308 });
            Cipher.Add(new int[] { 82, 202 });
            Cipher.Add(new int[] { 83, 152, 198, 230, 235, 245 });
            Cipher.Add(new int[] { 85, 174, 303 });
            Cipher.Add(new int[] { 93, 154, 170, 254, 321 });
            Cipher.Add(new int[] { 96, 247, 280, 294, 322 });
            Cipher.Add(new int[] { 107, 270 });
            Cipher.Add(new int[] { 109, 219, 339 });
            Cipher.Add(new int[] { 113, 241 });
            Cipher.Add(new int[] { 134 });
            Cipher.Add(new int[] { 141, 183, 231 });
            Cipher.Add(new int[] { 150, 336 });
            Cipher.Add(new int[] { 151, 206, 279 });

        }
    }
}
