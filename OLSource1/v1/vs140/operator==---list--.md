---
title: "operator== (&lt;list&gt;)"
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
  - "list/std::operator=="
  - "std.operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, list objects"
  - "operator==, list objects"
  - "== operator, with specific standard C++ objects"
ms.assetid: e12cfb80-ee37-4826-9ca8-c62f6baf9a95
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;list&gt;)
Tests if the list object on the left side of the operator is equal to the list object on the right side.  
  
## Syntax  
  
```  
  
      bool operator==(  
   const list<Type, Allocator>& _Left,  
   const list<Type, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type **list**.  
  
 `_Right`  
 An object of type **list**.  
  
## Return Value  
 **true** if the list on the left side of the operator is equal to the list on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between list objects is based on a pairwise comparison of their elements. Two lists are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
```  
// list_op_eq.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
int main( )   
{  
   using namespace std;   
  
   list <int> c1, c2;  
   c1.push_back( 1 );  
   c2.push_back( 1 );  
  
   if ( c1 == c2 )  
      cout << "The lists are equal." << endl;  
   else  
      cout << "The lists are not equal." << endl;  
}  
```  
  
 **The lists are equal.**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)