---
title: "inserter"
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
  - "std.inserter"
  - "inserter"
  - "iterator/std::inserter"
  - "std::inserter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "inserter"
  - "inserter function"
ms.assetid: 47e27c8a-89ac-4c26-a923-7623d86633ba
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# inserter
A helper template function that lets you use `inserter(``_Cont``,``_Where``)` instead of `insert_iterator<Container>(``_Cont`,`_Where``)`.  
  
## Syntax  
  
```  
template<class Container>  
    insert_iterator<Container> inserter(  
        Container& _Cont,  
        typename Container::iterator _Where  
    );  
```  
  
#### Parameters  
 `_Cont`  
 The container to which new elements are to be added.  
  
 `_Where`  
 An iterator locating the point of insertion.  
  
## Remarks  
 The template function returns [insert_iterator](../vs140/insert_iterator--insert_iterator.md)`<Container>(``_Cont``,` `_Where``)`.  
  
## Example  
  
```  
// iterator_inserter.cpp  
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
   for (i = 2 ; i < 5 ; ++i )    
   {  
      L.push_back ( 10 * i );  
   }  
  
   cout << "The list L is:\n ( ";  
   for ( L_Iter = L.begin( ) ; L_Iter != L.end( ); L_Iter++ )  
      cout << *L_Iter << " ";  
   cout << ")." << endl;  
  
   // Using the template version to insert an element  
   insert_iterator<list <int> > Iter( L, L.begin ( ) );  
   *Iter = 1;  
  
   // Alternatively, using the member function to insert an element  
   inserter ( L, L.end ( ) ) = 500;  
  
   cout << "After the insertions, the list L is:\n ( ";  
   for ( L_Iter = L.begin( ) ; L_Iter != L.end( ); L_Iter++)  
      cout << *L_Iter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The list L is:**  
 **( 20 30 40 ).**  
**After the insertions, the list L is:**  
 **( 1 20 30 40 500 ).**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)