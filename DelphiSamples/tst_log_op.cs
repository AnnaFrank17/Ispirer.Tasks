using System;

namespace test_log_op.todo
{

  public class test_log_op
  {

    public static void Test2()
    {
      int i;
      int i1;
      int r;
      DWORD di;
      DWORD dwr;
      string s;
      i =  Convert.ToString(1, 16);
      i1 =  Convert.ToString(2,16);
      r = i || i1;
      if (r != Convert.ToString(3,16))
      {
        throw new Exception("must be $3");
      }
      di = Convert.ToString(123,16);
      dwr = di &&  (Convert.ToString(65535, 16));
      s = dwr.ToString();;
      if (s != di.ToString()))
      {
        throw new Exception("it must be $123");
      }
    }
  }
}


/*unit test_log_op;

interface

procedure Test2;

implementation


procedure Test2;
var
   i, i1, r : integer;
   di, dwr : DWORD;
   s : string;
begin
  i := $01;
  i1 := $02;
  r := i or i1;
  if r <> $3 then
  begin
    raise Exception.Create('must be $3');
  end;

  di := $123;
  dwr := di and $FFFF;
  s := IntToStr(dwr);
  if (s <> IntToStr($123)) then
  begin
    raise Exception.Create('it must be $123');
  end;
end;
end.
*/
