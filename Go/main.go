package main

import (
	"fmt"
	"tryna-flex/main/sorting_algorithms"
)

func main() {
	list := []int{1, 3, 6, 8, 36, 568, 2345, 568, 234, 4576, 34, 4567, 476, 4, 8, 645, 7, 8, 786786, 12, 2536778, 2, 9, 12, 11, 453743, 753, 753, 73, 75345}
	fmt.Println(sorting_algorithms.InsertionSort(list))
}
