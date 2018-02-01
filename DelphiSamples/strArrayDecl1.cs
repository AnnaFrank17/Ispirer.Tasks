using System;
using SysUtils;

namespace Unit2
{
  public class Unit2
  {

    public static void StrDecl()
    {
      string[] GG = new string[5];
      GG[1] = "Grille1";
    }
  }
}

/*unit Unit2;

interface
Uses SysUtils;

implementation

procedure StrDecl;
var
  GG: array[1..5] of string;
begin
  GG[1] := 'Grille1';
end;

end.
*/