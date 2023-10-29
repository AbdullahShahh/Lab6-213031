static void Print(Ilist<string> list)

{
    console.WriteLIne("count :{0} , list.count");
    foreach (string value in list)
 {
   console.WriteLine(value);

 }   
}

static void Main (string[] args)
{
string[]strarray = new string[2];
strarray[0] = "Hello";
strarray[1] = "world";
Print(strArray);


list<string> strLIst = new List<string>();
strList.Add("Hello");

strList.Add("world");
Print(strLIst);
 


}