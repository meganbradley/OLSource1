---
title: "partial_sort"
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
  - "std.partial_sort"
  - "partial_sort"
  - "std::partial_sort"
  - "algorithm/std::partial_sort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "partial_sort"
  - "partial_sort function"
ms.assetid: 327453e4-16c0-423c-bc1a-abea8ca63157
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partial_sort
Arranges a specified number of the smaller elements in a range into a nondescending order or according to an ordering criterion specified by a binary predicate.  
  
## Syntax  
  
```  
template<class RandomAccessIterator>  
   void partial_sort(  
      RandomAccessIterator first,   
      RandomAccessIterator sortEnd,  
      RandomAccessIterator last  
   );  
template<class RandomAccessIterator, class BinaryPredicate>  
   void partial_sort(  
      RandomAccessIterator first,   
      RandomAccessIterator sortEnd,  
      RandomAccessIterator last  
      BinaryPredicate comp  
   );  
```  
  
#### Parameters  
 `first`  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 `sortEnd`  
 A random-access iterator addressing the position one past the final element in the subrange to be sorted.  
  
 `last`  
 A random-access iterator addressing the position one past the final element in the range to be partially sorted.  
  
 `comp`  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Elements are equivalent, but not necessarily equal, if neither is less than the other. The **sort** algorithm is not stable and does not guarantee that the relative ordering of equivalent elements will be preserved. The algorithm `stable_sort` does preserve this original ordering.  
  
 The average partial sort complexity is *O*((`last`-`first`) log (`sortEnd`-`first`)).  
  
## Example  
  
```  
// alg_partial_sort.cpp  
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
      v1.push_back( 2 * ii +1 );  
   }  
  
   cout << "Original vector:\n v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   partial_sort(v1.begin( ), v1.begin( ) + 6, v1.end( ) );  
   cout << "Partially sorted vector:\n v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // To partially sort in descending order, specify binary predicate  
   partial_sort(v1.begin( ), v1.begin( ) + 4, v1.end( ), greater<int>( ) );  
   cout << "Partially resorted (greater) vector:\n v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // A user-defined (UD) binary predicate can also be used  
   partial_sort(v1.begin( ), v1.begin( ) + 8, v1.end( ),   
 UDgreater );  
   cout << "Partially resorted (UDgreater) vector:\n v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
}  
```  
  
 **Original vector:**  
 **v1 = ( 0 2 4 6 8 10 1 3 5 7 9 11 )**  
**Partially sorted vector:**  
 **v1 = ( 0 1 2 3 4 5 10 8 6 7 9 11 )**  
**Partially resorted (greater) vector:**  
 **v1 = ( 11 10 9 8 0 1 2 3 4 5 6 7 )**  
**Partially resorted (UDgreater) vector:**  
 **v1 = ( 11 10 9 8 7 6 5 4 0 1 2 3 )**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [partial_sort](../vs140/partial_sort--stl-samples-.md)   
 [Predicate Version of partial_sort](../vs140/predicate-version-of-partial_sort.md)   
 [Standard Template Library](../vs140/standard-template-library.md)