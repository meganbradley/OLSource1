---
title: "stable_sort"
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
  - "std::stable_sort"
  - "stable_sort"
  - "algorithm/std::stable_sort"
  - "std.stable_sort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stable_sort"
  - "stable_sort function"
ms.assetid: 5af850b2-7556-42a9-be78-0ba2557fe7f7
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stable_sort
Arranges the elements in a specified range into a nondescending order or according to an ordering criterion specified by a binary predicate and preserves the relative ordering of equivalent elements.  
  
## Syntax  
  
```  
  
      template<class BidirectionalIterator>  
   void stable_sort(  
      BidirectionalIterator _First,   
      BidirectionalIterator _Last  
   );  
template<class BidirectionalIterator, class BinaryPredicate>  
   void stable_sort(  
      BidirectionalIterator _First,   
      BidirectionalIterator _Last,  
      BinaryPredicate _Comp  
   );  
```  
  
#### Parameters  
 `_First`  
 A bidirectional iterator addressing the position of the first element in the range to be sorted.  
  
 `_Last`  
 A bidirectional iterator addressing the position one past the final element in the range to be sorted.  
  
 `_Comp`  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Elements are equivalent, but not necessarily equal, if neither is less than the other. The **sort** algorithm is stable and guarantees that the relative ordering of equivalent elements will be preserved.  
  
 The run-time complexity of `stable_sort` depends on the amount of memory available, but the best case (given sufficient memory) is *O*(*N* log *N*) and the worst case is *O*( *N* ( log *N* )2 ), where *N* = *_Last – First.* Usually, the **sort** algorithm is significantly faster than `stable_sort`.  
  
## Example  
  
```  
// alg_stable_sort.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>      // For greater<int>( )  
#include <iostream>  
  
// Return whether first element is greater than the second  
bool UDgreater (int elem1, int elem2 )  
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
  
   for ( i = 0 ; i <= 5 ; i++ )  
   {  
      v1.push_back( 2 * i  );  
   }  
  
   cout << "Original vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   stable_sort(v1.begin( ), v1.end( ) );  
   cout << "Sorted vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // To sort in descending order, specify binary predicate  
   stable_sort(v1.begin( ), v1.end( ), greater<int>( ) );  
   cout << "Resorted (greater) vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // A user-defined (UD) binary predicate can also be used  
   stable_sort(v1.begin( ), v1.end( ), UDgreater );  
   cout << "Resorted (UDgreater) vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
}  
```  
  
 **Original vector v1 = ( 0 2 4 6 8 10 0 2 4 6 8 10 )**  
**Sorted vector v1 = ( 0 0 2 2 4 4 6 6 8 8 10 10 )**  
**Resorted (greater) vector v1 = ( 10 10 8 8 6 6 4 4 2 2 0 0 )**  
**Resorted (UDgreater) vector v1 = ( 10 10 8 8 6 6 4 4 2 2 0 0 )**   
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)