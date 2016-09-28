---
title: "basic_string::end"
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
  - "xstring/std::basic_string::end"
  - "std::basic_string::end"
  - "basic_string.end"
  - "end"
  - "std.basic_string.end"
  - "basic_string::end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end method"
ms.assetid: 8a40e6ac-99b8-4a3a-83de-fffb05215e04
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::end
Returns an iterator that addresses the location succeeding the last element in a string.  
  
## Syntax  
  
```  
const_iterator end( ) const;  
iterator end( );  
```  
  
## Return Value  
 Returns a random-access iterator that addresses the location succeeding the last element in a string.  
  
## Remarks  
 **end** is often used to test whether an iterator has reached the end of its string. The value returned by **end** should not be dereferenced.  
  
 If the return value of **end** is assigned to a `const_iterator`, the string object cannot be modified. If the return value of **end** is assigned to an **iterator**, the string object can be modified.  
  
## Example  
  
```  
// basic_string_end.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   string str1 ( "No way out." ), str2;  
   basic_string <char>::iterator str_Iter, str1_Iter, str2_Iter;  
   basic_string <char>::const_iterator str1_cIter;  
  
   str1_Iter = str1.end ( );  
   str1_Iter--;  
   str1_Iter--;  
   cout << "The last character-letter of the string str1 is: " << *str1_Iter << endl;  
   cout << "The full orginal string str1 is: " << str1 << endl;  
  
   // end used to test when an iterator has reached the end of its string  
   cout << "The string is now: ";  
   for ( str_Iter = str1.begin( ); str_Iter != str1.end( ); str_Iter++ )  
      cout << *str_Iter;  
   cout << endl;  
  
   // The dereferenced iterator can be used to modify a character  
    *str1_Iter = 'T';  
   cout << "The last character-letter of the modified str1 is now: "  
        << *str1_Iter << endl;  
   cout << "The modified string str1 is now: " << str1 << endl;  
  
   // The following line would be an error because iterator is const  
   // *str1_cIter = 'T';  
  
   // For an empty string, end is equivalent to begin  
   if ( str2.begin( ) == str2.end ( ) )  
      cout << "The string str2 is empty." << endl;  
   else  
      cout << "The stringstr2  is not empty." << endl;  
}  
```  
  
 **The last character-letter of the string str1 is: t**  
**The full orginal string str1 is: No way out.**  
**The string is now: No way out.**  
**The last character-letter of the modified str1 is now: T**  
**The modified string str1 is now: No way ouT.**  
**The string str2 is empty.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)