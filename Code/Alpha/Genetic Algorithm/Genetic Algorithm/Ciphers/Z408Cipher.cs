using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class Z408Cipher : ICipher
    {

        private List<Array> cipher;
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public List<Array> Cipher
        {
            get
            {
                return cipher;
            }
            set
            {
                cipher = value;
            }
        }

        public Z408Cipher()
        {
            Length = 408;
            Cipher = new List<Array>();
            Cipher.Add(new int[] { 1, 26, 55, 91, 152, 189, 208, 228, 244, 280, 303, 305, 335, 346, 396 });
            Cipher.Add(new int[] { 2, 9, 63, 212, 269, 270, 281, 282, 307, 336, 372 });
            Cipher.Add(new int[] { 3, 28, 58, 123, 155, 205, 238, 255, 286, 366, 388 });
            Cipher.Add(new int[] { 4, 6, 54, 122, 199, 279 });
            Cipher.Add(new int[] { 5, 73, 138, 171, 236, 283, 325, 375 });
            Cipher.Add(new int[] { 7, 39, 62, 132, 167, 210, 240, 262, 312, 406 });
            Cipher.Add(new int[] { 8, 17, 57, 114, 119, 125, 154, 246, 288, 306, 387 });
            Cipher.Add(new int[] { 10, 41, 69, 136, 169, 226, 242, 274, 408 });
            Cipher.Add(new int[] { 11, 59, 110, 174, 254, 308, 367 });
            Cipher.Add(new int[] { 12, 60, 65, 103, 134, 135, 157, 185, 191, 209, 311, 368 });
            Cipher.Add(new int[] { 13, 16, 160, 220, 257, 356, 405 });
            Cipher.Add(new int[] { 14, 78, 141, 173, 241, 290 });
            Cipher.Add(new int[] { 15, 97, 127, 201, 292, 345, 348, 369, 394 });
            Cipher.Add(new int[] { 18, 82, 144, 176, 248, 294, 323, 390, 397 });
            Cipher.Add(new int[] { 19, 81, 175, 216, 247, 251, 289, 324, 392 });
            Cipher.Add(new int[] { 20, 87, 158, 179, 250, 301, 314, 385 });
            Cipher.Add(new int[] { 21, 34, 83, 165, 198, 263, 291, 326, 344, 359, 364 });
            Cipher.Add(new int[] { 22, 89, 113, 221, 268, 327, 373 });
            Cipher.Add(new int[] { 23, 33, 37, 48, 85, 107, 194, 317, 328, 333, 352 });
            Cipher.Add(new int[] { 24, 79, 170, 297, 343, 371 });
            Cipher.Add(new int[] { 25, 95, 161, 186, 264, 363, 391, 399 });
            Cipher.Add(new int[] { 27, 80, 130, 168, 187, 219, 341, 402 });
            Cipher.Add(new int[] { 29, 86, 126, 200, 302, 376 });
            Cipher.Add(new int[] { 30, 92, 139, 218, 329 });
            Cipher.Add(new int[] { 31, 106, 146, 224, 342, 355 });
            Cipher.Add(new int[] { 32, 43, 67, 88, 96, 112, 128, 140, 145, 293, 295, 318, 322, 357, 380, 400 });
            Cipher.Add(new int[] { 35, 72, 131, 150, 207, 231, 272, 403 });
            Cipher.Add(new int[] { 36, 74, 202, 225, 377, 383 });
            Cipher.Add(new int[] { 38, 70, 133, 184, 256, 320 });
            Cipher.Add(new int[] { 40, 93, 142, 177, 188, 223, 271, 384, 398, 407 });
            Cipher.Add(new int[] { 42, 84, 98, 111, 147, 229, 299, 382 });
            Cipher.Add(new int[] { 44, 115, 193, 252, 309, 332, 378 });
            Cipher.Add(new int[] { 45, 105, 180, 183, 211, 253, 339, 379 });
            Cipher.Add(new int[] { 46, 104, 163, 215, 233, 273 });
            Cipher.Add(new int[] { 47, 116, 203, 370, 389 });
            Cipher.Add(new int[] { 49, 90, 156, 190, 266, 350 });
            Cipher.Add(new int[] { 50, 99, 148, 178, 206, 227, 310, 365 });
            Cipher.Add(new int[] { 51, 94, 143, 182, 214, 235, 275, 404 });
            Cipher.Add(new int[] { 52, 101, 117, 258, 276, 321});
            Cipher.Add(new int[] { 53, 102, 164, 237 });
            Cipher.Add(new int[] { 56, 118, 124, 153, 245, 287, 298, 337, 361, 362 });
            Cipher.Add(new int[] { 61, 204, 234, 243, 285, 304, 334, 349 });
            Cipher.Add(new int[] { 64, 261, 284 });
            Cipher.Add(new int[] { 66, 109, 232, 260 });
            Cipher.Add(new int[] { 68, 108, 129, 166, 217, 278, 330, 393, 401 });
            Cipher.Add(new int[] { 71, 120, 149, 181, 213, 230, 338, 354 });
            Cipher.Add(new int[] { 75, 121, 197, 316, 351, 360 });
            Cipher.Add(new int[] { 76, 151, 195, 222, 259, 386, 395 });
            Cipher.Add(new int[] { 77, 162, 196, 249 });
            Cipher.Add(new int[] { 100, 239, 267, 347 });
            Cipher.Add(new int[] { 137, 172, 277, 300, 313, 374 });
            Cipher.Add(new int[] { 159 });
            Cipher.Add(new int[] { 192, 296, 315, 319, 331, 340, 358, 381 });
            Cipher.Add(new int[] { 265, 353 });
        }
    }
}
