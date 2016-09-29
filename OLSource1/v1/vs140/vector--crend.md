---
title: "vector::crend"
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
  - "vector.crend"
  - "std.vector.crend"
  - "crend"
  - "std::vector::crend"
  - "vector::crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method"
ms.assetid: d71945d6-63de-49f1-a3b1-cd004b5b117e
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::crend
Returns a const iterator that addresses the location succeeding the last element in a reversed vector.  
  
## Syntax  
  
```  
const_reverse_iterator crend( ) const;  
```  
  
## Return Value  
 A const reverse random-access iterator that addresses the location succeeding the last element in a reversed [vector](../vs140/vector-class.md) (the location that had preceded the first element in the unreversed `vector`).  
  
## Remarks  
 `crend` is used with a reversed `vector` just as [cend](../vs140/vector--cend.md) is used with a `vector`.  
  
 With the return value of `crend` (suitably decremented), the `vector` object cannot be modified.  
  
 `crend` can be used to test to whether a reverse iterator has reached the end of its `vector`.  
  
 The value returned by `crend` should not be dereferenced.  
  
## Example  
  
```  
// vector_crend.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   vector <int> v1;  
   vector <int>::const_reverse_iterator v1_rIter;  
  
   v1.push_back( 1 );  
   v1.push_back( 2 );  
  
   for ( v1_rIter = v1.rbegin( ) ; v1_rIter != v1.rend( ) ; v1_rIter++ )  
      cout << *v1_rIter << endl;  
}  
```  
  
 **2**  
**1**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)