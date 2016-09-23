---
title: "basic_string::clear"
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
  - clear
  - std::basic_string::clear
  - xstring/std::basic_string::clear
  - basic_string.clear
  - std.basic_string.clear
  - basic_string::clear
  - Clear
dev_langs: 
  - C++
helpviewer_keywords: 
  - clear method
ms.assetid: 87ffb8c0-beb3-4d46-b3f4-b2c516816ea4
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_string::clear
Erases all elements of a string.  
  
## Syntax  
  
```  
void clear( );  
```  
  
## Remarks  
 The string on which the member function is called will be empty.  
  
## Example  
  
```  
// basic_string_clear.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   string  str1 ("Hello world"), str2;  
   basic_string <char>::iterator str_Iter;  
   cout << "The original string str1 is: ";  
   for ( str_Iter = str1.begin( ); str_Iter != str1.end( ); str_Iter++ )  
      cout << *str_Iter;  
   cout << endl;  
  
   str1.clear ( );  
   cout << "The modified string str1 is: ";  
   for ( str_Iter = str1.begin( ); str_Iter != str1.end( ); str_Iter++ )  
      cout << *str_Iter;  
   cout << endl;  
  
   //For an empty string, begin is equivalent to end  
   if ( str1.begin ( ) == str1.end ( ) )  
      cout << "Nothing printed above because "  
           << "the string str1 is empty." << endl;  
   else  
      cout << "The string str1 is not empty." << endl;  
}  
```  
  
 **The original string str1 is: Hello world**  
**The modified string str1 is:**   
**Nothing printed above because the string str1 is empty.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)