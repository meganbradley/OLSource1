---
title: "front_insert_iterator::front_insert_iterator"
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
  - std::front_insert_iterator::front_insert_iterator
  - std.front_insert_iterator.front_insert_iterator
  - iterator/std::front_insert_iterator::front_insert_iterator
  - front_insert_iterator.front_insert_iterator
  - front_insert_iterator::front_insert_iterator
  - front_insert_iterator
dev_langs: 
  - C++
helpviewer_keywords: 
  - front_insert_iterator class constructor
  - front_insert_iterator method
ms.assetid: cfb00c1f-0080-4d1c-b248-9076f299d11b
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# front_insert_iterator::front_insert_iterator
Creates an iterator that can insert elements at the front of a specified container object.  
  
## Syntax  
  
```  
  
      explicit front_insert_iterator(  
   Container& _Cont  
);  
```  
  
#### Parameters  
 `_Cont`  
 The container object into which the `front_insert_iterator` is to insert elements.  
  
## Return Value  
 A `front_insert_iterator` for the parameter container object.  
  
## Example  
  
```  
// front_insert_iterator_front_insert_iterator.cpp  
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
   for (i = -1 ; i < 9 ; ++i )    
   {  
      L.push_back ( 2 * i );  
   }  
  
   cout << "The list L is:\n ( ";  
   for ( L_Iter = L.begin( ) ; L_Iter != L.end( ); L_Iter++)  
      cout << *L_Iter << " ";  
   cout << ")." << endl;  
  
   // Using the member function to insert an element  
   front_inserter ( L ) = 20;  
  
   // Alternatively, one may use the template function  
   front_insert_iterator< list < int> > Iter(L);  
   *Iter = 30;  
  
   cout << "After the front insertions, the list L is:\n ( ";  
   for ( L_Iter = L.begin( ) ; L_Iter != L.end( ); L_Iter++)  
      cout << *L_Iter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The list L is:**  
 **( -2 0 2 4 6 8 10 12 14 16 ).**  
**After the front insertions, the list L is:**  
 **( 30 20 -2 0 2 4 6 8 10 12 14 16 ).**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [front_insert_iterator Class](../vs140/front_insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)