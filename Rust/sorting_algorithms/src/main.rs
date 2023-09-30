mod selection_sort;

fn main() {
    let mut list: [i32; 30] = [
        1, 3, 6, 8, 36, 568, 2345, 568, 234, 4576, 34, 4567, 476, 4, 8, 645, 7, 8, 786786, 12,
        2536778, 2, 9, 12, 11, 453743, 753, 753, 73, 75345,
    ];
    selection_sort::sort(&mut list);
    println!("{:?}", list);
}
