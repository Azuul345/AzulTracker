using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AzulTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedMuscleAssignments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExerciseMuscles",
                columns: new[] { "Id", "ExerciseLibraryId", "IsPrimary", "MuscleId" },
                values: new object[,]
                {
                    { 1, 1, true, 1 },
                    { 2, 1, true, 2 },
                    { 3, 1, true, 8 },
                    { 4, 1, false, 14 },
                    { 5, 1, false, 19 },
                    { 6, 2, true, 1 },
                    { 7, 2, false, 2 },
                    { 8, 2, true, 8 },
                    { 9, 2, false, 14 },
                    { 10, 2, false, 19 },
                    { 11, 3, true, 1 },
                    { 12, 3, true, 2 },
                    { 13, 3, false, 8 },
                    { 14, 3, false, 14 },
                    { 15, 4, true, 1 },
                    { 16, 4, true, 2 },
                    { 17, 4, true, 8 },
                    { 18, 4, false, 14 },
                    { 19, 4, false, 19 },
                    { 20, 5, true, 1 },
                    { 21, 5, false, 2 },
                    { 22, 5, true, 8 },
                    { 23, 5, false, 14 },
                    { 24, 5, false, 19 },
                    { 25, 6, true, 1 },
                    { 26, 6, true, 2 },
                    { 27, 6, false, 8 },
                    { 28, 6, false, 14 },
                    { 29, 7, true, 1 },
                    { 30, 7, true, 2 },
                    { 31, 7, false, 8 },
                    { 32, 7, false, 19 },
                    { 33, 8, true, 1 },
                    { 34, 8, false, 2 },
                    { 35, 8, true, 8 },
                    { 36, 8, false, 19 },
                    { 37, 9, true, 1 },
                    { 38, 9, true, 2 },
                    { 39, 9, false, 8 },
                    { 40, 9, false, 19 },
                    { 41, 10, true, 1 },
                    { 42, 10, true, 8 },
                    { 43, 10, false, 2 },
                    { 44, 11, true, 1 },
                    { 45, 11, true, 2 },
                    { 46, 11, false, 8 },
                    { 47, 12, true, 1 },
                    { 48, 12, true, 2 },
                    { 49, 12, true, 8 },
                    { 50, 12, false, 14 },
                    { 51, 12, false, 19 },
                    { 52, 13, true, 1 },
                    { 53, 13, true, 2 },
                    { 54, 13, false, 8 },
                    { 55, 13, false, 19 },
                    { 56, 14, true, 1 },
                    { 57, 14, true, 2 },
                    { 58, 14, true, 14 },
                    { 59, 14, false, 8 },
                    { 60, 15, true, 1 },
                    { 61, 15, true, 2 },
                    { 62, 15, false, 8 },
                    { 63, 16, true, 1 },
                    { 64, 16, true, 2 },
                    { 65, 16, false, 8 },
                    { 66, 17, true, 1 },
                    { 67, 17, true, 2 },
                    { 68, 17, true, 14 },
                    { 69, 17, false, 8 },
                    { 70, 18, true, 1 },
                    { 71, 18, true, 2 },
                    { 72, 18, true, 8 },
                    { 73, 18, false, 14 },
                    { 74, 19, true, 3 },
                    { 75, 19, true, 6 },
                    { 76, 19, false, 12 },
                    { 77, 19, false, 13 },
                    { 78, 19, false, 10 },
                    { 79, 20, true, 3 },
                    { 80, 20, true, 6 },
                    { 81, 20, true, 12 },
                    { 82, 20, false, 13 },
                    { 83, 21, true, 3 },
                    { 84, 21, false, 6 },
                    { 85, 21, false, 10 },
                    { 86, 21, false, 12 },
                    { 87, 22, true, 3 },
                    { 88, 22, true, 4 },
                    { 89, 22, false, 5 },
                    { 90, 22, true, 6 },
                    { 91, 22, false, 9 },
                    { 92, 22, false, 12 },
                    { 93, 23, true, 3 },
                    { 94, 23, true, 4 },
                    { 95, 23, false, 5 },
                    { 96, 23, true, 6 },
                    { 97, 23, true, 9 },
                    { 98, 23, false, 12 },
                    { 99, 24, true, 3 },
                    { 100, 24, true, 4 },
                    { 101, 24, true, 6 },
                    { 102, 24, false, 5 },
                    { 103, 24, false, 12 },
                    { 104, 25, true, 3 },
                    { 105, 25, true, 4 },
                    { 106, 25, true, 6 },
                    { 107, 25, false, 5 },
                    { 108, 25, false, 12 },
                    { 109, 26, true, 3 },
                    { 110, 26, true, 6 },
                    { 111, 26, false, 12 },
                    { 112, 26, false, 13 },
                    { 113, 26, false, 10 },
                    { 114, 27, true, 3 },
                    { 115, 27, true, 6 },
                    { 116, 27, true, 12 },
                    { 117, 27, false, 13 },
                    { 118, 28, true, 3 },
                    { 119, 28, false, 6 },
                    { 120, 28, false, 19 },
                    { 121, 29, true, 9 },
                    { 122, 29, true, 4 },
                    { 123, 29, false, 11 },
                    { 124, 29, false, 10 },
                    { 125, 30, true, 5 },
                    { 126, 30, true, 24 },
                    { 127, 30, true, 21 },
                    { 128, 30, false, 24 },
                    { 129, 30, true, 9 },
                    { 130, 30, false, 10 },
                    { 131, 30, false, 3 },
                    { 132, 31, true, 5 },
                    { 133, 31, true, 9 },
                    { 134, 31, false, 10 },
                    { 135, 31, false, 3 },
                    { 136, 31, false, 24 },
                    { 137, 32, true, 3 },
                    { 138, 32, true, 4 },
                    { 139, 32, true, 6 },
                    { 140, 32, false, 5 },
                    { 141, 32, false, 12 },
                    { 142, 33, true, 3 },
                    { 143, 33, true, 6 },
                    { 144, 33, false, 4 },
                    { 145, 33, false, 12 },
                    { 146, 34, true, 4 },
                    { 147, 34, true, 3 },
                    { 148, 34, true, 6 },
                    { 149, 34, false, 9 },
                    { 150, 34, false, 12 },
                    { 151, 35, true, 4 },
                    { 152, 35, true, 3 },
                    { 153, 35, true, 6 },
                    { 154, 35, false, 12 },
                    { 155, 36, true, 4 },
                    { 156, 36, true, 3 },
                    { 157, 36, false, 6 },
                    { 158, 36, false, 12 },
                    { 159, 36, false, 19 },
                    { 160, 37, true, 3 },
                    { 161, 37, true, 4 },
                    { 162, 37, true, 6 },
                    { 163, 37, false, 12 },
                    { 164, 38, true, 3 },
                    { 165, 38, false, 6 },
                    { 166, 38, false, 19 },
                    { 167, 39, true, 9 },
                    { 168, 39, true, 4 },
                    { 169, 39, false, 11 },
                    { 170, 40, true, 3 },
                    { 171, 40, false, 1 },
                    { 172, 40, false, 19 },
                    { 173, 40, false, 14 },
                    { 174, 41, true, 4 },
                    { 175, 41, true, 9 },
                    { 176, 41, false, 3 },
                    { 177, 41, false, 6 },
                    { 178, 41, false, 12 },
                    { 179, 42, true, 8 },
                    { 180, 42, true, 7 },
                    { 181, 42, false, 14 },
                    { 182, 42, false, 10 },
                    { 183, 42, false, 11 },
                    { 184, 43, true, 8 },
                    { 185, 43, true, 7 },
                    { 186, 43, false, 14 },
                    { 187, 43, false, 11 },
                    { 188, 44, true, 8 },
                    { 189, 44, true, 7 },
                    { 190, 44, false, 9 },
                    { 191, 44, false, 14 },
                    { 192, 44, false, 11 },
                    { 193, 45, true, 7 },
                    { 194, 45, false, 8 },
                    { 195, 45, false, 10 },
                    { 196, 46, true, 7 },
                    { 197, 46, false, 8 },
                    { 198, 46, false, 10 },
                    { 199, 47, true, 8 },
                    { 200, 47, false, 1 },
                    { 201, 47, false, 7 },
                    { 202, 48, true, 9 },
                    { 203, 48, true, 4 },
                    { 204, 48, false, 10 },
                    { 205, 49, true, 9 },
                    { 206, 49, true, 4 },
                    { 207, 49, false, 10 },
                    { 208, 50, true, 7 },
                    { 209, 50, true, 8 },
                    { 210, 50, true, 10 },
                    { 211, 50, false, 12 },
                    { 212, 51, true, 10 },
                    { 213, 51, false, 5 },
                    { 214, 52, true, 8 },
                    { 215, 52, false, 1 },
                    { 216, 52, false, 7 },
                    { 217, 52, false, 14 },
                    { 218, 53, true, 8 },
                    { 219, 53, true, 7 },
                    { 220, 53, false, 14 },
                    { 221, 53, false, 24 },
                    { 222, 53, false, 20 },
                    { 223, 54, true, 7 },
                    { 224, 54, true, 8 },
                    { 225, 54, false, 9 },
                    { 226, 54, false, 14 },
                    { 227, 55, true, 8 },
                    { 228, 55, false, 1 },
                    { 229, 55, false, 7 },
                    { 230, 56, true, 8 },
                    { 231, 56, true, 7 },
                    { 232, 56, false, 14 },
                    { 233, 57, true, 10 },
                    { 234, 57, false, 5 },
                    { 235, 58, true, 8 },
                    { 236, 58, false, 1 },
                    { 237, 58, false, 7 },
                    { 238, 59, true, 9 },
                    { 239, 59, true, 4 },
                    { 240, 59, false, 10 },
                    { 241, 59, false, 11 },
                    { 242, 60, true, 12 },
                    { 243, 60, true, 13 },
                    { 244, 60, false, 15 },
                    { 245, 61, true, 12 },
                    { 246, 61, true, 13 },
                    { 247, 61, false, 15 },
                    { 248, 62, true, 12 },
                    { 249, 62, false, 13 },
                    { 250, 62, false, 15 },
                    { 251, 63, true, 13 },
                    { 252, 63, false, 12 },
                    { 253, 63, true, 15 },
                    { 254, 64, true, 12 },
                    { 255, 64, true, 13 },
                    { 256, 64, false, 15 },
                    { 257, 65, true, 12 },
                    { 258, 65, true, 13 },
                    { 259, 65, false, 15 },
                    { 260, 66, true, 12 },
                    { 261, 66, false, 13 },
                    { 262, 67, true, 12 },
                    { 263, 67, false, 13 },
                    { 264, 68, true, 15 },
                    { 265, 68, false, 12 },
                    { 266, 68, false, 14 },
                    { 267, 69, true, 12 },
                    { 268, 69, true, 13 },
                    { 269, 69, true, 15 },
                    { 270, 70, true, 13 },
                    { 271, 70, false, 12 },
                    { 272, 70, true, 15 },
                    { 273, 71, true, 12 },
                    { 274, 71, false, 13 },
                    { 275, 72, true, 14 },
                    { 276, 72, false, 1 },
                    { 277, 72, false, 8 },
                    { 278, 73, true, 14 },
                    { 279, 74, true, 14 },
                    { 280, 75, true, 14 },
                    { 281, 76, true, 14 },
                    { 282, 77, true, 14 },
                    { 283, 77, false, 1 },
                    { 284, 77, false, 8 },
                    { 285, 78, true, 14 },
                    { 286, 79, true, 14 },
                    { 287, 80, true, 14 },
                    { 288, 80, false, 1 },
                    { 289, 81, true, 14 },
                    { 290, 81, false, 1 },
                    { 291, 82, true, 15 },
                    { 292, 83, true, 15 },
                    { 293, 84, true, 15 },
                    { 294, 85, true, 13 },
                    { 295, 85, false, 12 },
                    { 296, 85, true, 15 },
                    { 297, 86, true, 14 },
                    { 298, 87, true, 14 },
                    { 299, 88, true, 14 },
                    { 300, 88, false, 15 },
                    { 301, 89, true, 20 },
                    { 302, 89, true, 24 },
                    { 303, 89, false, 21 },
                    { 304, 89, false, 22 },
                    { 305, 89, false, 5 },
                    { 306, 90, true, 20 },
                    { 307, 90, false, 24 },
                    { 308, 90, false, 22 },
                    { 309, 90, false, 5 },
                    { 310, 91, true, 20 },
                    { 311, 91, false, 24 },
                    { 312, 91, false, 22 },
                    { 313, 92, true, 20 },
                    { 314, 92, false, 24 },
                    { 315, 92, false, 21 },
                    { 316, 92, false, 22 },
                    { 317, 93, true, 20 },
                    { 318, 93, true, 24 },
                    { 319, 93, false, 21 },
                    { 320, 93, false, 22 },
                    { 321, 94, true, 20 },
                    { 322, 94, true, 24 },
                    { 323, 94, false, 21 },
                    { 324, 94, false, 22 },
                    { 325, 95, true, 20 },
                    { 326, 95, true, 24 },
                    { 327, 95, false, 21 },
                    { 328, 95, false, 22 },
                    { 329, 95, false, 26 },
                    { 330, 96, true, 21 },
                    { 331, 96, true, 24 },
                    { 332, 96, false, 5 },
                    { 333, 97, true, 21 },
                    { 334, 97, false, 24 },
                    { 335, 97, false, 5 },
                    { 336, 98, true, 21 },
                    { 337, 99, true, 21 },
                    { 338, 99, false, 24 },
                    { 339, 100, true, 21 },
                    { 340, 100, false, 24 },
                    { 341, 101, true, 20 },
                    { 342, 102, true, 20 },
                    { 343, 102, true, 24 },
                    { 344, 102, false, 21 },
                    { 345, 103, true, 20 },
                    { 346, 103, false, 24 },
                    { 347, 103, false, 22 },
                    { 348, 104, true, 20 },
                    { 349, 105, true, 22 },
                    { 350, 106, true, 20 },
                    { 351, 106, true, 24 },
                    { 352, 106, false, 21 },
                    { 353, 106, false, 22 },
                    { 354, 107, true, 22 },
                    { 355, 107, true, 20 },
                    { 356, 107, false, 24 },
                    { 357, 108, true, 20 },
                    { 358, 108, true, 24 },
                    { 359, 108, false, 21 },
                    { 360, 108, false, 22 },
                    { 361, 109, true, 20 },
                    { 362, 109, true, 24 },
                    { 363, 109, false, 21 },
                    { 364, 110, true, 20 },
                    { 365, 110, true, 24 },
                    { 366, 110, false, 21 },
                    { 367, 110, false, 5 },
                    { 368, 111, true, 20 },
                    { 369, 111, false, 24 },
                    { 370, 111, false, 21 },
                    { 371, 112, true, 21 },
                    { 372, 113, true, 21 },
                    { 373, 114, true, 21 },
                    { 374, 114, true, 24 },
                    { 375, 115, true, 24 },
                    { 376, 115, false, 21 },
                    { 377, 115, false, 5 },
                    { 378, 116, true, 20 },
                    { 379, 116, true, 24 },
                    { 380, 116, false, 22 },
                    { 381, 116, false, 5 },
                    { 382, 117, true, 20 },
                    { 383, 117, false, 22 },
                    { 384, 118, true, 21 },
                    { 385, 118, true, 24 },
                    { 386, 118, false, 5 },
                    { 387, 119, true, 21 },
                    { 388, 119, true, 24 },
                    { 389, 119, false, 25 },
                    { 390, 120, true, 20 },
                    { 391, 120, false, 24 },
                    { 392, 120, false, 22 },
                    { 393, 121, true, 20 },
                    { 394, 121, false, 24 },
                    { 395, 122, true, 20 },
                    { 396, 122, true, 24 },
                    { 397, 122, false, 21 },
                    { 398, 123, true, 20 },
                    { 399, 123, false, 22 },
                    { 400, 124, true, 20 },
                    { 401, 124, false, 24 },
                    { 402, 124, false, 21 },
                    { 403, 125, true, 20 },
                    { 404, 125, false, 24 },
                    { 405, 126, true, 20 },
                    { 406, 126, true, 24 },
                    { 407, 126, true, 22 },
                    { 408, 127, true, 20 },
                    { 409, 127, false, 24 },
                    { 410, 128, true, 24 },
                    { 411, 128, true, 21 },
                    { 412, 128, false, 5 },
                    { 413, 129, true, 20 },
                    { 414, 129, true, 24 },
                    { 415, 129, false, 21 },
                    { 416, 130, true, 21 },
                    { 417, 130, true, 24 },
                    { 418, 130, false, 5 },
                    { 419, 131, true, 24 },
                    { 420, 131, false, 25 },
                    { 421, 131, false, 21 },
                    { 422, 132, true, 24 },
                    { 423, 132, false, 25 },
                    { 424, 132, false, 21 },
                    { 425, 133, true, 24 },
                    { 426, 133, false, 25 },
                    { 427, 134, true, 24 },
                    { 428, 134, true, 22 },
                    { 429, 134, false, 21 },
                    { 430, 134, false, 5 },
                    { 431, 134, false, 3 },
                    { 432, 135, true, 24 },
                    { 433, 135, true, 22 },
                    { 434, 135, false, 20 },
                    { 435, 136, true, 23 },
                    { 436, 136, false, 25 },
                    { 437, 137, true, 24 },
                    { 438, 137, false, 25 },
                    { 439, 138, true, 24 },
                    { 440, 138, false, 25 },
                    { 441, 138, false, 21 },
                    { 442, 139, true, 24 },
                    { 443, 139, false, 25 },
                    { 444, 140, true, 24 },
                    { 445, 140, false, 25 },
                    { 446, 140, false, 21 },
                    { 447, 141, true, 24 },
                    { 448, 141, false, 21 },
                    { 449, 141, false, 5 },
                    { 450, 142, true, 24 },
                    { 451, 142, false, 25 },
                    { 452, 143, true, 24 },
                    { 453, 143, false, 25 },
                    { 454, 144, true, 25 },
                    { 455, 144, true, 23 },
                    { 456, 145, true, 24 },
                    { 457, 145, false, 25 },
                    { 458, 146, true, 24 },
                    { 459, 146, false, 25 },
                    { 460, 147, true, 24 },
                    { 461, 147, false, 25 },
                    { 462, 148, true, 24 },
                    { 463, 148, false, 21 },
                    { 464, 148, false, 5 },
                    { 465, 149, true, 26 },
                    { 466, 149, false, 27 },
                    { 467, 150, true, 27 },
                    { 468, 150, false, 26 },
                    { 469, 151, true, 26 },
                    { 470, 151, false, 27 },
                    { 471, 152, true, 26 },
                    { 472, 152, false, 27 },
                    { 473, 153, true, 26 },
                    { 474, 153, false, 27 },
                    { 475, 154, true, 26 },
                    { 476, 154, false, 27 },
                    { 477, 156, true, 26 },
                    { 478, 156, true, 27 },
                    { 479, 157, true, 16 },
                    { 480, 157, true, 18 },
                    { 481, 157, false, 17 },
                    { 482, 158, true, 17 },
                    { 483, 158, true, 18 },
                    { 484, 158, false, 16 },
                    { 485, 159, true, 16 },
                    { 486, 159, true, 18 },
                    { 487, 159, false, 3 },
                    { 488, 159, false, 8 },
                    { 489, 160, true, 16 },
                    { 490, 160, false, 17 },
                    { 491, 160, false, 18 },
                    { 492, 161, true, 16 },
                    { 493, 161, false, 17 },
                    { 494, 162, true, 16 },
                    { 495, 162, false, 17 },
                    { 496, 163, true, 16 },
                    { 497, 163, false, 17 },
                    { 498, 164, true, 17 },
                    { 499, 164, false, 16 },
                    { 500, 164, false, 18 },
                    { 501, 165, true, 18 },
                    { 502, 165, true, 17 },
                    { 503, 165, false, 16 },
                    { 504, 166, true, 16 },
                    { 505, 166, true, 18 },
                    { 506, 166, false, 17 },
                    { 507, 167, true, 16 },
                    { 508, 167, true, 18 },
                    { 509, 167, false, 17 },
                    { 510, 168, true, 16 },
                    { 511, 168, true, 18 },
                    { 512, 168, false, 3 },
                    { 513, 169, true, 16 },
                    { 514, 169, false, 17 },
                    { 515, 169, false, 18 },
                    { 516, 170, true, 16 },
                    { 517, 170, false, 17 },
                    { 518, 171, true, 17 },
                    { 519, 171, true, 16 },
                    { 520, 172, true, 17 },
                    { 521, 172, false, 16 },
                    { 522, 172, false, 18 },
                    { 523, 173, true, 17 },
                    { 524, 173, true, 18 },
                    { 525, 173, false, 16 },
                    { 526, 174, true, 17 },
                    { 527, 174, true, 18 },
                    { 528, 174, false, 10 },
                    { 529, 175, true, 16 },
                    { 530, 175, true, 18 },
                    { 531, 175, false, 17 },
                    { 532, 176, true, 22 },
                    { 533, 176, true, 17 },
                    { 534, 176, false, 18 },
                    { 535, 177, true, 10 },
                    { 536, 177, true, 15 },
                    { 537, 177, false, 18 },
                    { 538, 177, false, 5 },
                    { 539, 178, true, 20 },
                    { 540, 178, true, 24 },
                    { 541, 178, true, 8 },
                    { 542, 178, false, 10 },
                    { 543, 178, false, 5 },
                    { 544, 179, true, 24 },
                    { 545, 179, true, 21 },
                    { 546, 179, false, 5 },
                    { 547, 179, false, 16 },
                    { 548, 180, true, 20 },
                    { 549, 180, true, 8 },
                    { 550, 180, false, 14 },
                    { 551, 180, false, 24 },
                    { 552, 181, true, 20 },
                    { 553, 181, true, 24 },
                    { 554, 181, true, 10 },
                    { 555, 181, false, 8 },
                    { 556, 181, false, 5 },
                    { 557, 182, true, 20 },
                    { 558, 182, true, 24 },
                    { 559, 182, true, 8 },
                    { 560, 182, false, 10 },
                    { 561, 182, false, 5 },
                    { 562, 182, false, 3 },
                    { 563, 183, true, 8 },
                    { 564, 183, true, 16 },
                    { 565, 183, true, 18 },
                    { 566, 183, false, 24 },
                    { 567, 183, false, 17 },
                    { 568, 183, false, 20 },
                    { 569, 184, true, 20 },
                    { 570, 184, true, 24 },
                    { 571, 184, true, 21 },
                    { 572, 184, false, 5 },
                    { 573, 184, false, 3 },
                    { 574, 184, false, 10 },
                    { 575, 185, true, 10 },
                    { 576, 185, true, 20 },
                    { 577, 185, false, 24 },
                    { 578, 185, false, 8 },
                    { 579, 186, true, 8 },
                    { 580, 186, true, 14 },
                    { 581, 186, false, 20 },
                    { 582, 186, false, 24 },
                    { 583, 187, true, 8 },
                    { 584, 187, true, 14 },
                    { 585, 187, false, 20 },
                    { 586, 187, false, 24 },
                    { 587, 187, false, 22 },
                    { 588, 188, true, 10 },
                    { 589, 188, true, 18 },
                    { 590, 188, false, 5 },
                    { 591, 188, false, 16 },
                    { 592, 189, true, 20 },
                    { 593, 189, true, 24 },
                    { 594, 189, false, 8 },
                    { 595, 189, false, 16 },
                    { 596, 190, true, 20 },
                    { 597, 190, false, 3 },
                    { 598, 190, false, 12 },
                    { 599, 190, false, 21 },
                    { 600, 191, true, 8 },
                    { 601, 191, true, 7 },
                    { 602, 191, false, 16 },
                    { 603, 191, false, 18 },
                    { 604, 191, false, 1 },
                    { 605, 192, true, 20 },
                    { 606, 192, true, 24 },
                    { 607, 192, false, 26 },
                    { 608, 193, true, 20 },
                    { 609, 193, false, 1 },
                    { 610, 193, false, 14 },
                    { 611, 193, false, 16 },
                    { 612, 193, false, 24 },
                    { 613, 194, true, 10 },
                    { 614, 194, true, 20 },
                    { 615, 194, false, 24 },
                    { 616, 194, false, 8 },
                    { 617, 195, true, 10 },
                    { 618, 195, true, 20 },
                    { 619, 195, false, 24 },
                    { 620, 195, false, 8 },
                    { 621, 196, true, 20 },
                    { 622, 196, false, 1 },
                    { 623, 196, false, 8 },
                    { 624, 196, false, 14 },
                    { 625, 197, true, 20 },
                    { 626, 197, true, 8 },
                    { 627, 197, false, 14 },
                    { 628, 197, false, 24 },
                    { 629, 198, true, 1 },
                    { 630, 198, true, 2 },
                    { 631, 199, true, 1 },
                    { 632, 199, true, 14 },
                    { 633, 199, false, 8 },
                    { 634, 200, true, 1 },
                    { 635, 200, true, 2 },
                    { 636, 200, true, 8 },
                    { 637, 200, false, 14 },
                    { 638, 155, true, 28 },
                    { 639, 160, false, 29 },
                    { 640, 169, false, 29 },
                    { 641, 170, false, 29 },
                    { 642, 163, false, 29 },
                    { 643, 94, false, 29 },
                    { 644, 95, false, 29 },
                    { 645, 93, false, 29 },
                    { 646, 106, false, 29 },
                    { 647, 102, false, 29 },
                    { 648, 63, false, 30 },
                    { 649, 68, true, 30 },
                    { 650, 69, true, 30 },
                    { 651, 70, false, 30 },
                    { 652, 85, false, 30 },
                    { 653, 88, false, 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 653);
        }
    }
}
