export default function (list) {
    for (let i = 0; i < list.length; i++) {
        let sel = list[i]
        let selId = i
        for (let j = i; j < list.length; j++) {
            if (list[j] < sel) {
                sel = list[j]
                selId = j
            }
        }
        list[selId] = list[i]
        list[i] = sel
    }
    return list
}