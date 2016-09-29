---
title: "basic_string::find"
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
  - "find"
  - "basic_string.find"
  - "Find"
  - "xstring/std::basic_string::find"
  - "std::basic_string::find"
  - "std.basic_string.find"
  - "basic_string::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method"
ms.assetid: e8254589-ae65-4414-b28f-54ba8f544656
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::find
Searches a string in a forward direction for the first occurrence of a substring that matches a specified sequence of characters.  
  
## Syntax  
  
```  
size_type find(  
    value_type _Ch,   
    size_type _Off = 0  
) const;  
size_type find(  
    const value_type* _Ptr,  
    size_type _Off = 0  
) const;  
size_type find(  
    const value_type* _Ptr,   
    size_type _Off,  
    size_type _Count  
) const;  
size_type find(  
    const basic_string<CharType, Traits, Allocator>& _Str,  
    size_type _Off = 0  
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
 The index of the first character of the substring searched for when successful; otherwise `npos`.  
  
## Example  
  
```  
// basic_string_find.cpp  
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
  
   indexCh1a = str1.find ( "e" , 3 );  
   if (indexCh1a != string::npos )  
      cout << "The index of the 1st 'e' found after the 3rd"  
           << " position in str1 is: " << indexCh1a << endl;  
   else  
      cout << "The character 'e' was not found in str1 ." << endl;  
  
   indexCh1b = str1.find ( "x" );  
   if (indexCh1b != string::npos )  
      cout << "The index of the 'x' found in str1 is: "  
           << indexCh1b << endl << endl;  
   else  
      cout << "The Character 'x' was not found in str1."  
           << endl << endl;  
  
   // The second member function searches a string  
   // for a substring as specified by a C-string  
   string str2 ( "Let me make this perfectly clear." );  
   cout << "The original string str2 is: " << str2 << endl;  
   basic_string <char>::size_type indexCh2a, indexCh2b;  
  
   const char *cstr2 = "perfect";  
   indexCh2a = str2.find ( cstr2 , 5 );  
   if ( indexCh2a != string::npos )  
      cout << "The index of the 1st element of 'perfect' "  
           << "after\n the 5th position in str2 is: "  
           << indexCh2a << endl;  
   else  
      cout << "The substring 'perfect' was not found in str2 ."  
           << endl;  
  
   const char *cstr2b = "imperfectly";  
   indexCh2b = str2.find ( cstr2b , 0 );  
   if (indexCh2b != string::npos )  
      cout << "The index of the 1st element of 'imperfect' "  
           << "after\n the 5th position in str3 is: "  
           << indexCh2b << endl;  
   else  
      cout << "The substring 'imperfect' was not found in str2 ."  
           << endl << endl;  
  
   // The third member function searches a string  
   // for a substring as specified by a C-string  
   string str3 ( "This is a sample string for this program" );  
   cout << "The original string str3 is: " << str3 << endl;  
   basic_string <char>::size_type indexCh3a, indexCh3b;  
  
   const char *cstr3a = "sample";  
   indexCh3a = str3.find ( cstr3a );  
   if ( indexCh3a != string::npos )  
      cout << "The index of the 1st element of sample "  
           << "in str3 is: " << indexCh3a << endl;  
   else  
      cout << "The substring 'perfect' was not found in str3 ."  
           << endl;  
  
   const char *cstr3b = "for";  
   indexCh3b = str3.find ( cstr3b , indexCh3a + 1 , 2 );  
   if (indexCh3b != string::npos )  
      cout << "The index of the next occurrence of 'for' is in "  
           << "str3 begins at: " << indexCh3b << endl << endl;  
   else  
      cout << "There is no next occurrence of 'for' in str3 ."  
           << endl << endl;  
  
   // The fourth member function searches a string  
   // for a substring as specified by a string  
   string str4 ( "clearly this perfectly unclear." );  
   cout << "The original string str4 is: " << str4 << endl;  
   basic_string <char>::size_type indexCh4a, indexCh4b;  
  
   string str4a ( "clear" );  
   indexCh4a = str4.find ( str4a , 5 );  
   if ( indexCh4a != string::npos )  
      cout << "The index of the 1st element of 'clear' "  
           << "after\n the 5th position in str4 is: "  
           << indexCh4a << endl;  
   else  
      cout << "The substring 'clear' was not found in str4 ."  
           << endl;  
  
   string str4b ( "clear" );  
   indexCh4b = str4.find ( str4b );  
   if (indexCh4b != string::npos )  
      cout << "The index of the 1st element of 'clear' "  
           << "in str4 is: "  
           << indexCh4b << endl;  
   else  
      cout << "The substring 'clear' was not found in str4 ."  
           << endl << endl;  
}  
```  
  
 **The original string str1 is: Hello Everyone**  
**The index of the 1st 'e' found after the 3rd position in str1 is: 8**  
**The Character 'x' was not found in str1.**  
**The original string str2 is: Let me make this perfectly clear.**  
**The index of the 1st element of 'perfect' after**  
 **the 5th position in str2 is: 17**  
**The substring 'imperfect' was not found in str2 .**  
**The original string str3 is: This is a sample string for this program**  
**The index of the 1st element of sample in str3 is: 10**  
**The index of the next occurrence of 'for' is in str3 begins at: 24**  
**The original string str4 is: clearly this perfectly unclear.**  
**The index of the 1st element of 'clear' after**  
 **the 5th position in str4 is: 25**  
**The index of the 1st element of 'clear' in str4 is: 0**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)   
 [strstr, wcsstr, _mbsstr, _mbsstr_l](../vs140/strstr--wcsstr--_mbsstr--_mbsstr_l.md)