---
title: "deque::swap"
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
  - "deque/std::deque::swap"
  - "std.deque.swap"
  - "deque::swap"
  - "deque.swap"
  - "swap"
  - "std::deque::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 0c921dee-e67e-4e0d-a27b-b344c164e234
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# deque::swap
Exchanges the elements of two deques.  
  
## Syntax  
  
```  
  
      void swap(  
   deque<Type, Allocator>& _Right  
);  
friend void swap(  
   deque<Type, Allocator>& _Left,  
   deque<Type, Allocator>& _Right  
)  
template<class Type, class Allocator>  
void swap(  
   deque< Type, Allocator>& _Left,   
   deque< Type, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The deque providing the elements to be swapped, or the deque whose elements are to be exchanged with those of the deque `_Left`.  
  
 `_Left`  
 A deque whose elements are to be exchanged with those of the deque `_Right`.  
  
## Example  
  
```  
// deque_swap.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   deque <int> c1, c2, c3;  
   deque <int>::iterator c1_Iter;  
  
   c1.push_back( 1 );  
   c1.push_back( 2 );  
   c1.push_back( 3 );  
   c2.push_back( 10 );  
   c2.push_back( 20 );  
   c3.push_back( 100 );  
  
   cout << "The original deque c1 is:";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
  
   c1.swap( c2 );  
  
   cout << "After swapping with c2, deque c1 is:";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
  
   swap( c1,c3 );  
  
   cout << "After swapping with c3, deque c1 is:";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
  
   swap<>(c1, c2);  
   cout << "After swapping with c2, deque c1 is:";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
}  
```  
  
 **The original deque c1 is: 1 2 3**  
**After swapping with c2, deque c1 is: 10 20**  
**After swapping with c3, deque c1 is: 100**  
**After swapping with c2, deque c1 is: 1 2 3**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::assign and deque::swap](../vs140/deque--assign-and-deque--swap.md)   
 [Standard Template Library](../vs140/standard-template-library.md)