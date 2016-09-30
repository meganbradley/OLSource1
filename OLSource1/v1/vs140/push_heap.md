---
title: "push_heap"
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
  - "std.push_heap"
  - "push_heap"
  - "algorithm/std::push_heap"
  - "std::push_heap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push_heap"
  - "push_heap function"
ms.assetid: 451cfdac-1021-42f9-abdd-ea2e35ceb8ba
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# push_heap
Adds an element that is at the end of a range to an existing heap consisting of the prior elements in the range.  
  
## Syntax  
  
```  
  
      template<class RandomAccessIterator>  
   void push_heap(  
      RandomAccessIterator _First,   
      RandomAccessIterator _Last  
   );  
template<class RandomAccessIterator, class BinaryPredicate>  
   void push_heap(  
      RandomAccessIterator _First,   
      RandomAccessIterator _Last,  
      BinaryPredicate _Comp  
   );  
```  
  
#### Parameters  
 `_First`  
 A random-access iterator addressing the position of the first element in the heap.  
  
 `_Last`  
 A random-access iterator addressing the position one past the final element in the range to be converted into a heap.  
  
 `_Comp`  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Remarks  
 The element must first be pushed back to the end of an existing heap and then the algorithm is used to add this element to the existing heap.  
  
 Heaps have two properties:  
  
-   The first element is always the largest.  
  
-   Elements may be added or removed in logarithmic time.  
  
 Heaps are an ideal way to implement priority queues and they are used in the implementation of the Standard Template Library container adaptor [priority_queue Class](../vs140/priority_queue-class.md).  
  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The range excluding the newly added element at the end must be a heap.  
  
 The complexity is logarithmic, requiring at most log (*_Last – _First*) comparisons.  
  
## Example  
  
```  
// alg_push_heap.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>  
#include <iostream>  
  
int main( ) {  
   using namespace std;  
   vector <int> v1, v2;  
   vector <int>::iterator Iter1, Iter2;  
  
   int i;  
   for ( i = 1 ; i <= 9 ; i++ )  
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
  
   // Add an element to the heap  
   v1.push_back( 10 );  
   cout << "The heap v1 with 10 pushed back is ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   push_heap( v1.begin( ), v1.end( ) );  
   cout << "The reheaped v1 with 10 added is ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl << endl;  
  
   // Make v1 a heap with greater than ordering  
   make_heap ( v1.begin( ), v1.end( ), greater<int>( ) );  
   cout << "The greater-than heaped version of v1 is\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   v1.push_back(0);  
   cout << "The greater-than heap v1 with 11 pushed back is\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   push_heap( v1.begin( ), v1.end( ), greater<int>( ) );  
   cout << "The greater than reheaped v1 with 11 added is\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Sample Output  
  
```  
Vector v1 is ( 9 2 7 3 1 6 8 4 5 ).  
The heaped version of vector v1 is ( 9 5 8 4 1 6 7 2 3 ).  
The heap v1 with 10 pushed back is ( 9 5 8 4 1 6 7 2 3 10 ).  
The reheaped v1 with 10 added is ( 10 9 8 4 5 6 7 2 3 1 ).  
  
The greater-than heaped version of v1 is  
 ( 1 2 6 3 5 8 7 4 10 9 ).  
The greater-than heap v1 with 11 pushed back is  
 ( 1 2 6 3 5 8 7 4 10 9 0 ).  
The greater than reheaped v1 with 11 added is  
 ( 0 1 6 3 2 8 7 4 10 9 5 ).  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [heap](../vs140/heap.md)   
 [Standard Template Library](../vs140/standard-template-library.md)