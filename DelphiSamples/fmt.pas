unit unitFormatFunction;

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

 
