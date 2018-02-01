using System;

namespace Ent1
{

  public class Ent1
  {

    void DirDefault()
    {
		int i;
		char Bourre;
		string St;
		0:
			Bourre = 'a';
				while (i > 0)
				{
					if (St == Bourre)
						{
							St[i] = ' ';
						}
						else
						  0;
					Dec(i);
				}
			i = 100;
    }

    public static void Main(string[] args)
    {
      Ent1 myApp = new Ent1();
      myApp.DirDefault();
    }
  }
}

/*
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

end.*/