﻿using SortingAlgorithms;

int[] list = { 1, 3, 6, 8, 36, 568, 2345, 568, 234, 4576, 34, 4567, 476, 4, 8, 645, 7, 8, 786786, 12, 2536778, 2, 9, 12, 11, 453743, 753, 753, 73, 75345 };

Console.WriteLine("[{0}]", string.Join(", ", InsertionSort.sort(list)));