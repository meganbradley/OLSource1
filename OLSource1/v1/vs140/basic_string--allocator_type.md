---
title: "basic_string::allocator_type"
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
  - "std::basic_string::allocator_type"
  - "xstring/std::basic_string::allocator_type"
  - "allocator_type"
  - "std.basic_string.allocator_type"
  - "basic_string::allocator_type"
  - "basic_string.allocator_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocator_type typedef"
ms.assetid: 09216ee1-959c-4125-91f5-6f920f575b43
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::allocator_type
A type that represents the allocator class for a string object.  
  
## Syntax  
  
```  
typedef Allocator allocator_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter **Allocator**.  
  
## Example  
  
```  
// basic_string_allocator_type.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   // The following lines declare objects  
   // that use the default allocator.  
   string s1;  
   basic_string <char>::allocator_type xchar = s1.get_allocator( );  
   // You can now call functions on the allocator class xchar used by s1  
}  
```  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)