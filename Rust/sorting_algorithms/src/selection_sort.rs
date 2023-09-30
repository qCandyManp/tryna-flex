pub fn sort(list: &mut [i32]) {
    for i in 0..list.len() {
        let mut sel: i32 = list[i];
        let mut sel_id = i;
        for j in i..list.len() {
            if list[j] < sel {
                sel = list[j];
                sel_id = j
            }
        }
        list.swap(i, sel_id);
    }
}
