---
title: "operator!= (&lt;vector&gt;)"
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
  - std::!=
  - !=
  - std::operator!=
  - std.operator!=
  - std.!=
  - operator!=
dev_langs: 
  - C++
helpviewer_keywords: 
  - != operator
  - operator !=, comparing objects
  - operator!=, comparing objects
ms.assetid: 80853025-d908-469e-a752-7f9ad285e18f
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator!= (&lt;vector&gt;)
Tests if the object on the left side of the operator is not equal to the object on the right side.  
  
## Syntax  
  
```  
  
      bool operator!=(  
   const vector<Type, Allocator>& _Left,  
   const vector<Type, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type **vector**.  
  
 `_Right`  
 An object of type **vector**.  
  
## Return Value  
 **true** if the vectors are not equal; **false** if the vectors are equal.  
  
## Remarks  
 Two vectors are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
```  
// vector_op_ne.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;   
  
   vector <int> v1, v2;  
   v1.push_back( 1 );  
     v2.push_back( 2 );  
  
   if ( v1 != v2 )  
      cout << "Vectors not equal." << endl;  
   else  
      cout << "Vectors equal." << endl;  
}  
```  
  
 **Vectors not equal.**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)