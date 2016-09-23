---
title: "basic_string::find_last_not_of"
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
  - std::basic_string::find_last_not_of
  - find_last_not_of
  - basic_string.find_last_not_of
  - basic_string::find_last_not_of
  - xstring/std::basic_string::find_last_not_of
  - std.basic_string.find_last_not_of
dev_langs: 
  - C++
helpviewer_keywords: 
  - find_last_not_of method
ms.assetid: 2c52054b-097b-4482-a88e-b76145067fa2
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_string::find_last_not_of
Searches through a string for the last character that is not any element of a specified string.  
  
## Syntax  
  
```  
size_type find_last_not_of(  
    value_type _Ch,   
    size_type _Off = npos  
) const;  
size_type find_last_not_of(  
    const value_type* _Ptr,  
    size_type _Off = npos  
) const;  
size_type find_last_not_of(  
    const value_type* _Ptr,   
    size_type _Off,  
    size_type _Count  
) const;  
size_type find_last_not_of(  
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
 The index of the first character of the substring searched for when successful; otherwise `npos`.  
  
## Example  
  
```  
// basic_string_find_last_not_of.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   // The first member function  
   // searches for a single character in a string  
   string str1 ( "dddd-1dd4-abdd" );  
   cout << "The original string str1 is: " << str1 << endl;  
   basic_string <char>::size_type indexCh1a, indexCh1b;  
   static const basic_string <char>::size_type npos = -1;  
  
   indexCh1a = str1.find_last_not_of ( "d" , 7 );  
   if ( indexCh1a != npos )  
      cout << "The index of the last non 'd'\n found before the "  
           << "7th position in str1 is: " << indexCh1a << endl;  
   else  
      cout << "The non 'd' character was not found ." << endl;  
  
   indexCh1b = str1.find_last_not_of  ( "d" );  
   if ( indexCh1b != npos )  
      cout << "The index of the non 'd' found in str1 is: "   
           << indexCh1b << endl << endl;  
   else  
      cout << "The Character 'non x' was not found in str1."  
           << endl << endl;  
  
   // The second member function searches a string  
   // for a substring as specified by a C-string  
   string str2 ( "BBB-1111" );  
   cout << "The original string str2 is: " << str2 << endl;  
   basic_string <char>::size_type indexCh2a, indexCh2b;  
  
   const char *cstr2 = "B1";  
   indexCh2a = str2.find_last_not_of  ( cstr2 , 6 );  
   if ( indexCh2a != npos )  
      cout << "The index of the last occurrence of a "  
           << "element\n not of 'B1' in str2 before the 6th "  
           << "position is: " << indexCh2a << endl;  
   else  
      cout << "Elements not of the substring 'B1' were not "  
           << "\n found in str2 before the 6th position."  
           << endl;  
  
   const char *cstr2b = "B-1";  
   indexCh2b = str2.find_last_not_of  ( cstr2b );  
   if ( indexCh2b != npos )  
      cout << "The index of the last element not "  
           << "in 'B-1'\n is: "  
           << indexCh2b << endl << endl;  
   else  
      cout << "The elements of the substring 'B-1' were "  
           << "not found in str2 ."   
           << endl << endl;  
  
   // The third member function searches a string  
   // for a substring as specified by a C-string  
   string str3 ( "444-555-GGG" );  
   cout << "The original string str3 is: " << str3 << endl;  
   basic_string <char>::size_type indexCh3a, indexCh3b;  
  
   const char *cstr3a = "45G";  
   indexCh3a = str3.find_last_not_of ( cstr3a );  
   if ( indexCh3a != npos )  
      cout << "The index of the last occurrence of an "  
           << "element in str3\n other than one of the "  
           << "characters in '45G' is: " << indexCh3a   
           << endl;  
   else  
      cout << "Elements in str3 contain only characters "  
           << " in the string  '45G'. "  
           << endl;  
  
   const char *cstr3b = "45G";  
   indexCh3b = str3.find_last_not_of ( cstr3b , 6 , indexCh3a - 1 );  
   if (indexCh3b != npos )  
      cout << "The index of the penultimate occurrence of an "  
           << "element\n not in '45G' in str3 is: "  
           << indexCh3b << endl << endl;  
   else  
      cout << "Elements in str3 contain only characters "  
           << " in the string '45G'. "  
           << endl  << endl;  
  
   // The fourth member function searches a string  
   // for a substring as specified by a string  
   string str4 ( "12-ab-12-ab" );  
   cout << "The original string str4 is: " << str4 << endl;  
   basic_string <char>::size_type indexCh4a, indexCh4b;  
  
   string str4a ( "b-a" );  
   indexCh4a = str4.find_last_not_of  ( str4a , 5 );  
   if ( indexCh4a != npos )  
      cout << "The index of the last occurrence of an "  
           << "element not\n in 'b-a' in str4 before the 5th "  
           << "position is: " << indexCh4a << endl;  
   else  
      cout << "Elements other than those in the substring"  
           << " 'b-a' were not found in the string str4."  
           << endl;  
  
   string str4b ( "12" );  
   indexCh4b = str4.find_last_not_of ( str4b  );  
   if ( indexCh4b != npos )  
      cout << "The index of the last occurrence of an "  
           << "element not in '12'\n in str4 before the end "  
           << "position is: " << indexCh4b << endl;  
   else  
      cout << "Elements other than those in the substring"  
           << " '12'\n were not found in the string str4."  
           << endl;  
}  
```  
  
 **The original string str1 is: dddd-1dd4-abdd**  
**The index of the last non 'd'**  
 **found before the 7th position in str1 is: 5**  
**The index of the non 'd' found in str1 is: 11**  
**The original string str2 is: BBB-1111**  
**The index of the last occurrence of a element**  
 **not of 'B1' in str2 before the 6th position is: 3**  
**The elements of the substring 'B-1' were not found in str2 .**  
**The original string str3 is: 444-555-GGG**  
**The index of the last occurrence of an element in str3**  
 **other than one of the characters in '45G' is: 7**  
**The index of the penultimate occurrence of an element**  
 **not in '45G' in str3 is: 3**  
**The original string str4 is: 12-ab-12-ab**  
**The index of the last occurrence of an element not**  
 **in 'b-a' in str4 before the 5th position is: 1**  
**The index of the last occurrence of an element not in '12'**  
 **in str4 before the end position is: 10**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)