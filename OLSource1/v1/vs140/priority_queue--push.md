---
title: "priority_queue::push"
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
  - "push"
  - "std::priority_queue::push"
  - "priority_queue.push"
  - "std.priority_queue.push"
  - "priority_queue::push"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push method"
ms.assetid: a938ff06-6891-4a01-bc39-8d557d1349bc
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue::push
Adds an element to the priority queue based on the priority of the element from operator<.  
  
## Syntax  
  
```  
  
      void push(  
   const Type& _Val  
);  
```  
  
#### Parameters  
 `_Val`  
 The element added to the top of the priority_queue.  
  
## Remarks  
 The top of the priority_queue is the position occupied by the largest element in the container.  
  
## Example  
  
```  
// pqueue_push.cpp  
// compile with: /EHsc  
#include <queue>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   priority_queue<int> q1;  
  
   q1.push( 10 );  
   q1.push( 30 );  
   q1.push( 20 );  
  
   priority_queue<int>::size_type i;  
   i = q1.size( );  
   cout << "The priority_queue length is " << i << "." << endl;  
  
   const int& ii = q1.top( );  
   cout << "The element at the top of the priority_queue is "  
        << ii << "." << endl;  
}  
```  
  
 **The priority_queue length is 3.**  
**The element at the top of the priority_queue is 30.**   
## Requirements  
 **Header:** \<queue>  
  
 **Namespace:** std  
  
## See Also  
 [priority_queue Class](../vs140/priority_queue-class.md)   
 [priority_queue Functions](../vs140/priority_queue-functions.md)   
 [Standard Template Library](../vs140/standard-template-library.md)