---
title: "operator!= (&lt;queue&gt;)"
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
  - std::!=
  - !=
  - std::operator!=
  - std.operator!=
  - std.!=
  - operator!=
dev_langs: 
  - C++
helpviewer_keywords: 
  - != operator
  - operator!=, queue objects
  - operator !=, queue objects
ms.assetid: 10915bd6-e815-4748-9c9d-f623bcd83f59
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator!= (&lt;queue&gt;)
Tests if the queue object on the left side of the operator is not equal to the queue object on the right side.  
  
## Syntax  
  
```  
  
      bool operator!=(  
   const queue <Type, Container>& _Left,  
   const queue <Type, Container>& _Right,  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type **queue**.  
  
 `_Right`  
 An object of type **queue**.  
  
## Return Value  
 **true** if the queues are not equal; **false** if queues are equal.  
  
## Remarks  
 The comparison between queue objects is based on a pairwise comparison of their elements. Two queues are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
```  
// queue_op_ne.cpp  
// compile with: /EHsc  
#include <queue>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // Declares queues with list base containers  
   queue <int, list<int> > q1, q2, q3;  
  
   // The following line would have caused an error because vector   
   // does not support pop_front( ) and so cannot be adapted  
   // by queue as a base container  
   // queue <int, vector<int> > q1, q2, q3;  
  
   q1.push( 1 );  
   q2.push( 1 );  
   q2.push( 2 );  
   q3.push( 1 );  
  
   if ( q1 != q2 )  
      cout << "The queues q1 and q2 are not equal." << endl;  
   else  
      cout << "The queues q1 and q2 are equal." << endl;  
  
   if ( q1 != q3 )  
      cout << "The queues q1 and q3 are not equal." << endl;  
   else  
      cout << "The queues q1 and q3 are equal." << endl;  
}  
```  
  
 **The queues q1 and q2 are not equal.**  
**The queues q1 and q3 are equal.**   
## Requirements  
 **Header:** <queue\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)