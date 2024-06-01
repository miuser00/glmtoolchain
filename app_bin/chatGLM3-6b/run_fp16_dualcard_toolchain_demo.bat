@echo off

set GIT=git\\cmd\\git.exe
set PYTHON=Python39\\python.exe

%PYTHON% openai_api_demo_toolchain.py

pause
exit /b