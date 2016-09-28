---
title: "list::merge"
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
  - "merge"
  - "std::list::merge"
  - "list/std::list::merge"
  - "std.list.merge"
  - "list::merge"
  - "list.merge"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "merge method"
  - "merge method, merge function"
ms.assetid: 14bc887b-7f14-4986-9000-d180b521db05
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::merge
Removes the elements from the argument list, inserts them into the target list, and orders the new, combined set of elements in ascending order or in some other specified order.  
  
## Syntax  
  
```  
void merge(  
   list<Type, Allocator>& _Right  
);  
template<class Traits>  
   void merge(  
      list<Type, Allocator>& _Right,   
      Traits _Comp  
   );  
```  
  
#### Parameters  
 `_Right`  
 The argument list to be merged with the target list.  
  
 `_Comp`  
 The comparison operator used to order the elements of the target list.  
  
## Remarks  
 The argument list `_Right` is merged with the target list.  
  
 Both argument and target lists must be ordered with the same comparison relation by which the resulting sequence is to be ordered. The default order for the first member function is ascending order. The second member function imposes the user-specified comparison operation `_Comp` of class **Traits**.  
  
## Example  
  
```  
// list_merge.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   list <int> c1, c2, c3;  
   list <int>::iterator c1_Iter, c2_Iter, c3_Iter;  
  
   c1.push_back( 3 );  
   c1.push_back( 6 );  
   c2.push_back( 2 );  
   c2.push_back( 4 );  
   c3.push_back( 5 );  
   c3.push_back( 1 );  
  
   cout << "c1 =";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
  
   cout << "c2 =";  
   for ( c2_Iter = c2.begin( ); c2_Iter != c2.end( ); c2_Iter++ )  
      cout << " " << *c2_Iter;  
   cout << endl;  
  
   c2.merge( c1 );  // Merge c1 into c2 in (default) ascending order  
   c2.sort( greater<int>( ) );  
   cout << "After merging c1 with c2 and sorting with >: c2 =";  
   for ( c2_Iter = c2.begin( ); c2_Iter != c2.end( ); c2_Iter++ )  
      cout << " " << *c2_Iter;  
   cout << endl;  
  
   cout << "c3 =";  
   for ( c3_Iter = c3.begin( ); c3_Iter != c3.end( ); c3_Iter++ )  
      cout << " " << *c3_Iter;  
   cout << endl;  
  
   c2.merge( c3, greater<int>( ) );  
   cout << "After merging c3 with c2 according to the '>' comparison relation: c2 =";  
   for ( c2_Iter = c2.begin( ); c2_Iter != c2.end( ); c2_Iter++ )  
      cout << " " << *c2_Iter;  
   cout << endl;  
}  
```  
  
 **c1 = 3 6**  
**c2 = 2 4**  
**After merging c1 with c2 and sorting with >: c2 = 6 4 3 2**  
**c3 = 5 1**  
**After merging c3 with c2 according to the '>' comparison relation: c2 = 6 5 4 3 2 1**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)