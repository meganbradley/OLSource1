---
title: "basic_string::append"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - Append
  - xstring/std::basic_string::append
  - std::basic_string::append
  - append
  - std.basic_string.append
  - basic_string.append
  - basic_string::append
dev_langs: 
  - C++
helpviewer_keywords: 
  - append method
ms.assetid: cc71e4b4-2da5-4674-88ec-17f30045c873
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_string::append
Adds characters to the end of a string.  
  
## Syntax  
  
```  
basic_string<CharType, Traits, Allocator>& append(  
    const value_type* _Ptr  
);  
basic_string<CharType, Traits, Allocator>& append(  
    const value_type* _Ptr,  
    size_type _Count  
);  
basic_string<CharType, Traits, Allocator>& append(  
    const basic_string<CharType, Traits, Allocator>& _Str,  
    size_type _Off,  
    size_type _Count  
);  
basic_string<CharType, Traits, Allocator>& append(  
    const basic_string<CharType, Traits, Allocator>& _Str  
);  
basic_string<CharType, Traits, Allocator>& append(  
    size_type _Count,   
    value_type _Ch  
);  
template<class InputIterator>  
    basic_string<CharType, Traits, Allocator>& append(  
        InputIterator _First,   
        InputIterator _Last  
    );  
basic_string<CharType, Traits, Allocator>& append(  
    const_pointer _First,  
    const_pointer _Last  
);  
basic_string<CharType, Traits, Allocator>& append(  
    const_iterator _First,  
    const_iterator _Last  
);  
```  
  
#### Parameters  
 `_Ptr`  
 The C-string to be appended.  
  
 `_Str`  
 The string whose characters are to be appended.  
  
 `_Off`  
 The index of the part of the source string supplying the characters to be appended.  
  
 `_Count`  
 The number of characters to be appended, at most, from the source string.  
  
 `_Ch`  
 The character value to be appended.  
  
 `_First`  
 An input iterator addressing the first element in the range to be appended.  
  
 `_Last`  
 An input iterator, const_pointer, or const_iterator addressing the position of the one beyond the last element in the range to be appended.  
  
## Return Value  
 A reference to the string object that is being appended with the characters passed by the member function.  
  
## Remarks  
 Characters may be appended to a string using the [operator+=](../vs140/basic_string--operator-=.md) or the member functions **append** or [push_back](../vs140/basic_string--push_back.md). `operator+=` appends single-argument values while the multiple-argument **append** member function allows a specific part of a string to be specified for adding.  
  
## Example  
  
```  
// basic_string_append.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   // The first member function  
   // appending a C-string to a string  
   string str1a ( "Hello " );  
   cout << "The original string str1 is: " << str1a << endl;  
   const char *cstr1a = "Out There ";  
   cout << "The C-string cstr1a is: " << cstr1a << endl;  
   str1a.append ( cstr1a );  
   cout << "Appending the C-string cstr1a to string str1 gives: "   
        << str1a << "." << endl << endl;  
  
   // The second member function  
   // appending part of a C-string to a string  
   string str1b ( "Hello " );  
   cout << "The string str1b is: " << str1b << endl;  
   const char *cstr1b = "Out There ";  
   cout << "The C-string cstr1b is: " << cstr1b << endl;  
   str1b.append ( cstr1b , 3 );  
   cout << "Appending the 1st part of the C-string cstr1b "  
        << "to string str1 gives: " << str1b << "."   
        << endl << endl;  
  
   // The third member function  
   // appending part of one string to another  
   string str1c ( "Hello " ), str2c ( "Wide World " );  
   cout << "The string str2c is: " << str2c << endl;  
   str1c.append ( str2c , 5 , 5 );  
   cout << "The appended string str1 is: "   
        << str1c << "." << endl << endl;  
  
   // The fourth member function  
   // appending one string to another in two ways,  
   // comparing append and operator [ ]  
   string str1d ( "Hello " ), str2d ( "Wide " ), str3d ( "World " );  
   cout << "The  string str2d is: " << str2d << endl;  
   str1d.append ( str2d );  
   cout << "The appended string str1d is: "   
        << str1d << "." << endl;  
   str1d += str3d;  
   cout << "The doubly appended strig str1 is: "   
        << str1d << "." << endl << endl;  
  
   // The fifth member function  
   // appending characters to a string  
   string str1e ( "Hello " );  
   str1e.append ( 4 , '!' );  
   cout << "The string str1 appended with exclamations is: "   
        << str1e << endl << endl;  
  
   // The sixth member function  
   // appending a range of one string to another  
   string str1f ( "Hello " ), str2f ( "Wide World " );  
   cout << "The string str2f is: " << str2f << endl;  
   str1f.append ( str2f.begin ( ) + 5 , str2f.end ( ) - 1 );  
   cout << "The appended string str1 is: "   
        << str1f << "." << endl << endl;  
}  
```  
  
 **The original string str1 is: Hello**   
**The C-string cstr1a is: Out There**   
**Appending the C-string cstr1a to string str1 gives: Hello Out There .**  
**The string str1b is: Hello**   
**The C-string cstr1b is: Out There**   
**Appending the 1st part of the C-string cstr1b to string str1 gives: Hello Out.**  
**The string str2c is: Wide World**   
**The appended string str1 is: Hello World.**  
**The  string str2d is: Wide**   
**The appended string str1d is: Hello Wide .**  
**The doubly appended strig str1 is: Hello Wide World .**  
**The string str1 appended with exclamations is: Hello !!!!**  
**The string str2f is: Wide World**   
**The appended string str1 is: Hello World.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)   
 [basic_string::append](../vs140/basic_string--append--stl-samples-.md)