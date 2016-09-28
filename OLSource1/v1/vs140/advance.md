---
title: "advance"
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
  - "std::advance"
  - "advance"
  - "xutility/std::advance"
  - "std.advance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "advance"
  - "advance function"
ms.assetid: c5ded633-fec5-4375-a8c7-7e732591e61e
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# advance
Increments an iterator by a specified number of positions.  
  
## Syntax  
  
```cpp  
template<class InputIterator, class Distance>  
    void advance(  
        InputIterator& InIt,   
        Distance Off  
   );  
```  
  
#### Parameters  
 `InIt`  
 The iterator that is to be incremented and that must satisfy the requirements for an input iterator.  
  
 `Off`  
 An integral type that is convertible to the iterator's difference type and that specifies the number of increments the position of the iterator is to be advanced.  
  
## Remarks  
 The range advanced through must be nonsingular, where the iterators must be dereferenceable or past the end.  
  
 If the **InputIterator** satisfies the requirements for a bidirectional iterator type, then `Off` may be negative. If **InputIterator** is an input or forward iterator type, `Off` must be nonnegative.  
  
 The advance function has constant complexity when **InputIterator** satisfies the requirements for a random-access iterator; otherwise, it has linear complexity and so is potentially expensive.  
  
## Example  
  
```cpp  
// iterator_advance.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   list<int> L;  
   for ( i = 1 ; i < 9 ; ++i )    
   {  
      L.push_back ( i );  
   }  
   list <int>::iterator L_Iter, LPOS = L.begin ( );  
  
   cout << "The list L is: ( ";  
   for ( L_Iter = L.begin( ) ; L_Iter != L.end( ); L_Iter++)  
      cout << *L_Iter << " ";  
   cout << ")." << endl;  
  
   cout << "The iterator LPOS initially points to the first element: "  
        << *LPOS << "." << endl;  
  
   advance ( LPOS , 4 );  
   cout << "LPOS is advanced 4 steps forward to point"  
        << " to the fifth element: "  
        << *LPOS << "." << endl;  
  
   advance ( LPOS , -3 );  
   cout << "LPOS is moved 3 steps back to point to the "  
        << "2nd element: " << *LPOS << "." << endl;  
}  
```  
  
 **The list L is: ( 1 2 3 4 5 6 7 8 ).**  
**The iterator LPOS initially points to the first element: 1.**  
**LPOS is advanced 4 steps forward to point to the fifth element: 5.**  
**LPOS is moved 3 steps back to point to the 2nd element: 2.**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [advance](../vs140/advance--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)