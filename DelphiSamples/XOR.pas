unit Unit2;

interface
Uses SysUtils;

implementation

procedure Test1;
var
a, b : boolean;
begin
a := true;
b := false;
if (a Xor b = true) then
begin
end;
if (a <> b) then
begin
end;
if not a then
begin
end;
if a or b then
begin
end;
if not (a and b) then
begin
end;
end;


end.