---
title: "basic_string::const_pointer"
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
  - "std.basic_string.const_pointer"
  - "xstring/std::basic_string::const_pointer"
  - "basic_string.const_pointer"
  - "std::basic_string::const_pointer"
  - "const_pointer"
  - "basic_string::const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer typedef"
  - "const_pointer method"
ms.assetid: 98a58d6f-d97b-4eb0-b408-5dcf7439cf49
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::const_pointer
A type that provides a pointer to a **const** element in a string.  
  
## Syntax  
  
```  
typedef typename allocator_type::const_pointer const_pointer;  
```  
  
## Remarks  
 The type is a synonym for **allocator_type::const_pointer**.  
  
 For type **string**, it is equivalent to `char`*.  
  
 Pointers that are declared const must be initialized when they are declared. Const pointers always point to the same memory location and may point to constant or nonconstant data.  
  
## Example  
  
```  
// basic_string_const_ptr.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   basic_string<char>::const_pointer pstr1a = "In Here";  
   const char *cstr1c = "Out There";  
  
   cout << "The string pstr1a is: " << pstr1a <<  "." << endl;  
   cout << "The C-string cstr1c is: " << cstr1c << "." << endl;  
}  
```  
  
 **The string pstr1a is: In Here.**  
**The C-string cstr1c is: Out There.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)