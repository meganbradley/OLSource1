---
title: "queue::queue"
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
  - "queue::queue"
  - "queue.queue"
  - "std::queue::queue"
  - "std.queue.queue"
  - "queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "queue class, constructor"
  - "queue method"
ms.assetid: 86e62476-c2ca-4460-abdc-f9fc5f61e83b
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# queue::queue
Constructs a queue that is empty or that is a copy of a base container object.  
  
## Syntax  
  
```  
  
      queue( );   
explicit queue(  
   const container_type& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The **const** container of which the constructed queue is to be a copy.  
  
## Remarks  
 The default base container for queue is deque. You can also specify list as a base container, but you cannot specify vector, because it lacks the required `pop_front` member function.  
  
## Example  
  
```  
// queue_queue.cpp  
// compile with: /EHsc  
#include <queue>  
#include <vector>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // Declares queue with default deque base container  
   queue <char> q1;  
  
   // Explicitly declares a queue with deque base container  
   queue <char, deque<char> > q2;  
  
   // These lines don't cause an error, even though they  
   // declares a queue with a vector base container  
   queue <int, vector<int> > q3;  
   q3.push( 10 );  
   // but the following would cause an error because vector has   
   // no pop_front member function  
   // q3.pop( );  
  
   // Declares a queue with list base container  
   queue <int, list<int> > q4;  
  
   // The second member function copies elements from a container  
   list<int> li1;  
   li1.push_back( 1 );  
   li1.push_back( 2 );  
   queue <int, list<int> > q5( li1 );  
   cout << "The element at the front of queue q5 is "  
        << q5.front( ) << "." << endl;  
   cout << "The element at the back of queue q5 is "  
        << q5.back( ) << "." << endl;  
}  
```  
  
 **The element at the front of queue q5 is 1.**  
**The element at the back of queue q5 is 2.**   
## Requirements  
 **Header:** <queue\>  
  
 **Namespace:** std  
  
## See Also  
 [queue Class](../vs140/queue-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)