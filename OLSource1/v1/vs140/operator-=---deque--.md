---
title: "operator&lt;= (&lt;deque&gt;)"
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
  - "std::<="
  - "deque/std::operator<="
  - "std.operator<="
  - "operator<="
  - "std.<="
  - "std::operator<="
  - "<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator <=, deque objects"
  - "<= operator, with specific objects"
  - "operator<=, deque objects"
  - "<= operator"
ms.assetid: 1346fedc-f97a-40d7-aa86-eccfad5c475b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;= (&lt;deque&gt;)
Tests if the deque object on the left side of the operator is less than or equal to the deque object on the right side.  
  
## Syntax  
  
```  
  
      bool operator<=(  
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
 **true** if the deque on the left side of the operator is less than or equal to the deque on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between deque objects is based on a pairwise comparison of their elements. The less than or equal to relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// deque_op_le.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;   
   deque <int> c1, c2;  
  
   c1.push_back( 1 );  
   c1.push_back( 2 );  
   c1.push_back( 4 );  
  
   c2.push_back( 1 );  
   c2.push_back( 3 );  
  
   if ( c1 <= c2 )  
      cout << "Deque c1 is less than or equal to deque c2." << endl;  
   else  
      cout << "Deque c1 is greater than deque c2." << endl;  
}  
```  
  
 **Deque c1 is less than or equal to deque c2.**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)