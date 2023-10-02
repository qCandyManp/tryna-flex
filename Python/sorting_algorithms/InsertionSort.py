def InsertionSort(list):
    for i in range(0, len(list)-1):
        if list[i] > list[i+1]:
            list[i], list[i+1] = list[i+1], list[i]
            j = i
            while j > 0:
                if list[j] < list[j-1]:
                    list[j], list[j-1] = list[j-1], list[j]
                else:
                    break
                j -= 1
    return list