using System;

namespace test.todo
{

  public class test
  {

    public static void TestPosFunction()
    {
      const String sqlResult = "SELECT * FROM DETABLES!";
      string sql;
      int i;
      i = string.IndexOf(sqlResult, '*');
      if (i != 8)
      {
        throw new Exception("''*'' should be at position 8");
      }
      sql = sqlResult;

      if (sql == '*')
      {
      }
      else
      {
        throw Exception.CreateFmt("''*'' expected at position %d", i);
      }
    }
  }
}

/*unit test;

interface

implementation
procedure TestPosFunction;
const
  sqlResult = 'SELECT * FROM DETABLES!';
var
  sql : string;
  i : integer;
begin
  i := Pos('*', sqlResult);
  if (i <> 8) then
    raise Exception.Create('''*'' should be at position 8');
  sql := sqlResult;
  //test inverse
  if (sql[i] = '*') then
  begin
  end
  else
  begin
    raise Exception.CreateFmt('''*'' expected at position %d', [i]);
  end;
end;
 

end.*/
