---
title: "operator!= (&lt;list&gt;)"
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
  - "std::!="
  - "!="
  - "std::operator!="
  - "std.operator!="
  - "std.!="
  - "list/std::operator!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator !=, list objects"
  - "operator!=, list objects"
ms.assetid: ba2d48f3-4342-46f2-9328-537b13bb11b8
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (&lt;list&gt;)
Tests if the list object on the left side of the operator is not equal to the list object on the right side.  
  
## Syntax  
  
```  
  
      bool operator!=(  
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
 **true** if the lists are not equal; **false** if the lists are equal.  
  
## Remarks  
 The comparison between list objects is based on a pairwise comparison of their elements. Two lists are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
```  
// list_op_ne.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;   
   list <int> c1, c2;  
   c1.push_back( 1 );  
   c2.push_back( 2 );  
  
   if ( c1 != c2 )  
      cout << "Lists not equal." << endl;  
   else  
      cout << "Lists equal." << endl;  
}  
```  
  
 **Lists not equal.**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)