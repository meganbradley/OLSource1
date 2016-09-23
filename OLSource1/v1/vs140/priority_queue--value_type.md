---
title: "priority_queue::value_type"
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
  - priority_queue::value_type
  - priority_queue.value_type
  - std::priority_queue::value_type
  - std.priority_queue.value_type
  - value_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - value_type typedef
ms.assetid: a41cd4f9-8e70-4748-8c86-7fa7967653b4
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# priority_queue::value_type
A type that represents the type of object stored as an element in a priority_queue.  
  
## Syntax  
  
```  
typedef typename Container::value_type value_type;  
```  
  
## Remarks  
 The type is a synonym for the `value_type` of the base container adapted by the priority_queue.  
  
## Example  
  
```  
// pqueue_value_type.cpp  
// compile with: /EHsc  
#include <queue>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // Declares priority_queues with default deque base container  
   priority_queue<int>::value_type AnInt;  
  
   AnInt = 69;  
   cout << "The value_type is AnInt = " << AnInt << endl;  
  
   priority_queue<int> q1;  
   q1.push( AnInt );  
   cout << "The element at the top of the priority_queue is "  
        << q1.top( ) << "." << endl;  
}  
```  
  
 **The value_type is AnInt = 69**  
**The element at the top of the priority_queue is 69.**   
## Requirements  
 **Header:** <queue\>  
  
 **Namespace:** std  
  
## See Also  
 [priority_queue Class](../vs140/priority_queue-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)