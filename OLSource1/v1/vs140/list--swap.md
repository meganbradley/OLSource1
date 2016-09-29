---
title: "list::swap"
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
  - "list.swap"
  - "std::list::swap"
  - "list::swap"
  - "list/std::list::swap"
  - "swap"
  - "std.list.swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: df65e322-3c67-4962-82c1-296929942f48
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::swap
Exchanges the elements of two lists.  
  
## Syntax  
  
```unstlib  
  
      void swap(  
   list<Type, Allocator>& _Right  
);  
friend void swap(  
   list<Type, Allocator>& _Left,  
   list<Type, Allocator>& _Right  
)  
```  
  
#### Parameters  
 `_Right`  
 The list providing the elements to be swapped, or the list whose elements are to be exchanged with those of the list `_Left`.  
  
 `_Left`  
 A list whose elements are to be exchanged with those of the list `_Right`.  
  
## Example  
  
```  
// list_swap.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   list <int> c1, c2, c3;  
   list <int>::iterator c1_Iter;  
  
   c1.push_back( 1 );  
   c1.push_back( 2 );  
   c1.push_back( 3 );  
   c2.push_back( 10 );  
   c2.push_back( 20 );  
   c3.push_back( 100 );  
  
   cout << "The original list c1 is:";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
  
   c1.swap( c2 );  
  
   cout << "After swapping with c2, list c1 is:";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
  
   swap( c1,c3 );  
  
   cout << "After swapping with c3, list c1 is:";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
}  
```  
  
 **The original list c1 is: 1 2 3**  
**After swapping with c2, list c1 is: 10 20**  
**After swapping with c3, list c1 is: 100**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)