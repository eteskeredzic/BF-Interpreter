#include <iostream>
#include <string>

// a (poorly written) helper program for translating your input into BF code that produces said input

std::string pretvori(char c){

std::string rez;
int prva{},druga{};
prva = (int)c %10;
c/=10;
druga = c%10;
rez+="[-]>";
for(int i = 0; i<druga; ++i) rez+="+";
rez+="[<++++++++++>-]<";
for(int i = 0; i<prva; ++i) rez+="+";
rez+=".";
return rez;
}



int main(){

std::string s;
std::getline(std::cin,s);
std::string rez{};

for(auto c:s) rez+=pretvori(c);

std::cout<<rez;


return 0;
}
