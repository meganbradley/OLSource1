---
title: "basic_string::get_allocator"
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
  - "get_allocator"
  - "std.basic_string.get_allocator"
  - "basic_string.get_allocator"
  - "basic_string::get_allocator"
  - "std::basic_string::get_allocator"
  - "xstring/std::basic_string::get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: 9c292a69-8650-4ff6-85af-193679ee3cb4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::get_allocator
Returns a copy of the allocator object used to construct the string.  
  
## Syntax  
  
```  
allocator_type get_allocator( ) const;  
```  
  
## Return Value  
 The allocator used by the string.  
  
## Remarks  
 The member function returns the stored allocator object.  
  
 Allocators for the string class specify how the class manages storage. The default allocators supplied with container classes are sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
## Example  
  
```  
// basic_string_get_allocator.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   // The following lines declare objects  
   // that use the default allocator.  
   string s1;  
   basic_string <char> s2;  
   basic_string <char, char_traits< char >, allocator< char > > s3;  
  
   // s4 will use the same allocator class as s1  
   basic_string <char> s4( s1.get_allocator ( ) );  
  
   basic_string <char>::allocator_type xchar = s1.get_allocator( );  
   // You can now call functions on the allocator class xchar used by s1  
}  
```  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)