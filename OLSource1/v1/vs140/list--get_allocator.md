---
title: "list::get_allocator"
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
  - "list/std::list::get_allocator"
  - "std.list.get_allocator"
  - "std::list::get_allocator"
  - "get_allocator"
  - "list.get_allocator"
  - "list::get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: fc21c988-7193-46cf-821d-ec97012332c4
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::get_allocator
Returns a copy of the allocator object used to construct a list.  
  
## Syntax  
  
```  
  
Allocator get  
_  
allocator( ) const;  
  
```  
  
## Return Value  
 The allocator used by the list.  
  
## Remarks  
 Allocators for the list class specify how the class manages storage. The default allocators supplied with STL container classes are sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
## Example  
  
```  
// list_get_allocator.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   // The following lines declare objects   
   // that use the default allocator.  
   list <int> c1;  
   list <int, allocator<int> > c2 = list <int, allocator<int> >( allocator<int>( ) );  
  
   // c3 will use the same allocator class as c1  
   list <int> c3( c1.get_allocator( ) );  
  
   list<int>::allocator_type xlst = c1.get_allocator( );  
   // You can now call functions on the allocator class used by c1  
}  
```  
  
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)