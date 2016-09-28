---
title: "swap_ranges"
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
  - "std.swap_ranges"
  - "std::swap_ranges"
  - "swap_ranges"
  - "algorithm/std::swap_ranges"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap_ranges"
  - "swap_ranges function"
ms.assetid: 6dbc8367-d97b-4a25-978d-7f94eb465cbc
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap_ranges
Exchanges the elements of one range with the elements of another, equal sized range.  
  
## Syntax  
  
```  
  
   template<class ForwardIterator1, class ForwardIterator2>  
ForwardIterator2 swap_ranges(  
   ForwardIterator1 _First1,   
   ForwardIterator1 _Last1,  
   ForwardIterator2 _First2  
);  
```  
  
#### Parameters  
 `_First1`  
 A forward iterator pointing to the first position of the first range whose elements are to be exchanged.  
  
 `_Last1`  
 A forward iterator pointing to one past the final position of the first range whose elements are to be exchanged.  
  
 `_First2`  
 A forward iterator pointing to the first position of the second range whose elements are to be exchanged.  
  
## Return Value  
 A forward iterator pointing to one past the final position of the second range whose elements are to be exchanged.  
  
## Remarks  
 The ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position is reachable from the first by incrementation. The second range has to be as large as the first range.  
  
 The complexity is linear with `_Last1` – `_First1` swaps performed. If elements from containers of the same type are being swapped, them the `swap` member function from that container should be used, because the member function typically has constant complexity.  
  
## Example  
  
```  
// alg_swap_ranges.cpp  
// compile with: /EHsc  
#include <vector>  
#include <deque>  
#include <algorithm>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   vector <int> v1;  
   deque <int> d1;  
   vector <int>::iterator v1Iter1;  
   deque<int>::iterator d1Iter1;  
  
   int i;  
   for ( i = 0 ; i <= 5 ; i++ )  
   {  
      v1.push_back( i );  
   }  
  
   int ii;  
   for ( ii =4 ; ii <= 9 ; ii++ )  
   {  
      d1.push_back( 6 );  
   }  
  
   cout << "Vector v1 is ( " ;  
   for ( v1Iter1 = v1.begin( ) ; v1Iter1 != v1.end( ) ;v1Iter1 ++ )  
      cout << *v1Iter1  << " ";  
   cout << ")." << endl;  
  
   cout << "Deque d1 is  ( " ;  
   for ( d1Iter1 = d1.begin( ) ; d1Iter1 != d1.end( ) ;d1Iter1 ++ )  
      cout << *d1Iter1  << " ";  
   cout << ")." << endl;  
  
   swap_ranges ( v1.begin ( ) , v1.end ( ) , d1.begin ( ) );  
  
   cout << "After the swap_range, vector v1 is ( " ;  
   for ( v1Iter1 = v1.begin( ) ; v1Iter1 != v1.end( ) ;v1Iter1 ++ )  
      cout << *v1Iter1 << " ";  
   cout << ")." << endl;  
  
   cout << "After the swap_range deque d1 is   ( " ;  
   for ( d1Iter1 = d1.begin( ) ; d1Iter1 != d1.end( ) ;d1Iter1 ++ )  
      cout << *d1Iter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
 **Vector v1 is ( 0 1 2 3 4 5 ).**  
**Deque d1 is  ( 6 6 6 6 6 6 ).**  
**After the swap_range, vector v1 is ( 6 6 6 6 6 6 ).**  
**After the swap_range deque d1 is   ( 0 1 2 3 4 5 ).**   
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)