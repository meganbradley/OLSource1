---
title: "basic_string::swap"
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
  - "basic_string.swap"
  - "xstring/std::basic_string::swap"
  - "std::basic_string::swap"
  - "swap"
  - "std.basic_string.swap"
  - "basic_string::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 94d726c3-b308-4470-9c84-6d723549c88e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::swap
Exchange the contents of two strings.  
  
## Syntax  
  
```  
void swap(  
    basic_string<CharType, Traits, Allocator>& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 The source string whose elements are to be exchanged with those in the destination string.  
  
## Remarks  
 If the strings being swapped have the same allocator object, the `swap` member function:  
  
-   Occurs in constant time.  
  
-   Throws no exceptions.  
  
-   Invalidates no references, pointers, or iterators that designate elements in the two strings.  
  
 Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
## Example  
  
```  
// basic_string_swap.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   // Declaring an objects of type basic_string<char>  
   string s1 ( "Tweedledee" );  
   string s2 ( "Tweedledum" );  
   cout << "Before swapping string s1 and s2:" << endl;  
   cout << " The basic_string s1 = " << s1 << "." << endl;  
   cout << " The basic_string s2 = " << s2 << "." << endl;  
  
   s1.swap ( s2 );  
   cout << "After swapping string s1 and s2:" << endl;  
   cout << " The basic_string s1 = " << s1 << "." << endl;  
   cout << " The basic_string s2 = " << s2 << "." << endl;  
}  
```  
  
 **Before swapping string s1 and s2:**  
 **The basic_string s1 = Tweedledee.**  
 **The basic_string s2 = Tweedledum.**  
**After swapping string s1 and s2:**  
 **The basic_string s1 = Tweedledum.**  
 **The basic_string s2 = Tweedledee.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)