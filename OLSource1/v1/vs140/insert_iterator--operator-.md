---
title: "insert_iterator::operator*"
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
  - insert_iterator.operator*
  - std.insert_iterator.operator*
  - operator*
  - insert_iterator::operator*
  - iterator/std::insert_iterator::operator*
  - std::insert_iterator::operator*
dev_langs: 
  - C++
helpviewer_keywords: 
  - * operator
  - operator*
  - * operator, with specific iterator expressions
ms.assetid: ad90a4cf-4886-41b6-aa8a-000295d7ad45
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# insert_iterator::operator*
Dereferences the insert iterator returning the element is addresses.  
  
## Syntax  
  
```  
insert_iterator<Container>& operator*( );  
```  
  
## Return Value  
 The member function returns the value of the element addressed.  
  
## Remarks  
 Used to implement the output iterator expression **\*Iter** = **value**. If **Iter** is an iterator that addresses an element in a sequence, then **\*Iter** = **value** replaces that element with value and does not change the total number of elements in the sequence.  
  
## Example  
  
```  
// insert_iterator_op_deref.cpp  
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
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [insert_iterator Class](../vs140/insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)