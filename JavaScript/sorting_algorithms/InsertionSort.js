export default function (list) {
    for (let i = 0; i < list.length - 1; i++) {
        if (list[i] > list[i + 1]) {
            let currVal = list[i]
            list[i] = list[i + 1]
            list[i + 1] = currVal
            for (let j = i; j > 0; j--) {
                if (list[j] < list[j - 1]) {
                    let currVal = list[j]
                    list[j] = list[j - 1]
                    list[j - 1] = currVal
                }
            }
        }
    }
    return list
}