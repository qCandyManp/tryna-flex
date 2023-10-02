pub fn sort(list: &mut [i32]) {
    for i in 0..list.len()-1 {
        if list[i] > list[i+1] {
            list.swap(i, i + 1);
            let mut j = i;
            loop {
                if list[j] < list[j - 1] {
                    list.swap(j, j - 1);
                    j -= 1;
                    continue;
                }

                break;
            }
        }
    }
}
