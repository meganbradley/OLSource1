---
title: "operator&lt; (&lt;list&gt;)"
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
  - "std::operator<"
  - "operator<"
  - "list/std::operator<"
  - "std.<"
  - "<"
  - "std.operator<"
  - "std::<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator <, list objects"
  - "< operator, comparing specific objects"
  - "operator<, list objects"
  - "< operator"
ms.assetid: a429e8a6-0be9-4ea8-adc4-619b698bae78
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt; (&lt;list&gt;)
Tests if the list object on the left side of the operator is less than the list object on the right side.  
  
## Syntax  
  
```  
  
      bool operator<(  
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
 **true** if the list on the left side of the operator is less than but not equal to the list on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between list objects is based on a pairwise comparison of their elements. The less-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// list_op_lt.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;   
   list <int> c1, c2;  
   c1.push_back( 1 );  
   c1.push_back( 2 );  
   c1.push_back( 4 );  
  
   c2.push_back( 1 );  
   c2.push_back( 3 );  
  
   if ( c1 < c2 )  
      cout << "List c1 is less than list c2." << endl;  
   else  
      cout << "List c1 is not less than list c2." << endl;  
}  
```  
  
 **List c1 is less than list c2.**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)