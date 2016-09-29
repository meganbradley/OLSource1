---
title: "make_heap"
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
  - "algorithm/std::make_heap"
  - "std::make_heap"
  - "make_heap"
  - "std.make_heap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_heap function"
  - "make_heap"
ms.assetid: b09f795c-f368-4aa8-b57e-61ee6100ddc2
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# make_heap
Converts elements from a specified range into a heap in which the first element is the largest and for which a sorting criterion may be specified with a binary predicate.  
  
## Syntax  
  
```  
  
      template<class RandomAccessIterator>  
   void make_heap(  
      RandomAccessIterator _First,   
      RandomAccessIterator _Last  
   );  
template<class RandomAccessIterator, class BinaryPredicate>  
   void make_heap(  
      RandomAccessIterator _First,   
      RandomAccessIterator _Last,  
      BinaryPredicate _Comp  
   );  
```  
  
#### Parameters  
 `_First`  
 A random-access iterator addressing the position of the first element in the range to be converted into a heap.  
  
 `_Last`  
 A random-access iterator addressing the position one past the final element in the range to be converted into a heap.  
  
 `_Comp`  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Remarks  
 Heaps have two properties:  
  
-   The first element is always the largest.  
  
-   Elements may be added or removed in logarithmic time.  
  
 Heaps are an ideal way to implement priority queues and they are used in the implementation of the Standard Template Library container adaptor [priority_queue Class](../vs140/priority_queue-class.md).  
  
 The complexity is linear, requiring 3 \* (*_Last – _First*) comparisons.  
  
## Example  
  
```  
// alg_make_heap.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>  
#include <iostream>  
  
int main() {  
   using namespace std;  
   vector <int> v1, v2;  
   vector <int>::iterator Iter1, Iter2;  
  
   int i;  
   for ( i = 0 ; i <= 9 ; i++ )  
      v1.push_back( i );  
  
   random_shuffle( v1.begin( ), v1.end( ) );  
  
   cout << "Vector v1 is ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Make v1 a heap with default less than ordering  
   make_heap ( v1.begin( ), v1.end( ) );  
   cout << "The heaped version of vector v1 is ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Make v1 a heap with greater than ordering  
   make_heap ( v1.begin( ), v1.end( ), greater<int>( ) );  
   cout << "The greater-than heaped version of v1 is ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Sample Output  
  
```  
Vector v1 is ( 8 1 9 2 0 5 7 3 4 6 ).  
The heaped version of vector v1 is ( 9 6 8 4 1 5 7 3 2 0 ).  
The greater-than heaped version of v1 is ( 0 1 5 2 6 8 7 3 4 9 ).  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [heap](../vs140/heap.md)   
 [Standard Template Library](../vs140/standard-template-library.md)