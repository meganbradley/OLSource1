---
title: "operator&lt; (&lt;vector&gt;)"
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
  - std::operator<
  - operator<
  - std.<
  - <
  - std.operator<
  - std::<
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator<
  - operator<, comparing objects
  - operator <, comparing objects
  - operator <
  - < operator
ms.assetid: 1f2f26c9-82a6-41ad-891e-49190682f711
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator&lt; (&lt;vector&gt;)
Tests if the object on the left side of the operator is less than the object on the right side.  
  
## Syntax  
  
```  
  
      bool operator<(  
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
 **true** if the vector on the left side of the operator is less than the vector on the right side of the operator; otherwise **false**.  
  
## Example  
  
```  
// vector_op_lt.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;   
  
   vector <int> v1, v2;  
   v1.push_back( 1 );  
   v1.push_back( 2 );  
   v1.push_back( 4 );  
  
   v2.push_back( 1 );  
   v2.push_back( 3 );  
  
   if ( v1 < v2 )  
      cout << "Vector v1 is less than vector v2." << endl;  
   else  
      cout << "Vector v1 is not less than vector v2." << endl;  
}  
```  
  
 **Vector v1 is less than vector v2.**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector::operator<](../vs140/vector--operator-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)