---
title: "basic_string::substr"
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
  - xstring/std::basic_string::substr
  - basic_string.substr
  - std.basic_string.substr
  - basic_string::substr
  - substr
  - std::basic_string::substr
dev_langs: 
  - C++
helpviewer_keywords: 
  - substr method
ms.assetid: a4c081d8-8322-4b85-be56-bc1a35458079
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_string::substr
Copies a substring of at most some number of characters from a string beginning from a specified position.  
  
## Syntax  
  
```  
basic_string<CharType, Traits, Allocator> substr(  
    size_type _Off = 0,  
    size_type _Count = npos  
) const;  
```  
  
#### Parameters  
 `_Off`  
 An index locating the element at the position from which the copy of the string is made, with a default value of 0.  
  
 `_Count`  
 The number of characters that are to be copied if they are present.  
  
## Return Value  
 A substring object that is a copy of elements of the string operand beginning at the position specified by the first argument.  
  
## Example  
  
```  
// basic_string_substr.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   string  str1 ("Heterological paradoxes are persistent.");  
   cout << "The original string str1 is: \n " << str1  
        << endl << endl;  
  
   basic_string <char> str2 = str1.substr ( 6 , 7 );  
   cout << "The substring str1 copied is: " << str2  
        << endl << endl;  
  
   basic_string <char> str3 = str1.substr (  );  
   cout << "The default substring str3 is: \n " << str3  
        <<  "\n which is the entire original string." << endl;  
}  
```  
  
 **The original string str1 is:**   
 **Heterological paradoxes are persistent.**  
**The substring str1 copied is: logical**  
**The default substring str3 is:**   
 **Heterological paradoxes are persistent.**  
 **which is the entire original string.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)