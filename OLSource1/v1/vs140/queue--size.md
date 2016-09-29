---
title: "queue::size"
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
  - "size"
  - "queue.size"
  - "std::queue::size"
  - "queue::size"
  - "std.queue.size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method"
ms.assetid: 8a5d122f-8948-40c0-9127-37ba1714a374
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# queue::size
Returns the number of elements in the queue.  
  
## Syntax  
  
```  
  
size_type size( ) const;  
  
```  
  
## Return Value  
 The current length of the queue.  
  
## Example  
  
```  
// queue_size.cpp  
// compile with: /EHsc  
#include <queue>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   queue <int> q1, q2;  
   queue <int>::size_type i;  
  
   q1.push( 1 );  
   i = q1.size( );  
   cout << "The queue length is " << i << "." << endl;  
  
   q1.push( 2 );  
   i = q1.size( );  
   cout << "The queue length is now " << i << "." << endl;  
}  
```  
  
 **The queue length is 1.**  
**The queue length is now 2.**   
## Requirements  
 **Header:** <queue\>  
  
 **Namespace:** std  
  
## See Also  
 [queue Class](../vs140/queue-class.md)   
 [queue Functions](../vs140/queue-functions.md)   
 [Standard Template Library](../vs140/standard-template-library.md)