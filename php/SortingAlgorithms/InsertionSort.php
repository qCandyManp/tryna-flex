<?php

function InsertionSort(array $list): array
{
    for ($i = 0; $i < count($list)-1; $i++) {
        if ($list[$i] > $list[$i+1]) {
            $curVal = $list[$i];
            $list[$i] = $list[$i+1];
            $list[$i+1] = $curVal;

            for ($j = $i; $j > 0; $j--) {
                if ($list[$j] < $list[$j-1]) {
                    $curVal = $list[$j];
                    $list[$j] = $list[$j-1];
                    $list[$j-1] = $curVal;
                }
            }
        }
    }
    return $list;
}
