---
title: "stable_partition"
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
  - "std.stable_partition"
  - "std::stable_partition"
  - "stable_partition"
  - "algorithm/std::stable_partition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stable_partition function"
  - "stable_partition"
ms.assetid: 224e97bf-b752-4c10-aa8c-95031dd535de
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# stable_partition
Classifies elements in a range into two disjoint sets, with those elements satisfying a unary predicate preceding those that fail to satisfy it, preserving the relative order of equivalent elements.  
  
## Syntax  
  
```  
  
   template<class BidirectionalIterator, class Predicate>  
BidirectionalIterator stable_partition(  
   BidirectionalIterator _First,   
   BidirectionalIterator _Last,  
   Predicate _Pred  
);  
```  
  
#### Parameters  
 `_First`  
 A bidirectional iterator addressing the position of the first element in the range to be partitioned.  
  
 `_Last`  
 A bidirectional iterator addressing the position one past the final element in the range to be partitioned.  
  
 `_Pred`  
 User-defined predicate function object that defines the condition to be satisfied if an element is to be classified. A predicate takes single argument and returns **true** or **false**.  
  
## Return Value  
 A bidirectional iterator addressing the position of the first element in the range to not satisfy the predicate condition.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Elements *a* and *b* are equivalent, but not necessarily equal, if both *Pr* (*a*, *b*) is false and *Pr* (*b*, *a*) if false, where *Pr* is the parameter-specified predicate. The **stable_ partition** algorithm is stable and guarantees that the relative ordering of equivalent elements will be preserved. The algorithm **partition** does not necessarily preserve this original ordering.  
  
## Example  
  
```  
// alg_stable_partition.cpp  
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
   vector <int>::iterator Iter1, Iter2, result;  
  
   int i;  
   for ( i = 0 ; i <= 10 ; i++ )  
      v1.push_back( i );  
  
   int ii;  
   for ( ii = 0 ; ii <= 4 ; ii++ )  
      v1.push_back( 5 );  
  
   random_shuffle(v1.begin( ), v1.end( ) );  
  
   cout << "Vector v1 is ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Partition the range with predicate greater10  
   result = stable_partition (v1.begin( ), v1.end( ), greater5 );  
   cout << "The partitioned set of elements in v1 is:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   cout << "The first element in v1 to fail to satisfy the"  
        << "\n predicate greater5 is: " << *result << "." << endl;  
}  
```  
  
## Sample Output  
  
```  
Vector v1 is ( 5 1 9 2 0 5 7 3 4 5 8 5 5 5 10 6 ).  
The partitioned set of elements in v1 is:  
 ( 9 7 8 10 6 5 1 2 0 5 3 4 5 5 5 5 ).  
The first element in v1 to fail to satisfy the  
 predicate greater5 is: 5.  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)