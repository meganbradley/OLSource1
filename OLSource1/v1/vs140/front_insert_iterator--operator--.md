---
title: "front_insert_iterator::operator++"
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
  - "operator++"
  - "front_insert_iterator::operator++"
  - "std.front_insert_iterator.operator++"
  - "std::front_insert_iterator::operator++"
  - "iterator/std::front_insert_iterator::operator++"
  - "++"
  - "front_insert_iterator.operator++"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "++ operator"
  - "operator++"
  - "++ operator, with specific objects"
ms.assetid: c1af4789-39c8-4834-84c3-7775b19acc9a
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# front_insert_iterator::operator++
Increments the `back_insert_iterator` to the next location into which a value may be stored.  
  
## Syntax  
  
```  
front_insert_iterator<Container>& operator++( );  
front_insert_iterator<Container> operator++( int );  
```  
  
## Return Value  
 A `front_insert_iterator` addressing the next location into which a value may be stored.  
  
## Remarks  
 Both preincrementation and postincrementation operators return the same result.  
  
## Example  
  
```  
// front_insert_iterator_op_incre.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   list<int> L1;  
   front_insert_iterator<list<int> > iter ( L1 );  
   *iter = 10;  
   iter++;  
   *iter = 20;  
   iter++;  
   *iter = 30;  
   iter++;  
  
   list <int>::iterator vIter;  
   cout << "The list L1 is: ( ";  
   for ( vIter = L1.begin ( ) ; vIter != L1.end ( ); vIter++ )  
      cout << *vIter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The list L1 is: ( 30 20 10 ).**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [front_insert_iterator Class](../vs140/front_insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)