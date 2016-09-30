---
title: "vector::rend"
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
  - "rend"
  - "vector.rend"
  - "std::vector::rend"
  - "std.vector.rend"
  - "vector::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 7df7e1d7-6319-4bd8-bd3c-0da0e76784d6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::rend
Returns an iterator that addresses the location succeeding the last element in a reversed vector.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rend( ) const;   
reverse_iterator rend( );  
```  
  
## Return Value  
 A reverse random-access iterator that addresses the location succeeding the last element in a reversed vector (the location that had preceded the first element in the unreversed vector).  
  
## Remarks  
 `rend` is used with a reversed vector just as [end](../vs140/vector--end.md) is used with a vector.  
  
 If the return value of `rend` is assigned to a `const_reverse_iterator`, then the vector object cannot be modified. If the return value of `rend` is assigned to a `reverse_iterator`, then the vector object can be modified.  
  
 `rend` can be used to test to whether a reverse iterator has reached the end of its vector.  
  
 The value returned by `rend` should not be dereferenced.  
  
## Example  
  
```  
// vector_rend.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   vector <int> v1;  
   vector <int>::reverse_iterator v1_rIter;  
  
   v1.push_back( 1 );  
   v1.push_back( 2 );  
  
   for ( v1_rIter = v1.rbegin( ) ; v1_rIter != v1.rend( ) ; v1_rIter++ )  
      cout << *v1_rIter << endl;  
}  
```  
  
 **2**  
**1**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)