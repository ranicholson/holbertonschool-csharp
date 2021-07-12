#!/usr/bin/env bash
# Script to initialize, build, and run a new c# project in specified directory

dotnet new console -o 2-new_project
dotnet build 2-new_project
dotnet run -p ./2-new_project
