---
title: "vector::end"
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
  - std::vector::end
  - std.vector.end
  - end
  - vector::end
  - vector.end
dev_langs: 
  - C++
helpviewer_keywords: 
  - end method
ms.assetid: 6a11275b-81c1-4fb3-a053-b8cf5f5e4bbc
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# vector::end
Returns the past-the-end iterator.  
  
## Syntax  
  
```  
  
      iterator end( );   
const_iterator end( ) const;  
```  
  
## Return Value  
 The past-the-end iterator for the vector. If the vector is empty, `vector::end() == vector::begin()`.  
  
## Remarks  
 If the return value of **end** is assigned to a variable of type `const_iterator`, the vector object cannot be modified. If the return value of **end** is assigned to a variable of type **iterator**, the vector object can be modified.  
  
## Example  
  
```  
// vector_end.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
int main( )  
{  
   using namespace std;  
   vector <int> v1;  
   vector <int>::iterator v1_Iter;  
  
   v1.push_back( 1 );  
   v1.push_back( 2 );  
  
   for ( v1_Iter = v1.begin( ) ; v1_Iter != v1.end( ) ; v1_Iter++ )  
      cout << *v1_Iter << endl;  
}  
```  
  
 **1**  
**2**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)