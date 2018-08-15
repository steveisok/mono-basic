#!/bin/bash
filename='System.Web.dll.sources'
echo Start
num_files=0

if [ -f files.out ]; then
    rm files.out
fi

for f in $(find ../referencesource/System.Web/ -name '*.cs')
do
    echo $f
done > $filename