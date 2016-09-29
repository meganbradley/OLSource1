---
title: "copy_backward"
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
  - "std::copy_backward"
  - "xutility/std::copy_backward"
  - "std.copy_backward"
  - "copy_backward"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy_backward"
  - "copy_backward function"
ms.assetid: ddfab855-25a3-44db-a3cd-2b05ae97ea20
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copy_backward
Assigns the values of elements from a source range to a destination range, iterating through the source sequence of elements and assigning them new positions in a backward direction.  
  
## Syntax  
  
```  
  
   template<class BidirectionalIterator1, class BidirectionalIterator2>  
BidirectionalIterator2 copy_backward(  
   BidirectionalIterator1 _First,   
   BidirectionalIterator1 _Last,  
   BidirectionalIterator2 _DestEnd  
);  
```  
  
#### Parameters  
 `_First`  
 A bidirectional iterator addressing the position of the first element in the source range.  
  
 `_Last`  
 A bidirectional iterator addressing the position that is one past the final element in the source range.  
  
 `_DestEnd`  
 A bidirectional iterator addressing the position of one past the final element in the destination range.  
  
## Return Value  
 An output iterator addressing the position that is one past the final element in the destination range, that is, the iterator addresses `_DestEnd` – (`_Last` – `_First` ).  
  
## Remarks  
 The source range must be valid and there must be sufficient space at the destination to hold all the elements being copied.  
  
 The `copy_backward` algorithm imposes more stringent requirements than that the copy algorithm. Both its input and output iterators must be bidirectional.  
  
 The `copy_backward` and [move_backward](../vs140/move_backward.md) algorithms are the only Standard Template Library algorithms designating the output range with an iterator pointing to the end of the destination range.  
  
 Because the algorithm copies the source elements in order beginning with the last element, the destination range can overlap with the source range provided the `_First` position of the source range is not contained in the destination range. `copy_backward` can be used to shift elements to the right but not the left, unless there is no overlap between the source and destination ranges. To shift to the left any number of positions, use the [copy](../vs140/copy.md) algorithm.  
  
 The `copy_backward` algorithm only modifies values pointed to by the iterators, assigning new values to elements in the destination range. It cannot be used to create new elements and cannot insert elements into an empty container directly.  
  
## Example  
  
```cpp  
// alg_copy_bkwd.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
int main() {  
   using namespace std;  
   vector <int> v1, v2;  
   vector <int>::iterator Iter1, Iter2;  
  
   int i;  
   for ( i = 0 ; i <= 5 ; ++i )  
      v1.push_back( 10 * i );  
  
   int ii;  
   for ( ii = 0 ; ii <= 10 ; ++ii )  
      v2.push_back( 3 * ii );  
  
   cout << "v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; ++Iter1 )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   cout << "v2 = ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != v2.end( ) ; ++Iter2 )  
      cout << *Iter2 << " ";  
   cout << ")" << endl;  
  
   // To copy_backward the first 3 elements of v1 into the middle of v2  
   copy_backward( v1.begin( ), v1.begin( ) + 3, v2.begin( ) + 7 );  
  
   cout << "v2 with v1 insert = ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != v2.end( ) ; ++Iter2 )  
      cout << *Iter2 << " ";  
   cout << ")" << endl;  
  
   // To shift the elements inserted into v2 two positions  
   // to the right  
   copy_backward( v2.begin( )+4, v2.begin( ) + 7, v2.begin( ) + 9 );  
  
   cout << "v2 with shifted insert = ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != v2.end( ) ; ++Iter2 )  
      cout << *Iter2 << " ";  
   cout << ")" << endl;  
}  
```  
  
## Output  
  
```  
v1 = ( 0 10 20 30 40 50 )  
v2 = ( 0 3 6 9 12 15 18 21 24 27 30 )  
v2 with v1 insert = ( 0 3 6 9 0 10 20 21 24 27 30 )  
v2 with shifted insert = ( 0 3 6 9 0 10 0 10 20 27 30 )  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [move_backward](../vs140/move_backward.md)   
 [Standard Template Library](../vs140/standard-template-library.md)