@echo off

set GIT=git\\cmd\\git.exe
set PYTHON=Python39\\python.exe
%PYTHON% openai_api.py --precision fp16dual --model-path "model\models--THUDM--chatglm3-6b"    --availablecard "0,1"

pause
exit /b