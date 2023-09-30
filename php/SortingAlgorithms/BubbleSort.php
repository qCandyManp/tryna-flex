<?php

function BubbleSort(array $list): array
{
    for ($i = 0; $i < count($list); $i++) {
        for ($j = 0; $j < count($list) - $i - 1; $j++) {
            if ($list[$j] > $list[$j + 1]) {
                $currVal = $list[$j];
                $list[$j] = $list[$j + 1];
                $list[$j + 1] = $currVal;
            }
        }
    }
    return $list;
}
