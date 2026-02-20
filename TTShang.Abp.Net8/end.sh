#!/bin/bash
kill -9 $(lsof -t -i:19001)
echo "TTShang-进程已关闭"
