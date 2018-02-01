unit test_log_op;

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
