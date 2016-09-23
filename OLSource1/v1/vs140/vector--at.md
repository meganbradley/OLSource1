---
title: "vector::at"
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
  - std::vector::at
  - at
  - vector::at
  - vector.at
  - std.vector.at
dev_langs: 
  - C++
helpviewer_keywords: 
  - at method
ms.assetid: 46e9fc71-2cf7-4342-b88a-2e30b1c4899a
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# vector::at
Returns a reference to the element at a specified location in the vector.  
  
## Syntax  
  
```  
  
      reference at(  
   size_type _Pos  
);  
const_reference at(  
   size_type _Pos  
) const;  
```  
  
#### Parameters  
 `_Pos`  
 The subscript or position number of the element to reference in the vector.  
  
## Return Value  
 A reference to the element subscripted in the argument. If `_Off` is greater than the size of the vector, **at** throws an exception.  
  
## Remarks  
 If the return value of **at** is assigned to a `const_reference`, the vector object cannot be modified. If the return value of **at** is assigned to a **reference**, the vector object can be modified.  
  
## Example  
  
```  
// vector_at.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   vector <int> v1;  
  
   v1.push_back( 10 );  
   v1.push_back( 20 );  
  
   const int &i = v1.at( 0 );  
   int &j = v1.at( 1 );  
   cout << "The first element is " << i << endl;  
   cout << "The second element is " << j << endl;  
}  
```  
  
 **The first element is 10**  
**The second element is 20**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)