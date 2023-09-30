<?php

function SelectionSort(array $list): array
{
    for ($i = 0; $i < count($list); $i++) {
        $sel = $list[$i];
        $selId = $i;
        for ($j = $i; $j < count($list); $j++) {
            if ($sel > $list[$j]) {
                $sel = $list[$j];
                $selId = $j;
            }
        }
        $list[$selId] = $list[$i];
        $list[$i] = $sel;
    }
    return $list;
}
