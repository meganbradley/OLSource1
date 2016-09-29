---
title: "basic_string::insert"
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
  - "std::basic_string::insert"
  - "Insert"
  - "insert"
  - "basic_string::insert"
  - "xstring/std::basic_string::insert"
  - "basic_string.insert"
  - "std.basic_string.insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: c71e5a6f-e26a-4d8f-a56e-526be4276e5a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::insert
Inserts an element or a number of elements or a range of elements into the string at a specified position.  
  
## Syntax  
  
```  
basic_string<CharType, Traits, Allocator>& insert(  
   size_type _P0,   
   const value_type* _Ptr  
);  
basic_string<CharType, Traits, Allocator>& insert(  
   size_type _P0,   
   const value_type* _Ptr,  
   size_type _Count  
);  
basic_string<CharType, Traits, Allocator>& insert(  
   size_type _P0,  
   const basic_string<CharType, Traits, Allocator>& _Str  
);  
basic_string<CharType, Traits, Allocator>& insert(  
   size_type _P0,  
   const basic_string<CharType, Traits, Allocator>& _Str,   
   size_type _Off,   
   size_type _Count  
);  
basic_string<CharType, Traits, Allocator>& insert(  
   size_type _P0,  
   size_type _Count,   
   value_type _Ch  
);  
iterator insert(  
   iterator _It  
);  
iterator insert(  
   iterator _It,  
   value_type _Ch  
)l  
template<class InputIterator>  
   void insert(  
      iterator _It,   
      InputIterator _First,   
      InputIterator _Last  
   );  
void insert(  
   iterator _It,   
   size_type _Count,   
   value_type _Ch  
);  
void insert(  
   iterator _It,  
   const_pointer _First,  
   const_pointer _Last  
);  
void insert(  
   iterator _It,  
   const_iterator _First,  
   const_iterator _Last  
);  
```  
  
#### Parameters  
 *_P0*  
 The index of the position behind the point of insertion the new characters.  
  
 `_Ptr`  
 The C-string to be wholly or partly inserted into the string.  
  
 `_Count`  
 The number of characters to be inserted.  
  
 `_Str`  
 The string to be wholly or partly inserted into the target string.  
  
 `_Off`  
 The index of the part of the source string supplying the characters to be appended.  
  
 `_Ch`  
 The character value of the elements to be inserted.  
  
 `_It`  
 An iterator addressing the position behind which a character is to be inserted.  
  
 `_First`  
 An input iterator, const_pointer, or const_iterator addressing the first element in the source range to be inserted.  
  
 `_Last`  
 An input iterator, const_pointer, or const_iterator addressing the position of the one beyond the last element in the source range to be inserted.  
  
## Return Value  
 Either a reference to the string object that is being assigned new characters by the member function or, in the case of individual character insertions, an iterator addressing the position of the character inserted, or none, depending on the particular member function.  
  
## Example  
  
```  
// basic_string_insert.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // The first member function inserting a C-string  
   // at a given position  
   basic_string <char> str1a ( "way" );  
   const char *cstr1a = "a";  
   str1a.insert ( 0, cstr1a );  
   cout << "The string with a C-string inserted at position 0 is: "  
        << str1a << "." << endl;  
  
   // The second member function inserting a C-string  
   // at a given position for a specified number of elements  
   basic_string <char> str2a ( "Good" );  
   const char *cstr2a = "Bye Bye Baby";  
   str2a.insert ( 4, cstr2a ,3 );  
   cout << "The string with a C-string inserted at the end is: "  
        << str2a << "." << endl;  
  
   // The third member function inserting a string  
   // at a given position  
   basic_string <char> str3a ( "Bye" );  
   string str3b ( "Good" );  
   str3a.insert ( 0, str3b );  
   cout << "The string with a string inserted at position 0 is: "  
        << str3a << "." << endl;  
  
   // The fourth member function inserting part of  
   // a string at a given position  
   basic_string <char> str4a ( "Good " );  
   string str4b ( "Bye Bye Baby" );  
   str4a.insert ( 5, str4b , 8 , 4 );  
   cout << "The string with part of a string inserted at position 4 is: "  
        << str4a << "." << endl;  
  
   // The fifth member function inserts a number of characters  
   // at a specified position in the string  
   string str5 ( "The number is: ." );  
   str5.insert ( 15 , 3 , '3' );  
   cout << "The string with characters inserted is: "  
        << str5 << endl;  
  
   // The sixth member function inserts a character  
   // at a specified position in the string  
   string str6 ( "ABCDFG" );  
   basic_string <char>::iterator str6_Iter = ( str6.begin ( ) + 4 );  
   str6.insert ( str6_Iter , 'e' );  
   cout << "The string with a character inserted is: "  
        << str6 << endl;  
  
   // The seventh member function inserts a range  
   // at a specified position in the string  
   string str7a ( "ABCDHIJ" );  
   string str7b ( "abcdefgh" );  
   basic_string <char>::iterator str7a_Iter = (str7a.begin ( ) + 4 );  
   str7a.insert ( str7a_Iter , str7b.begin ( ) + 4 , str7b.end ( ) -1 );  
   cout << "The string with a character inserted from a range is: "  
        << str7a << endl;  
  
   // The eigth member function inserts a number of  
   // characters at a specified position in the string  
   string str8 ( "ABCDHIJ" );  
   basic_string <char>::iterator str8_Iter = ( str8.begin ( ) + 4 );  
   str8.insert ( str8_Iter , 3 , 'e' );  
   cout << "The string with a character inserted from a range is: "  
        << str8 << endl;  
}  
```  
  
 **The string with a C-string inserted at position 0 is: away.**  
**The string with a C-string inserted at the end is: GoodBye.**  
**The string with a string inserted at position 0 is: GoodBye.**  
**The string with part of a string inserted at position 4 is: Good Baby.**  
**The string with characters inserted is: The number is: 333.**  
**The string with a character inserted is: ABCDeFG**  
**The string with a character inserted from a range is: ABCDefgHIJ**  
**The string with a character inserted from a range is: ABCDeeeHIJ**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)