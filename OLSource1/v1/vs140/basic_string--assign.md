---
title: "basic_string::assign"
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
  - "basic_string::assign"
  - "basic_string.assign"
  - "assign"
  - "Assign"
  - "std.basic_string.assign"
  - "xstring/std::basic_string::assign"
  - "std::basic_string::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign method"
  - "assign function"
ms.assetid: fc864882-6e04-4c3a-9a1e-c78f0f1ea8ad
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::assign
Assigns new character values to the contents of a string.  
  
## Syntax  
  
```  
basic_string<CharType, Traits, Allocator>& assign(  
    const value_type* _Ptr  
);  
basic_string<CharType, Traits, Allocator>& assign(  
    const value_type* _Ptr,  
    size_type _Count  
);  
basic_string<CharType, Traits, Allocator>& assign(  
    const basic_string<CharType, Traits, Allocator>& _Str,  
    size_type off,   
    size_type _Count  
);  
basic_string<CharType, Traits, Allocator>& assign(  
    const basic_string<CharType, Traits, Allocator>& _Str  
);  
basic_string<CharType, Traits, Allocator>& assign(  
    size_type _Count,   
    value_type _Ch  
);  
template<class InIt>  
    basic_string<CharType, Traits, Allocator>& assign(  
        InputIterator _First,   
        InputIterator _Last  
    );  
basic_string<CharType, Traits, Allocator>& assign(  
    const_pointer _First,  
    const_pointer _Last  
);  
basic_string<CharType, Traits, Allocator>& assign(  
    const_iterator _First,  
    const_iterator _Last  
);  
```  
  
#### Parameters  
 `_Ptr`  
 A pointer to the characters of the C-string to be assigned to the target string.  
  
 `_Count`  
 The number of characters to be appended, at most, from the source string.  
  
 `_Str`  
 The source string whose characters are to be assigned to the target string.  
  
 `_Ch`  
 The character value to be assigned.  
  
 `_First`  
 An input iterator, const_pointer, or const_iterator addressing the first character in the range of the source string to be assigned to the target range.  
  
 `_Last`  
 An input iterator, const_pointer, or const_iterator addressing the one beyond the last character in the range of the source string to be assigned to the target range.  
  
 `off`  
 The position at which new characters will start to be assigned.  
  
## Return Value  
 A reference to the string object that is being assigned new characters by the member function.  
  
## Remarks  
 The strings can be assigned new character values. The new value can be either a string and C-string or a single character. The [operator=](../vs140/basic_string--operator=.md) may be used if the new value can be described by a single parameter; otherwise the member function **assign**, which has multiple parameters, can be used to specify which part of the string is to be assigned to a target string.  
  
## Example  
  
```  
// basic_string_assign.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   // The first member function assigning the  
   // characters of a C-string to a string  
   string str1a;  
   const char *cstr1a = "Out There";  
   cout << "The C-string cstr1a is: " << cstr1a <<  "." << endl;  
   str1a.assign ( cstr1a );  
   cout << "Assigning the C-string cstr1a to string str1 gives: "   
        << str1a << "." << endl << endl;  
  
   // The second member function assigning a specific  
   // number of the of characters a C-string to a string  
   string  str1b;  
   const char *cstr1b = "Out There";  
   cout << "The C-string cstr1b is: " << cstr1b << endl;  
   str1b.assign ( cstr1b , 3 );  
   cout << "Assigning the 1st part of the C-string cstr1b "  
        << "to string str1 gives: " << str1b << "."   
        << endl << endl;  
  
   // The third member function assigning a specific number  
   // of the characters from one string to another string   
   string str1c ( "Hello " ), str2c ( "Wide World " );  
   cout << "The string str2c is: " << str2c << endl;  
   str1c.assign ( str2c , 5 , 5 );  
   cout << "The newly assigned string str1 is: "   
        << str1c << "." << endl << endl;  
  
   // The fourth member function assigning the characters  
   // from one string to another string in two equivalent  
   // ways, comparing the assign and operator =  
   string str1d ( "Hello" ), str2d ( "Wide" ), str3d ( "World" );  
   cout << "The original string str1 is: " << str1d << "." << endl;  
   cout << "The string str2d is: " << str2d << endl;  
   str1d.assign ( str2d );  
   cout << "The string str1 newly assigned with string str2d is: "   
        << str1d << "." << endl;  
   cout << "The string str3d is: " << str3d << "." << endl;  
   str1d = str3d;  
   cout << "The string str1 reassigned with string str3d is: "   
        << str1d << "." << endl << endl;  
  
   // The fifth member function assigning a specific   
   // number of characters of a certain value to a string  
   string str1e ( "Hello " );  
   str1e.assign ( 4 , '!' );  
   cout << "The string str1 assigned with eclamations is: "   
        << str1e << endl << endl;  
  
   // The sixth member function assigning the value from  
   // the range of one string to another string  
   string str1f ( "Hello " ), str2f ( "Wide World " );  
   cout << "The string str2f is: " << str2f << endl;  
   str1f.assign ( str2f.begin ( ) + 5 , str2f.end ( ) - 1 );  
   cout << "The string str1 assigned a range of string str2f is: "   
        << str1f << "." << endl << endl;  
}  
```  
  
 **The C-string cstr1a is: Out There.**  
**Assigning the C-string cstr1a to string str1 gives: Out There.**  
**The C-string cstr1b is: Out There**  
**Assigning the 1st part of the C-string cstr1b to string str1 gives: Out.**  
**The string str2c is: Wide World**   
**The newly assigned string str1 is: World.**  
**The original string str1 is: Hello.**  
**The string str2d is: Wide**  
**The string str1 newly assigned with string str2d is: Wide.**  
**The string str3d is: World.**  
**The string str1 reassigned with string str3d is: World.**  
**The string str1 assigned with eclamations is: !!!!**  
**The string str2f is: Wide World**   
**The string str1 assigned a range of string str2f is: World.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)