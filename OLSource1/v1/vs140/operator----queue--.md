---
title: "operator&gt; (&lt;queue&gt;)"
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
  - "std::operator>"
  - "std.>"
  - "std.operator>"
  - "operator>"
  - "std::>"
  - ">"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator >, queues"
  - "> operator, comparing specific objects"
ms.assetid: 1c44b719-dd25-44a2-83ba-d17b94f81213
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt; (&lt;queue&gt;)
Tests if the queue object on the left side of the operator is greater than the queue object on the right side.  
  
## Syntax  
  
```  
  
      bool operator>(  
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
 The comparison between queue objects is based on a pairwise comparison of their elements. The greater-than relationship between two queue objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// queue_op_gt.cpp  
// compile with: /EHsc  
#include <queue>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   queue <int> q1, q2, q3;  
  
   q1.push( 1 );  
   q1.push( 2 );  
   q1.push( 3 );  
   q2.push( 5 );  
   q2.push( 10 );  
   q3.push( 1 );  
   q3.push( 2 );  
  
   if ( q1 > q2 )  
      cout << "The queue q1 is greater than "  
           << "the queue q2." << endl;  
   else  
      cout << "The queue q1 is not greater than "  
           << "the queue q2." << endl;  
  
   if ( q1> q3 )  
      cout << "The queue q1 is greater than "  
           << "the queue q3." << endl;  
   else  
      cout << "The queue q1 is not greater than "  
           << "the queue q3." << endl;  
}  
```  
  
 **The queue q1 is not greater than the queue q2.**  
**The queue q1 is greater than the queue q3.**   
## Requirements  
 **Header:** <queue\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)