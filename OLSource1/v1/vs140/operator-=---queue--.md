---
title: "operator&lt;= (&lt;queue&gt;)"
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
  - "std::<="
  - "std.operator<="
  - "operator<="
  - "std.<="
  - "std::operator<="
  - "<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<=, queues"
  - "<= operator, with specific objects"
  - "operator <=, queues"
  - "<= operator"
ms.assetid: 305b5e8f-8d1b-413a-8c8a-382afac42c0d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;= (&lt;queue&gt;)
Tests if the queue object on the left side of the operator is less than or equal to the queue object on the right side.  
  
## Syntax  
  
```  
  
      bool operator<=(  
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
 **true** if the queue on the left side of the operator is strictly less than the queue on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between queue objects is based on a pairwise comparison of their elements. The less than or equal to relationship between two queue objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// queue_op_le.cpp  
// compile with: /EHsc  
#include <queue>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   queue <int> q1, q2, q3;  
  
   q1.push( 5 );  
   q1.push( 10 );  
   q2.push( 1 );  
   q2.push( 2 );  
   q3.push( 5 );  
   q3.push( 10 );  
  
   if ( q1 <= q2 )  
      cout << "The queue q1 is less than or equal to "  
           << "the queue q2." << endl;  
   else  
      cout << "The queue q1 is greater than "  
           << "the queue q2." << endl;  
  
   if ( q1 <= q3 )  
      cout << "The queue q1 is less than or equal to "  
           << "the queue q3." << endl;  
   else  
      cout << "The queue q1 is greater than "  
           << "the queue q3." << endl;  
}  
```  
  
 **The queue q1 is greater than the queue q2.**  
**The queue q1 is less than or equal to the queue q3.**   
## Requirements  
 **Header:** \<queue>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)