---
title: "basic_string::pointer"
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
  - "std.basic_string.pointer"
  - "basic_string::pointer"
  - "basic_string.pointer"
  - "xstring/std::basic_string::pointer"
  - "pointer"
  - "std::basic_string::pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer method"
  - "pointer typedef"
ms.assetid: 447069c1-0a97-437e-bd3f-3254fad3c1dc
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::pointer
A type that provides a pointer to a character element in a string or character array.  
  
## Syntax  
  
```  
typedef typename allocator_type::pointer pointer;  
```  
  
## Remarks  
 The type is a synonym for **allocator_type::pointer**.  
  
 For type **string**, it is equivalent to **char\***.  
  
## Example  
  
```  
// basic_string_pointer.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   basic_string<char>::pointer pstr1a = "In Here";  
   char *cstr1b = "Out There";  
   cout << "The string pstr1a is: " << pstr1a <<  "." << endl;  
   cout << "The C-string cstr1b is: " << cstr1b << "." << endl;  
}  
```  
  
 **The string pstr1a is: In Here.**  
**The C-string cstr1b is: Out There.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)