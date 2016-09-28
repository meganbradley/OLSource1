---
title: "operator&gt;= (&lt;vector&gt;)"
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
  - "operator>="
  - "std::>="
  - "std.operator>="
  - ">="
  - "std.>="
  - "std::operator>="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - ">= operator, comparing specific objects"
  - "operator>=, comparing objects"
  - "operator >="
  - "operator >=, comparing objects"
  - "operator>="
ms.assetid: 376d256f-3563-432f-9f37-0356e00631c6
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;= (&lt;vector&gt;)
Tests if the object on the left side of the operator is greater than or equal to the object on the right side.  
  
## Syntax  
  
```  
  
      bool operator>=(  
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
 **true** if the vector on the left side of the operator is greater than or equal to the vector on the right side of the vector; otherwise **false**.  
  
## Example  
  
```  
// vector_op_ge.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;   
  
   vector <int> v1, v2;  
   v1.push_back( 1 );  
   v1.push_back( 3 );  
   v1.push_back( 1 );  
  
     v2.push_back( 1 );  
   v2.push_back( 2 );  
   v2.push_back( 2 );  
  
   if ( v1 >= v2 )  
      cout << "Vector v1 is greater than or equal to vector v2." << endl;  
   else  
      cout << "Vector v1 is less than vector v2." << endl;  
}  
```  
  
 **Vector v1 is greater than or equal to vector v2.**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)