---
title: "basic_string::rfind"
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
  - "std::basic_string::rfind"
  - "xstring/std::basic_string::rfind"
  - "basic_string::rfind"
  - "basic_string.rfind"
  - "rfind"
  - "std.basic_string.rfind"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rfind method"
ms.assetid: f14c4ec2-e7af-41f9-83fb-c1e4bb7858f8
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::rfind
Searches a string in a backward direction for the first occurrence of a substring that matches a specified sequence of characters.  
  
## Syntax  
  
```  
size_type rfind(  
    value_type _Ch,   
    size_type _Off = npos  
) const;  
size_type rfind(  
    const value_type* _Ptr,  
    size_type _Off = npos  
) const;  
size_type rfind(  
    const value_type* _Ptr,   
    size_type _Off,  
    size_type _Count  
) const;  
size_type rfind(  
    const basic_string<CharType, Traits, Allocator>& _Str,  
    size_type _Off = npos  
) const;  
```  
  
#### Parameters  
 `_Ch`  
 The character value for which the member function is to search.  
  
 `_Off`  
 Index of the position at which the search is to begin.  
  
 `_Ptr`  
 The C-string for which the member function is to search.  
  
 `_Count`  
 The number of characters, counting forward from the first character, in the C-string for which the member function is to search.  
  
 `_Str`  
 The string for which the member function is to search.  
  
## Return Value  
 The index of the last occurrence, when searched backwards, of the first character of the substring when successful; otherwise `npos`.  
  
## Example  
  
```  
// basic_string_rfind.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // The first member function  
   // searches for a single character in a string  
   string str1 ( "Hello Everyone" );  
   cout << "The original string str1 is: " << str1 << endl;  
   basic_string <char>::size_type indexCh1a, indexCh1b;  
   static const basic_string <char>::size_type npos = -1;  
  
   indexCh1a = str1.rfind ( "e" , 9 );  
   if ( indexCh1a != npos )  
      cout << "The index of the 1st 'e' found before the 9th"  
           << " position in str1 is: " << indexCh1a << endl;  
   else  
      cout << "The character 'e' was not found in str1 ." << endl;  
  
   indexCh1b = str1.rfind ( "x" );  
   if ( indexCh1b != npos )  
      cout << "The index of the 'x' found in str1 is: "  
           << indexCh1b << endl << endl;  
   else  
      cout << "The character 'x' was not found in str1."  
           << endl << endl;  
  
   // The second member function searches a string  
   // for a substring as specified by a C-string  
   string str2 ( "Let me make this perfectly clear." );  
   cout << "The original string str2 is: " << str2 << endl;  
   basic_string <char>::size_type indexCh2a, indexCh2b;  
  
   const char *cstr2 = "perfect";  
   indexCh2a = str2.rfind ( cstr2 , 30 );  
   if ( indexCh2a != npos )  
      cout << "The index of the 1st element of 'perfect' "  
           << "before\n the 30th position in str2 is: "  
           << indexCh2a << endl;  
   else  
      cout << "The substring 'perfect' was not found in str2 ."  
           << endl;  
  
   const char *cstr2b = "imperfectly";  
   indexCh2b = str2.rfind ( cstr2b , 30 );  
   if ( indexCh2b != npos )  
      cout << "The index of the 1st element of 'imperfect' "  
           << "before\n the 5th position in str3 is: "  
           << indexCh2b << endl;  
   else  
      cout << "The substring 'imperfect' was not found in str2 ."  
           << endl << endl;  
  
   // The third member function searches a string  
   // for a substring as specified by a C-string  
   string str3 ( "It is a nice day. I am happy." );  
   cout << "The original string str3 is: " << str3 << endl;  
   basic_string <char>::size_type indexCh3a, indexCh3b;  
  
   const char *cstr3a = "nice";  
   indexCh3a = str3.rfind ( cstr3a );  
   if ( indexCh3a != npos )  
      cout << "The index of the 1st element of 'nice' "  
           << "in str3 is: " << indexCh3a << endl;  
   else  
      cout << "The substring 'nice' was not found in str3 ."  
           << endl;  
  
   const char *cstr3b = "am";  
   indexCh3b = str3.rfind ( cstr3b , indexCh3a + 25 , 2 );  
   if ( indexCh3b != npos )  
      cout << "The index of the next occurrance of 'am' in "  
           << "str3 begins at: " << indexCh3b << endl << endl;  
   else  
      cout << "There is no next occurrence of 'am' in str3 ."  
           << endl << endl;  
  
   // The fourth member function searches a string  
   // for a substring as specified by a string  
   string str4 ( "This perfectly unclear." );  
   cout << "The original string str4 is: " << str4 << endl;  
   basic_string <char>::size_type indexCh4a, indexCh4b;  
  
   string str4a ( "clear" );  
   indexCh4a = str4.rfind ( str4a , 15 );  
   if (indexCh4a != npos )  
      cout << "The index of the 1st element of 'clear' "  
           << "before\n the 15th position in str4 is: "  
           << indexCh4a << endl;  
   else  
      cout << "The substring 'clear' was not found in str4 "  
           << "before the 15th position." << endl;  
  
   string str4b ( "clear" );  
   indexCh4b = str4.rfind ( str4b );  
   if ( indexCh4b != npos )  
      cout << "The index of the 1st element of 'clear' "  
           << "in str4 is: "  
           << indexCh4b << endl;  
   else  
      cout << "The substring 'clear' was not found in str4 ."  
           << endl << endl;  
}  
```  
  
 **The original string str1 is: Hello Everyone**  
**The index of the 1st 'e' found before the 9th position in str1 is: 8**  
**The character 'x' was not found in str1.**  
**The original string str2 is: Let me make this perfectly clear.**  
**The index of the 1st element of 'perfect' before**  
 **the 30th position in str2 is: 17**  
**The substring 'imperfect' was not found in str2 .**  
**The original string str3 is: It is a nice day. I am happy.**  
**The index of the 1st element of 'nice' in str3 is: 8**  
**The index of the next occurrance of 'am' in str3 begins at: 20**  
**The original string str4 is: This perfectly unclear.**  
**The substring 'clear' was not found in str4 before the 15th position.**  
**The index of the 1st element of 'clear' in str4 is: 17**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)