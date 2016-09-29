---
title: "priority_queue::pop"
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
  - "pop"
  - "std::priority_queue::pop"
  - "priority_queue.pop"
  - "priority_queue::pop"
  - "std.priority_queue.pop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pop method"
ms.assetid: 07f96fb8-d838-4321-9342-96daa3e130cf
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# priority_queue::pop
Removes the largest element of the priority_queue from the top position.  
  
## Syntax  
  
```  
  
void pop( );  
  
```  
  
## Remarks  
 The priority_queue must be nonempty to apply the member function. The top of the priority_queue is always occupied by the largest element in the container.  
  
## Example  
  
```  
// pqueue_pop.cpp  
// compile with: /EHsc  
#include <queue>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   priority_queue <int> q1, s2;  
  
   q1.push( 10 );  
   q1.push( 20 );  
   q1.push( 30 );  
  
   priority_queue <int>::size_type i, iii;  
   i = q1.size( );  
   cout << "The priority_queue length is " << i << "." << endl;  
  
   const int& ii = q1.top( );  
   cout << "The element at the top of the priority_queue is "  
        << ii << "." << endl;  
  
   q1.pop( );  
  
   iii = q1.size( );  
   cout << "After a pop, the priority_queue length is "   
        << iii << "." << endl;  
  
   const int& iv = q1.top( );  
   cout << "After a pop, the element at the top of the "  
        << "priority_queue is " << iv << "." << endl;  
}  
```  
  
 **The priority_queue length is 3.**  
**The element at the top of the priority_queue is 30.**  
**After a pop, the priority_queue length is 2.**  
**After a pop, the element at the top of the priority_queue is 20.**   
## Requirements  
 **Header:** <queue\>  
  
 **Namespace:** std  
  
## See Also  
 [priority_queue Class](../vs140/priority_queue-class.md)   
 [priority_queue Functions](../vs140/priority_queue-functions.md)   
 [Standard Template Library](../vs140/standard-template-library.md)