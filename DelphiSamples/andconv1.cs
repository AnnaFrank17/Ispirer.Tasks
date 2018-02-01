using System;
using SysUtils;

namespace Unit2
{

  public class Unit2
  {

    public static void MyProc(int a)
    {
      int TypePresent;
      if ((TypePresent && 2) == 2)
      {
        a = a + 15;
      }
    }
  }
}



/*unit Unit2;

interface
Uses SysUtils;

implementation

procedure MyProc(var a: integer);
var
TypePresent: integer;
begin
if (TypePresent and 2) = 2 then a:=a+15;
end;
end.*/