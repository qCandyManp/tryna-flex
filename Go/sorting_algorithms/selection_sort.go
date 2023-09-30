package sorting_algorithms

func SelectionSort(list []int) []int {
	for i := 0; i < len(list); i++ {
		sel := list[i]
		selId := i
		for j := i; j < len(list); j++ {
			if list[j] < sel {
				sel = list[j]
				selId = j
			}
		}
		list[i], list[selId] = list[selId], list[i]
	}
	return list
}
