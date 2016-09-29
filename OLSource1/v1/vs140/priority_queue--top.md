---
title: "priority_queue::top"
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
  - "priority_queue::top"
  - "std.priority_queue.top"
  - "Top"
  - "std::priority_queue::top"
  - "priority_queue.top"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "top method"
ms.assetid: f2345dfc-fd43-4dbe-9066-8cbcaa126b9f
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue::top
Returns a const reference to the largest element at the top of the priority_queue.  
  
## Syntax  
  
```  
const_reference top( ) const;  
```  
  
## Return Value  
 A reference to the largest element, as determined by the **Traits** function, object of the priority_queue.  
  
## Remarks  
 The priority_queue must be nonempty to apply the member function.  
  
## Example  
  
```  
// pqueue_top.cpp  
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
 **Header:** <queue\>  
  
 **Namespace:** std  
  
## See Also  
 [priority_queue Class](../vs140/priority_queue-class.md)   
 [priority_queue Functions](../vs140/priority_queue-functions.md)   
 [Standard Template Library](../vs140/standard-template-library.md)