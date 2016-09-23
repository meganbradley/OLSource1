---
title: "swap (C++ STL &lt;string&gt;)"
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
  - std.swap
  - std::swap
  - string/std::swap
  - swap
dev_langs: 
  - C++
helpviewer_keywords: 
  - swap function
ms.assetid: 59987630-1135-4bd9-a0f3-b79c93432c45
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# swap (C++ STL &lt;string&gt;)
Exchanges the arrays of characters of two strings.  
  
## Syntax  
  
```  
  
   template<class Traits, class Allocator>  
void swap(  
   basic_string<CharType, Traits, Allocator>& _Left,  
   basic_string<CharType, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 One string whose elements are to be swapped with those of another string.  
  
 `_Right`  
 The other string whose elements are to be swapped with the first string.  
  
## Remarks  
 The template function executes the specialized member function _*Left*.[swap](../vs140/basic_string--swap.md)(\_*Right*) for strings, which guarantees constant complexity.  
  
## Example  
  
```  
// string_swap.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   // Declaring an object of type basic_string<char>  
   string s1 ( "Tweedledee" );  
   string s2 ( "Tweedledum" );  
   cout << "Before swapping string s1 and s2:" << endl;  
   cout << "The basic_string s1 = " << s1 << "." << endl;  
   cout << "The basic_string s2 = " << s2 << "." << endl;  
  
   swap ( s1 , s2 );  
   cout << "\nAfter swapping string s1 and s2:" << endl;  
   cout << "The basic_string s1 = " << s1 << "." << endl;  
   cout << "The basic_string s2 = " << s2 << "." << endl;  
}  
```  
  
 **Before swapping string s1 and s2:**  
**The basic_string s1 = Tweedledee.**  
**The basic_string s2 = Tweedledum.**  
**After swapping string s1 and s2:**  
**The basic_string s1 = Tweedledum.**  
**The basic_string s2 = Tweedledee.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std