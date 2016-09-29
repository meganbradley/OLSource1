---
title: "queue::pop"
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
  - "std::queue::pop"
  - "pop"
  - "std.queue.pop"
  - "queue.pop"
  - "queue::pop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pop method"
ms.assetid: c1a14d36-1b0f-4342-807e-b2ca479e61ec
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# queue::pop
Removes an element from the front of the queue.  
  
## Syntax  
  
```  
  
void pop( );  
  
```  
  
## Remarks  
 The queue must be nonempty to apply the member function. The top of the queue is the position occupied by the most recently added element and is the last element at the end of the container.  
  
## Example  
  
```  
// queue_pop.cpp  
// compile with: /EHsc  
#include <queue>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   queue <int> q1, s2;  
  
   q1.push( 10 );  
   q1.push( 20 );  
   q1.push( 30 );  
  
   queue <int>::size_type i;  
   i = q1.size( );  
   cout << "The queue length is " << i << "." << endl;  
  
   i = q1.front( );  
   cout << "The element at the front of the queue is "  
        << i << "." << endl;  
  
   q1.pop( );  
  
   i = q1.size( );  
   cout << "After a pop the queue length is "   
        << i << "." << endl;  
  
   i = q1. front ( );  
   cout << "After a pop, the element at the front of the queue is "  
        << i << "." << endl;  
}  
```  
  
 **The queue length is 3.**  
**The element at the front of the queue is 10.**  
**After a pop the queue length is 2.**  
**After a pop, the element at the front of the queue is 20.**   
## Requirements  
 **Header:** \<queue>  
  
 **Namespace:** std  
  
## See Also  
 [queue Class](../vs140/queue-class.md)   
 [queue Functions](../vs140/queue-functions.md)   
 [Standard Template Library](../vs140/standard-template-library.md)