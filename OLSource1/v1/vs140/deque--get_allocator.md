---
title: "deque::get_allocator"
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
  - "std::deque::get_allocator"
  - "deque/std::deque::get_allocator"
  - "deque::get_allocator"
  - "get_allocator"
  - "deque.get_allocator"
  - "std.deque.get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: 7af21772-458b-4bca-91fd-0de36cf26e32
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# deque::get_allocator
Returns a copy of the allocator object used to construct the deque.  
  
## Syntax  
  
```  
  
Allocator get_allocator( ) const;  
  
```  
  
## Return Value  
 The allocator used by the deque.  
  
## Remarks  
 Allocators for the deque class specify how the class manages storage. The default allocators supplied with STL container classes are sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
## Example  
  
```  
// deque_get_allocator.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   // The following lines declare objects that use the default allocator.  
   deque <int> c1;  
   deque <int, allocator<int> > c2 = deque <int, allocator<int> >( allocator<int>( ) );  
  
   // c3 will use the same allocator class as c1  
   deque <int> c3( c1.get_allocator( ) );  
  
   deque <int>::allocator_type xlst = c1.get_allocator( );  
   // You can now call functions on the allocator class used by c1  
}  
```  
  
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)