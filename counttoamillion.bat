@echo off
set /a num = 0
echo This is a program written in batch that compares batch to C# in terms of speed.
echo|set /p =press enter to start the program.
set /p input = 
:start
echo %num%
set /a num = %num% + 1
if %num% geq 1000002 goto end
if %num% lss 1000001 goto start
:end
echo.
echo it just repeated 1,000,000 times.
echo it's a lot slower than C# but still a lot faster than you could ever do.
echo|set /p =press enter to exit the program.
set /p input =
exit