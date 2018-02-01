unit Ent1; 

interface

implementation

procedure DirDefault;
var
i:integer;
Bourre:char;
St:string;
Label 0;
BEGIN
Bourre:='a';
While i>0 Do 
 BEGIN 
  If St[i]=Bourre Then St[i]:=' ' 
   Else Goto 0;
  Dec(i); 
 END;
0: i:=100;
end;

end.