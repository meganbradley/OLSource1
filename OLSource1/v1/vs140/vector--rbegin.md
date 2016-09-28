---
title: "vector::rbegin"
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
  - "std::vector::rbegin"
  - "std.vector.rbegin"
  - "rbegin"
  - "vector.rbegin"
  - "vector::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: 15678651-44b3-4960-b54a-df3123f2b1de
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::rbegin
Returns an iterator to the first element in a reversed vector.  
  
## Syntax  
  
```  
  
      reverse_iterator rbegin( );   
const_reverse_iterator rbegin( ) const;  
```  
  
## Return Value  
 A reverse random-access iterator addressing the first element in a reversed vector or addressing what had been the last element in the unreversed vector.  
  
## Remarks  
 If the return value of `rbegin` is assigned to a `const_reverse_iterator`, the vector object cannot be modified. If the return value of `rbegin` is assigned to a `reverse_iterator`, the vector object can be modified.  
  
## Example  
  
```  
// vector_rbegin.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   vector <int> v1;  
   vector <int>::iterator v1_Iter;  
   vector <int>::reverse_iterator v1_rIter;  
  
   v1.push_back( 1 );  
   v1.push_back( 2 );  
  
   v1_Iter = v1.begin( );  
   cout << "The first element of vector is "  
        << *v1_Iter << "." << endl;  
  
   v1_rIter = v1.rbegin( );  
   cout << "The first element of the reversed vector is "  
        << *v1_rIter << "." << endl;  
}  
```  
  
 **The first element of vector is 1.**  
**The first element of the reversed vector is 2.**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)