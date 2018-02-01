unit Unit2;

interface

Uses SysUtils;

implementation

procedure HRMajTableUtilisees();
var
   TextEx: string;

begin

  try

    TextEx := '5';

  except

    on E: Exception do

    begin

     raise;

    end;

  end;

end;


end.