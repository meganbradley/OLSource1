---
title: "basic_string::find_last_of"
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
  - "find_last_of"
  - "std.basic_string.find_last_of"
  - "basic_string::find_last_of"
  - "xstring/std::basic_string::find_last_of"
  - "basic_string.find_last_of"
  - "std::basic_string::find_last_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find_last_of method"
ms.assetid: a642d9fe-c036-4fd2-b6ed-b593e7c238dd
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::find_last_of
Searches through a string for the last character that matches any element of a specified string.  
  
## Syntax  
  
```  
size_type find_last_of(  
    value_type _Ch,   
    size_type _Off = npos  
) const;  
  
size_type find_last_of(  
    const value_type* _Ptr,  
    size_type _Off = npos  
) const;  
  
size_type find_last_of(  
    const value_type* _Ptr,   
    size_type _Off,  
    size_type _Count  
) const;  
  
size_type find_last_of(  
    const basic_string<CharType, Traits, Allocator>& _Str,  
    size_type _Off = npos  
) const;  
```  
  
#### Parameters  
 `_Ch`  
 The character value for which the member function is to search.  
  
 `_Off`  
 Index of the position at which the search is to finish.  
  
 `_Ptr`  
 The C-string for which the member function is to search.  
  
 `_Count`  
 The number of characters, counting forward from the first character, in the C-string for which the member function is to search.  
  
 `_Str`  
 The string for which the member function is to search.  
  
## Return Value  
 The index of the last character of the substring searched for when successful; otherwise `npos`.  
  
## Example  
  
```  
// basic_string_find_last_of.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // The first member function  
   // searches for a single character in a string  
   string str1 ( "abcd-1234-abcd-1234" );  
   cout << "The original string str1 is: " << str1 << endl;  
   basic_string <char>::size_type indexCh1a, indexCh1b;  
   static const basic_string <char>::size_type npos = -1;  
  
   indexCh1a = str1.find_last_of ( "d" , 14 );  
   if ( indexCh1a != npos )  
      cout << "The index of the last 'd' found before the 14th"  
           << " position in str1 is: " << indexCh1a << endl;  
   else  
      cout << "The character 'd' was not found in str1 ." << endl;  
  
   indexCh1b = str1.find_first_of ( "x" );  
   if ( indexCh1b != npos )  
      cout << "The index of the 'x' found in str1 is: "  
           << indexCh1b << endl << endl;  
   else  
      cout << "The character 'x' was not found in str1."  
           << endl << endl;  
  
   // The second member function searches a string  
   // for a substring as specified by a C-string  
   string str2 ( "ABCD-1234-ABCD-1234" );  
   cout << "The original string str2 is: " << str2 << endl;  
   basic_string <char>::size_type indexCh2a, indexCh2b;  
  
   const char *cstr2 = "B1";  
   indexCh2a = str2.find_last_of  ( cstr2 , 12 );  
   if (indexCh2a != npos )  
      cout << "The index of the last occurrence of an "  
           << "element of 'B1' in str2 before\n the 12th "  
           << "position is: " << indexCh2a << endl;  
   else  
      cout << "Elements of the substring 'B1' were not "  
           << "found in str2 before the 12th position."  
           << endl;  
  
   const char *cstr2b = "D2";  
   indexCh2b = str2.find_last_of  ( cstr2b );  
   if ( indexCh2b != npos )  
      cout << "The index of the last element of 'D2' "  
           << "after\n the 0th position in str2 is: "  
           << indexCh2b << endl << endl;  
   else  
      cout << "The substring 'D2' was not found in str2 ."  
           << endl << endl << endl;  
  
   // The third member function searches a string  
   // for a substring as specified by a C-string  
   string str3 ( "456-EFG-456-EFG" );  
   cout << "The original string str3 is: " << str3 << endl;  
   basic_string <char>::size_type indexCh3a;  
  
   const char *cstr3a = "5E";  
   indexCh3a = str3.find_last_of ( cstr3a , 8 , 8 );  
   if ( indexCh3a != npos )  
      cout << "The index of the last occurrence of an "  
           << "element of '5E' in str3 before\n the 8th "  
           << "position is: " << indexCh3a << endl << endl;  
   else  
      cout << "Elements of the substring '5G' were not "  
           << "found in str3\n before the 8th position."  
           << endl << endl;  
  
   // The fourth member function searches a string  
   // for a substring as specified by a string  
   string str4 ( "12-ab-12-ab" );  
   cout << "The original string str4 is: " << str4 << endl;  
   basic_string <char>::size_type indexCh4a, indexCh4b;  
  
   string str4a ( "ba3" );  
   indexCh4a = str4.find_last_of  ( str4a , 8 );  
   if ( indexCh4a != npos )  
      cout << "The index of the last occurrence of an "  
           << "element of 'ba3' in str4 before\n the 8th "  
           << "position is: " << indexCh4a << endl;  
   else  
      cout << "Elements of the substring 'ba3' were not "  
           << "found in str4\n after the 0th position."  
           << endl;  
  
   string str4b ( "a2" );  
   indexCh4b = str4.find_last_of ( str4b  );  
   if ( indexCh4b != npos )  
      cout << "The index of the last occurrence of an "  
           << "element of 'a2' in str4 before\n the 0th "  
           << "position is: " << indexCh4b << endl;  
   else  
      cout << "Elements of the substring 'a2' were not "  
           << "found in str4\n after the 0th position."  
           << endl;  
}  
```  
  
 **The original string str1 is: abcd-1234-abcd-1234**  
**The index of the last 'd' found before the 14th position in str1 is: 13**  
**The character 'x' was not found in str1.**  
**The original string str2 is: ABCD-1234-ABCD-1234**  
**The index of the last occurrence of an element of 'B1' in str2 before**  
 **the 12th position is: 11**  
**The index of the last element of 'D2' after**  
 **the 0th position in str2 is: 16**  
**The original string str3 is: 456-EFG-456-EFG**  
**The index of the last occurrence of an element of '5E' in str3 before**  
 **the 8th position is: 4**  
**The original string str4 is: 12-ab-12-ab**  
**The index of the last occurrence of an element of 'ba3' in str4 before**  
 **the 8th position is: 4**  
**The index of the last occurrence of an element of 'a2' in str4 before**  
 **the 0th position is: 9**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)