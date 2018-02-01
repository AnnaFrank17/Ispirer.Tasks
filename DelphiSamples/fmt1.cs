using System;

namespace unitFormatFunction
{

  public class unitFormatFunction
  {

    public static string TestFormatFunction()
    {
      return Format("%d", 12);
    }

    public static string TestFormatFunction1()
    {
      return Format("%d %s", 12 | "coucou");
    }
  }
}

/*unit unitFormatFunction;

interface
implementation
function TestFormatFunction : string;
begin
  result := Format('%d', [12]);
end;

function TestFormatFunction1 : string;
begin
  result := Format('%d %s', [12, 'coucou']);
end;
end.

 
*/