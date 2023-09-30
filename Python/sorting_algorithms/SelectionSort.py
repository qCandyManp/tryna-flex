def SelectionSort(list):
    for i in range(0, len(list)):
        sel = list[i]
        selId = i
        for j in range(i, len(list)):
            if list[j] < sel:
                sel = list[j]
                selId = j
        list[i], list[selId] = list[selId], list[i]

    return list