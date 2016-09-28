---
title: "sort"
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
  - "std::sort"
  - "sort"
  - "std.sort"
  - "algorithm/std::sort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sort"
  - "sort function"
ms.assetid: 9b0a4fc1-5131-4c73-9c2e-d72211f2d0ae
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sort
Arranges the elements in a specified range into a nondescending order or according to an ordering criterion specified by a binary predicate.  
  
## Syntax  
  
```  
template<class RandomAccessIterator>  
   void sort(  
      RandomAccessIterator first,   
      RandomAccessIterator last  
   );  
template<class RandomAccessIterator, class Predicate>  
   void sort(  
      RandomAccessIterator first,   
      RandomAccessIterator last,   
      Predicate comp  
   );  
```  
  
#### Parameters  
 `first`  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 `last`  
 A random-access iterator addressing the position one past the final element in the range to be sorted.  
  
 `comp`  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. This binary predicate takes two arguments and returns `true` if the two arguments are in order and `false` otherwise. This comparator function must impose a strict weak ordering on pairs of elements from the sequence. For more information, see [Algorithms](../vs140/algorithms.md).  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Elements are equivalent, but not necessarily equal, if neither is less than the other. The `sort` algorithm is not stable and so does not guarantee that the relative ordering of equivalent elements will be preserved. The algorithm `stable_sort` does preserve this original ordering.  
  
 The average of a sort complexity is *O*(*N* log *N*), where *N* = *last – first*.  
  
## Example  
  
```  
// alg_sort.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>      // For greater<int>( )  
#include <iostream>  
  
// Return whether first element is greater than the second  
bool UDgreater ( int elem1, int elem2 )  
{  
   return elem1 > elem2;  
}  
  
int main( )  
{  
   using namespace std;  
   vector <int> v1;  
   vector <int>::iterator Iter1;  
  
   int i;  
   for ( i = 0 ; i <= 5 ; i++ )  
   {  
      v1.push_back( 2 * i );  
   }  
  
   int ii;  
   for ( ii = 0 ; ii <= 5 ; ii++ )  
   {  
      v1.push_back( 2 * ii + 1 );  
   }  
  
   cout << "Original vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   sort( v1.begin( ), v1.end( ) );  
   cout << "Sorted vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // To sort in descending order. specify binary predicate  
   sort( v1.begin( ), v1.end( ), greater<int>( ) );  
   cout << "Resorted (greater) vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // A user-defined (UD) binary predicate can also be used  
   sort( v1.begin( ), v1.end( ), UDgreater );  
   cout << "Resorted (UDgreater) vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
}  
```  
  
 **Original vector v1 = ( 0 2 4 6 8 10 1 3 5 7 9 11 )**  
**Sorted vector v1 = ( 0 1 2 3 4 5 6 7 8 9 10 11 )**  
**Resorted (greater) vector v1 = ( 11 10 9 8 7 6 5 4 3 2 1 0 )**  
**Resorted (UDgreater) vector v1 = ( 11 10 9 8 7 6 5 4 3 2 1 0 )**   
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)