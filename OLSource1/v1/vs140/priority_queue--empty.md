---
title: "priority_queue::empty"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - priority_queue::empty
  - priority_queue.empty
  - std::priority_queue::empty
  - std.priority_queue.empty
  - Empty
dev_langs: 
  - C++
helpviewer_keywords: 
  - empty method
ms.assetid: a551d62d-3569-477e-a629-2d8b8388c4c1
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# priority_queue::empty
Tests if a priority_queue is empty.  
  
## Syntax  
  
```  
  
bool empty( ) const;  
  
```  
  
## Return Value  
 **true** if the priority_queue is empty; **false** if the priority_queue is nonempty.  
  
## Example  
  
```  
// pqueue_empty.cpp  
// compile with: /EHsc  
#include <queue>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // Declares priority_queues with default deque base container  
   priority_queue <int> q1, s2;  
  
   q1.push( 1 );  
  
   if ( q1.empty( ) )  
      cout << "The priority_queue q1 is empty." << endl;  
   else  
      cout << "The priority_queue q1 is not empty." << endl;  
  
   if ( s2.empty( ) )  
      cout << "The priority_queue s2 is empty." << endl;  
   else  
      cout << "The priority_queue s2 is not empty." << endl;  
}  
```  
  
 **The priority_queue q1 is not empty.**  
**The priority_queue s2 is empty.**   
## Requirements  
 **Header:** <queue\>  
  
 **Namespace:** std  
  
## See Also  
 [priority_queue Class](../vs140/priority_queue-class.md)   
 [priority_queue Functions](../vs140/priority_queue-functions.md)   
 [Standard Template Library](../vs140/standard-template-library.md)