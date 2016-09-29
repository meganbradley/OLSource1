---
title: "operator!= (&lt;deque&gt;)"
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
  - "deque/std::operator!="
  - "std::!="
  - "!="
  - "std::operator!="
  - "std.operator!="
  - "std.!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator!=, deque objects"
  - "operator !=, deque objects"
ms.assetid: 4a54612c-33c8-41d2-a977-982c1ddbde68
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (&lt;deque&gt;)
Tests if the deque object on the left side of the operator is not equal to the deque object on the right side.  
  
## Syntax  
  
```  
  
      bool operator!=(  
   const deque<Type, Allocator>& _Left,  
   const deque<Type, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type `deque`.  
  
 `_Right`  
 An object of type `deque`.  
  
## Return Value  
 **true** if the deque objects are not equal; **false** if the deque objects are equal.  
  
## Remarks  
 The comparison between deque objects is based on a pairwise comparison of their elements. Two deque objects are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
```  
// deque_op_ne.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;   
   deque <int> c1, c2;  
  
   c1.push_back( 1 );  
   c2.push_back( 2 );  
  
   if ( c1 != c2 )  
      cout << "The deques are not equal." << endl;  
   else  
      cout << "The deques are equal." << endl;  
}  
```  
  
 **The deques are not equal.**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)