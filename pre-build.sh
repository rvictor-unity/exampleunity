#!/bin/bash

echo "============ build.json ================"
cat $WORKSPACE/build.json
echo "some change" >> README.md
echo "========= end of build.json ============"
