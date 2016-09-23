---
title: "deque::crend"
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
  - deque.crend
  - std.deque.crend
  - deque/std::deque::crend
  - crend
  - deque::crend
  - std::deque::crend
dev_langs: 
  - C++
helpviewer_keywords: 
  - crend method, deque class
  - crend method
ms.assetid: 75c4377c-ae59-41ba-87c5-b2b1a002d159
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# deque::crend
Returns a const iterator that addresses the location succeeding the last element in a reversed deque.  
  
## Syntax  
  
```  
const_reverse_iterator crend( ) const;  
```  
  
## Return Value  
 A const reverse random-access iterator that addresses the location succeeding the last element in a reversed [deque](../vs140/deque-class.md) (the location that had preceded the first element in the unreversed deque).  
  
## Remarks  
 `crend` is used with a reversed `deque` just as [cend](../vs140/array--cend.md) is used with a `deque`.  
  
 With the return value of `crend` (suitably decremented), the `deque` object cannot be modified.  
  
 `crend` can be used to test to whether a reverse iterator has reached the end of its deque.  
  
 The value returned by `crend` should not be dereferenced.  
  
## Example  
  
```  
// deque_crend.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   deque <int> v1;  
   deque <int>::const_reverse_iterator v1_rIter;  
  
   v1.push_back( 1 );  
   v1.push_back( 2 );  
  
   for ( v1_rIter = v1.rbegin( ) ; v1_rIter != v1.rend( ) ; v1_rIter++ )  
      cout << *v1_rIter << endl;  
}  
```  
  
 **2**  
**1**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)