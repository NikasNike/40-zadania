﻿bool x=true;
bool y=false;
bool f1=!(x || y);
bool f2=!x && !y;
Console.WriteLine(f1==f2);