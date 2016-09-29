---
title: "insert_iterator::operator="
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
  - "="
  - "operator="
  - "std.insert_iterator.operator="
  - "insert_iterator::operator="
  - "insert_iterator.operator="
  - "std::insert_iterator::operator="
  - "iterator/std::insert_iterator::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, iterators"
  - "operator =, iterators"
  - "= operator, with specific standard C++ library objects"
ms.assetid: 5e798f53-d461-479f-8589-bb889b6eef1e
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# insert_iterator::operator=
Inserts a value into the container and returns the iterator updated to point to the new element.  
  
## Syntax  
  
```  
insert_iterator<Container>& operator=(  
   typename Container::const_reference _Val,  
);  
insert_iterator<Container>& operator=(  
   typename Container::value_type&& _Val  
);   
```  
  
#### Parameters  
 `_Val`  
 The value to be assigned to the container.  
  
## Return Value  
 A reference to the element inserted into the container.  
  
## Remarks  
 The first member operator evaluates  
  
 `Iter = container->insert(Iter, _Val)`;  
  
 `++Iter;`  
  
 then returns `*this`.  
  
 The second member operator evaluates  
  
 `Iter = container->insert(Iter, std::move(_Val));`  
  
 `++Iter;`  
  
 then returns `*this`.  
  
## Example  
  
```  
// insert_iterator_op_assign.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
   list <int>::iterator L_Iter;  
  
   list<int> L;  
   for (i = 0 ; i < 4 ; ++i )   
   {  
      L.push_back ( 2 * i );  
   }  
  
   cout << "The original list L is:\n ( ";  
   for ( L_Iter = L.begin( ) ; L_Iter != L.end( ); L_Iter++ )  
      cout << *L_Iter << " ";  
   cout << ")." << endl;  
  
   insert_iterator< list < int> > Iter(L, L.begin ( ) );  
   *Iter = 10;  
   *Iter = 20;  
   *Iter = 30;  
  
   cout << "After the insertions, the list L is:\n ( ";  
   for ( L_Iter = L.begin( ) ; L_Iter != L.end( ); L_Iter++ )  
      cout << *L_Iter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The original list L is:**  
 **( 0 2 4 6 ).**  
**After the insertions, the list L is:**  
 **( 10 20 30 0 2 4 6 ).**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [insert_iterator Class](../vs140/insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)