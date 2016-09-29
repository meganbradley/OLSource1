---
title: "front_insert_iterator::operator*"
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
  - "std.front_insert_iterator.operator*"
  - "operator*"
  - "iterator/std::front_insert_iterator::operator*"
  - "front_insert_iterator.operator*"
  - "std::front_insert_iterator::operator*"
  - "front_insert_iterator::operator*"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "* operator"
  - "operator*"
  - "* operator, with specific iterator expressions"
ms.assetid: da73393a-9e1d-4b62-938c-ab3fd6a2146c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# front_insert_iterator::operator*
Dereferences the insert iterator returning the element it addresses.  
  
## Syntax  
  
```  
front_insert_iterator<Container>& operator*( );  
```  
  
## Return Value  
 The member function returns the value of the element addressed.  
  
## Remarks  
 Used to implement the output iterator expression **\*Iter** = **value**. If **Iter** is an iterator that addresses an element in a sequence, then **\*Iter** = **value** replaces that element with value and does not change the total number of elements in the sequence.  
  
## Example  
  
```  
// front_insert_iterator_deref.cpp  
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
   for ( i = -1 ; i < 9 ; ++i )   
   {  
      L.push_back ( 2 * i );  
   }  
  
   cout << "The list L is:\n ( ";  
   for ( L_Iter = L.begin( ) ; L_Iter != L.end( ); L_Iter++)  
      cout << *L_Iter << " ";  
   cout << ")." << endl;  
  
   front_insert_iterator< list < int> > Iter(L);  
   *Iter = 20;  
  
   // Alternatively, you may use  
   front_inserter ( L ) = 30;  
  
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
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [front_insert_iterator Class](../vs140/front_insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)