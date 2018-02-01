unit Unit2;

interface
Uses SysUtils;

implementation

procedure MyProc(var a: integer);
var
TypePresent: integer;
begin
if (TypePresent and 2) = 2 then a:=a+15;
end;
end.