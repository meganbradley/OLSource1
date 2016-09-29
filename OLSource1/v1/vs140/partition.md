---
title: "partition"
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
  - "std.partition"
  - "algorithm/std::partition"
  - "std::partition"
  - "partition"
  - "Partition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Partition function"
  - "partition"
ms.assetid: 01a91b09-7950-4f5e-921d-3b2457ed5be4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partition
Classifies elements in a range into two disjoint sets, with those elements satisfying a unary predicate preceding those that fail to satisfy it.  
  
## Syntax  
  
```  
template<class BidirectionalIterator, class Predicate>  
   BidirectionalIterator partition(  
      BidirectionalIterator _First,   
      BidirectionalIterator _Last,   
      Predicate _Comp  
   );  
```  
  
#### Parameters  
 `_First`  
 A bidirectional iterator addressing the position of the first element in the range to be partitioned.  
  
 `_Last`  
 A bidirectional iterator addressing the position one past the final element in the range to be partitioned.  
  
 `_Comp`  
 User-defined predicate function object that defines the condition to be satisfied if an element is to be classified. A predicate takes a single argument and returns **true** or **false**.  
  
## Return Value  
 A bidirectional iterator addressing the position of the first element in the range to not satisfy the predicate condition.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Elements *a* and *b* are equivalent, but not necessarily equal, if both *Pr* (*a*, *b*) is false and *Pr* (*b*, *a*) if false, where *Pr* is the parameter-specified predicate. The **partition** algorithm is not stable and does not guarantee that the relative ordering of equivalent elements will be preserved. The algorithm **stable_ partition** does preserve this original ordering.  
  
 The complexity is linear: there are (`_Last` – `_First`) applications of `_Comp` and at most (`_Last` – `_First`)/2 swaps.  
  
## Example  
  
```  
// alg_partition.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
bool greater5 ( int value ) {  
   return value >5;  
}  
  
int main( ) {  
   using namespace std;  
   vector <int> v1, v2;  
   vector <int>::iterator Iter1, Iter2;  
  
   int i;  
   for ( i = 0 ; i <= 10 ; i++ )  
   {  
      v1.push_back( i );  
   }  
   random_shuffle( v1.begin( ), v1.end( ) );  
  
   cout << "Vector v1 is ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Partition the range with predicate greater10  
   partition ( v1.begin( ), v1.end( ), greater5 );  
   cout << "The partitioned set of elements in v1 is: ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Sample Output  
  
```  
Vector v1 is ( 10 1 9 2 0 5 7 3 4 6 8 ).  
The partitioned set of elements in v1 is: ( 10 8 9 6 7 5 0 3 4 2 1 ).  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [partition](../vs140/partition--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)