---
title: "basic_string::compare"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "Compare"
  - "std.basic_string.compare"
  - "basic_string.compare"
  - "std::basic_string::compare"
  - "basic_string::compare"
  - "xstring/std::basic_string::compare"
  - "compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "compare method"
ms.assetid: 5c719d5c-93b1-4ea8-bbd3-80c2745b5c73
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::compare
Performs a case sensitive comparison with a specified string to determine if the two strings are equal or if one is lexicographically less than the other.  
  
## Syntax  
  
```  
int compare(  
    const basic_string<CharType, Traits, Allocator>& _Str  
) const;  
int compare(  
    size_type _Pos1,   
    size_type _Num1,  
    const basic_string<CharType, Traits, Allocator>& _Str  
) const;  
int compare(  
    size_type _Pos1,  
    size_type _Num1,  
    const basic_string<CharType, Traits, Allocator>& _Str,   
    size_type _Off,   
    size_type _Count  
) const;  
int compare(  
    const value_type* _Ptr  
) const;  
int compare(  
    size_type _Pos1,  
    size_type _Num1,  
    const value_type* _Ptr  
) const;  
int compare(  
    size_type _Pos1,  
    size_type _Num1,  
    const value_type* _Ptr  
    size_type _Num2  
) const;  
```  
  
#### Parameters  
 `_Str`  
 The string that is to be compared to the operand string.  
  
 `_Pos1`  
 The index of the operand string at which the comparison begins.  
  
 `_Num1`  
 The maximum number of characters from the operand string to be compared.  
  
 `_Num2`  
 The maximum number of characters from the parameter string to be compared.  
  
 `_Off`  
 The index of the parameter string at which the comparison begins.  
  
 `_Count`  
 The maximum number of characters from the parameter string to be compared.  
  
 `_Ptr`  
 The C-string to be compared to the operand string.  
  
## Return Value  
 A negative value if the operand string is less than the parameter string; zero if the two strings are equal; or a positive value if the operand string is greater than the parameter string.  
  
## Remarks  
 The **compare** member functions compare either all or part of the parameter and operand strings depending on which in used.  
  
 The comparison performed is case sensitive.  
  
## Example  
  
```  
// basic_string_compare.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   // The first member function compares  
   // an operand string to a parameter string  
   int comp1;  
   string s1o ( "CAB" );  
   string s1p ( "CAB" );  
   cout << "The operand string is: " << s1o << endl;  
   cout << "The parameter string is: " << s1p << endl;  
   comp1 = s1o.compare ( s1p );  
   if ( comp1 < 0 )  
      cout << "The operand string is less than "  
           << "the parameter string." << endl;  
   else if ( comp1 == 0 )  
      cout << "The operand string is equal to "  
           << "the parameter string." << endl;  
   else  
      cout << "The operand string is greater than "  
           << "the parameter string." << endl;  
   cout << endl;  
  
   // The second member function compares part of  
   // an operand string to a parameter string  
   int comp2a, comp2b;  
   string s2o ( "AACAB" );  
   string s2p ( "CAB" );  
   cout << "The operand string is: " << s2o << endl;  
   cout << "The parameter string is: " << s2p << endl;  
   comp2a = s2o.compare (  2 , 3 , s2p );  
   if ( comp2a < 0 )  
      cout << "The last three characters of "  
           << "the operand string\n are less than "  
           << "the parameter string." << endl;  
   else if ( comp2a == 0 )  
      cout << "The last three characters of "  
           << "the operand string\n are equal to "  
           << "the parameter string." << endl;  
   else  
      cout << "The last three characters of "  
           << "the operand string\n is greater than "  
           << "the parameter string." << endl;  
  
   comp2b = s2o.compare (  0 , 3 , s2p );  
   if ( comp2b < 0 )  
      cout << "The first three characters of "  
           << "the operand string\n are less than "  
           << "the parameter string." << endl;  
   else if ( comp2b == 0 )  
      cout << "The first three characters of "  
           << "the operand string\n are equal to "  
           << "the parameter string." << endl;  
   else  
      cout << "The first three characters of "  
           << "the operand string\n is greater than "  
           << "the parameter string." << endl;  
   cout << endl;  
  
   // The third member function compares part of  
   // an operand string to part of a parameter string  
   int comp3a;  
   string s3o ( "AACAB" );  
   string s3p ( "DCABD" );  
   cout << "The operand string is: " << s3o << endl;  
   cout << "The parameter string is: " << s3p << endl;  
   comp3a = s3o.compare (  2 , 3 , s3p , 1 , 3 );  
   if ( comp3a < 0 )  
      cout << "The three characters from position 2 of "  
           << "the operand string are less than\n "  
           << "the 3 characters parameter string "   
           << "from position 1." << endl;  
   else if ( comp3a == 0 )  
      cout << "The three characters from position 2 of "  
           << "the operand string are equal to\n "  
           << "the 3 characters parameter string "   
           << "from position 1." << endl;  
   else  
      cout << "The three characters from position 2 of "  
           << "the operand string is greater than\n "  
           << "the 3 characters parameter string "   
           << "from position 1." << endl;  
   cout << endl;  
  
   // The fourth member function compares  
   // an operand string to a parameter C-string  
   int comp4a;  
   string s4o ( "ABC" );  
   const char* cs4p = "DEF";  
   cout << "The operand string is: " << s4o << endl;  
   cout << "The parameter C-string is: " << cs4p << endl;  
   comp4a = s4o.compare ( cs4p );  
   if ( comp4a < 0 )  
      cout << "The operand string is less than "  
           << "the parameter C-string." << endl;  
   else if ( comp4a == 0 )  
      cout << "The operand string is equal to "  
           << "the parameter C-string." << endl;  
   else  
      cout << "The operand string is greater than "  
           << "the parameter C-string." << endl;  
   cout << endl;  
  
   // The fifth member function compares part of  
   // an operand string to a parameter C-string  
   int comp5a;  
   string s5o ( "AACAB" );  
   const char* cs5p = "CAB";  
   cout << "The operand string is: " << s5o << endl;  
   cout << "The parameter string is: " << cs5p << endl;  
   comp5a = s5o.compare (  2 , 3 , s2p );  
   if ( comp5a < 0 )  
      cout << "The last three characters of "  
           << "the operand string\n are less than "  
           << "the parameter C-string." << endl;  
   else if ( comp5a == 0 )  
      cout << "The last three characters of "  
           << "the operand string\n are equal to "  
           << "the parameter C-string." << endl;  
   else  
      cout << "The last three characters of "  
           << "the operand string\n is greater than "  
           << "the parameter C-string." << endl;  
   cout << endl;  
  
   // The sixth member function compares part of  
   // an operand string to part of an equal length of  
   // a parameter C-string  
   int comp6a;  
   string s6o ( "AACAB" );  
   const char* cs6p = "ACAB";  
   cout << "The operand string is: " << s6o << endl;  
   cout << "The parameter C-string is: " << cs6p << endl;  
   comp6a = s6o.compare (  1 , 3 , cs6p , 3 );  
   if ( comp6a < 0 )  
      cout << "The 3 characters from position 1 of "  
           << "the operand string are less than\n "  
           << "the first 3 characters of the parameter C-string."   
           << endl;  
   else if ( comp6a == 0 )  
      cout << "The 3 characters from position 2 of "  
           << "the operand string are equal to\n "  
           << "the first 3 characters of the parameter C-string."   
           <<  endl;  
   else  
      cout << "The 3 characters from position 2 of "  
           << "the operand string is greater than\n "  
           << "the first 3 characters of the parameter C-string."   
           << endl;  
   cout << endl;  
}  
```  
  
 **The operand string is: CAB**  
**The parameter string is: CAB**  
**The operand string is equal to the parameter string.**  
**The operand string is: AACAB**  
**The parameter string is: CAB**  
**The last three characters of the operand string**  
 **are equal to the parameter string.**  
**The first three characters of the operand string**  
 **are less than the parameter string.**  
**The operand string is: AACAB**  
**The parameter string is: DCABD**  
**The three characters from position 2 of the operand string are equal to**  
 **the 3 characters parameter string from position 1.**  
**The operand string is: ABC**  
**The parameter C-string is: DEF**  
**The operand string is less than the parameter C-string.**  
**The operand string is: AACAB**  
**The parameter string is: CAB**  
**The last three characters of the operand string**  
 **are equal to the parameter C-string.**  
**The operand string is: AACAB**  
**The parameter C-string is: ACAB**  
**The 3 characters from position 2 of the operand string are equal to**  
 **the first 3 characters of the parameter C-string.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)