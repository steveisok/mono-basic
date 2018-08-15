#!/bin/bash
filename='Microsoft.VisualBasic.dll.sources'
echo Start
num_files=0

if [ -f files.out ]; then
    rm files.out
fi

for f in $(find ./Microsoft.VisualBasic -name '*.vb')
do
    echo $f
done > $filename