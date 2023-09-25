#!/bin/bash

msiexec /i https://awscli.amazonaws.com/AWSCLIV2.msi
export PATH=$PATH:"C:\Program Files\Amazon\AWSCLIV2"
# brew install awscli

aws --version
# python --version

# curl https://bootstrap.pypa.io/get-pip.py -o get-pip.py
# python get-pip.py

# pip --version