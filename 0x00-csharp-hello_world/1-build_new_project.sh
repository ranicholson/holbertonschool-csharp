#!/usr/bin/env bash
# Script to initialize and build a new c# project in specified directory

dotnet new console -o 1-new_project
dotnet build 1-new_project
