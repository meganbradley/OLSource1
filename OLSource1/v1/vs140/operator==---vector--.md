---
title: "operator== (&lt;vector&gt;)"
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
  - "std.=="
  - "std::=="
  - "operator=="
  - "std.operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator==, comparing objects"
  - "operator =="
  - "operator ==, comparing objects"
  - "operator=="
  - "== operator, with specific standard C++ objects"
ms.assetid: 205b59e2-db06-443d-b0ef-434e04ee4d8f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;vector&gt;)
Tests if the object on the left side of the operator is equal to the object on the right side.  
  
## Syntax  
  
```  
  
      bool operator==(  
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
 **true** if the vector on the left side of the operator is equal to the vector on the right side of the operator; otherwise **false**.  
  
## Remarks  
 Two vectors are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
```  
// vector_op_eq.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;   
  
   vector <int> v1, v2;  
   v1.push_back( 1 );  
   v2.push_back( 1 );  
  
   if ( v1 == v2 )  
      cout << "Vectors equal." << endl;  
   else  
      cout << "Vectors not equal." << endl;  
}  
```  
  
 **Vectors equal.**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector::operator==](../vs140/vector--operator==.md)   
 [Standard Template Library](../vs140/standard-template-library.md)