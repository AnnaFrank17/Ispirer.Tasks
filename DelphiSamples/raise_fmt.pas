unit test;

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
 

end.
