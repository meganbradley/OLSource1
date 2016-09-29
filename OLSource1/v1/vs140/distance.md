---
title: "distance"
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
  - "std.distance"
  - "distance"
  - "std::distance"
  - "xutility/std::distance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "distance"
  - "distance function"
ms.assetid: f863cae2-852b-4f9c-8006-84d24b4f5f8f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# distance
Determines the number of increments between the positions addressed by two iterators.  
  
## Syntax  
  
```  
  
   template<class InputIterator>  
typename iterator_traits<InputIterator>::difference_type  
   distance(  
      InputIterator _First,   
      InputIterator _Last  
   );  
```  
  
#### Parameters  
 `_First`  
 The first iterator whose distance from the second is to be determined.  
  
 `_Last`  
 The second iterator whose distance from the first is to be determined.  
  
## Return Value  
 The number of times that `_First` must be incremented until it equal `_Last`.  
  
## Remarks  
 The distance function has constant complexity when **InputIterator** satisfies the requirements for a random-access iterator; otherwise, it has linear complexity and so is potentially expensive.  
  
## Example  
  
```  
// iterator_distance.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   list<int> L;  
   for ( i = -1 ; i < 9 ; ++i )   
   {  
      L.push_back ( 2 * i );  
   }  
   list <int>::iterator L_Iter, LPOS = L.begin ( );  
  
   cout << "The list L is: ( ";  
   for ( L_Iter = L.begin( ) ; L_Iter != L.end( ); L_Iter++ )  
      cout << *L_Iter << " ";  
   cout << ")." << endl;  
  
   cout << "The iterator LPOS initially points to the first element: "  
        << *LPOS << "." << endl;  
  
   advance ( LPOS , 7 );  
   cout << "LPOS is advanced 7 steps forward to point "  
        << " to the eighth element: "  
        << *LPOS << "." << endl;  
  
   list<int>::difference_type Ldiff ;  
   Ldiff = distance ( L.begin ( ) , LPOS );  
   cout << "The distance from L.begin( ) to LPOS is: "  
        << Ldiff << "." << endl;  
}  
```  
  
 **The list L is: ( -2 0 2 4 6 8 10 12 14 16 ).**  
**The iterator LPOS initially points to the first element: -2.**  
**LPOS is advanced 7 steps forward to point  to the eighth element: 12.**  
**The distance from L.begin( ) to LPOS is: 7.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [distance](../vs140/distance--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)