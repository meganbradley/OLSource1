---
title: "vector::crbegin"
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
  - "vector.crbegin"
  - "std.vector.crbegin"
  - "std::vector::crbegin"
  - "crbegin"
  - "vector::crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method"
ms.assetid: 1c8145cf-b4dc-4189-ab56-3894655085fd
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::crbegin
Returns a const iterator to the first element in a reversed vector.  
  
## Syntax  
  
```  
const_reverse_iterator crbegin( ) const;  
```  
  
## Return Value  
 A const reverse random-access iterator addressing the first element in a reversed [vector](../vs140/vector-class.md) or addressing what had been the last element in the unreversed `vector`.  
  
## Remarks  
 With the return value of `crbegin`, the `vector` object cannot be modified.  
  
## Example  
  
```  
// vector_crbegin.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   vector <int> v1;  
   vector <int>::iterator v1_Iter;  
   vector <int>::const_reverse_iterator v1_rIter;  
  
   v1.push_back( 1 );  
   v1.push_back( 2 );  
  
   v1_Iter = v1.begin( );  
   cout << "The first element of vector is "  
        << *v1_Iter << "." << endl;  
  
   v1_rIter = v1.crbegin( );  
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