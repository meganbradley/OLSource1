---
title: "front_insert_iterator::operator="
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
  - "front_insert_iterator::operator="
  - "="
  - "operator="
  - "front_insert_iterator.operator="
  - "iterator/std::front_insert_iterator::operator="
  - "std.front_insert_iterator.operator="
  - "std::front_insert_iterator::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, iterators"
  - "operator =, iterators"
  - "= operator, with specific standard C++ library objects"
ms.assetid: 6a45e8ec-be95-4cd3-badf-bccc52b441f8
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# front_insert_iterator::operator=
Appends (pushes) a value onto the front of the container.  
  
## Syntax  
  
```  
front_insert_iterator<Container>& operator=(  
   typename Container::const_reference _Val  
);  
front_insert_iterator<Container>& operator=(  
   typename Container::value_type&& _Val  
);  
```  
  
#### Parameters  
 `_Val`  
 The value to be assigned to the container.  
  
## Return Value  
 A reference to the last element inserted at the front of the container.  
  
## Remarks  
 The first member operator evaluates `container.push_front(_Val)`, then returns `*this`.  
  
 The second member operator evaluates  
  
 `container->push_front((typename Container::value_type&&)_Val)`,  
  
 then returns `*this`.  
  
## Example  
  
```  
// front_insert_iterator_op_assign.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   list<int> L1;  
   front_insert_iterator<list<int> > iter ( L1 );  
   *iter = 10;  
   iter++;  
   *iter = 20;  
   iter++;  
   *iter = 30;  
   iter++;  
  
   list <int>::iterator vIter;  
   cout << "The list L1 is: ( ";  
   for ( vIter = L1.begin ( ) ; vIter != L1.end ( ); vIter++ )  
      cout << *vIter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The list L1 is: ( 30 20 10 ).**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [front_insert_iterator Class](../vs140/front_insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)