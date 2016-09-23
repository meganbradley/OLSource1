---
title: "remove_copy_if"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - algorithm/std::remove_copy_if
  - remove_copy_if
  - std.remove_copy_if
  - std::remove_copy_if
dev_langs: 
  - C++
helpviewer_keywords: 
  - remove_copy_if function
  - remove_copy_if
ms.assetid: 76b1e0d6-26a8-4adb-a55e-c179fa4e2dac
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# remove_copy_if
Copies elements from a source range to a destination range, except that satisfying a predicate are not copied, without disturbing the order of the remaining elements and returning the end of a new destination range.  
  
## Syntax  
  
```  
  
   template<class InputIterator, class OutputIterator, class Predicate>  
OutputIterator remove_copy_if(  
   InputIterator _First,   
   InputIterator _Last,   
   OutputIterator _Result,  
   Predicate _Pred  
);  
```  
  
#### Parameters  
 `_First`  
 An input iterator addressing the position of the first element in the range from which elements are being removed.  
  
 `_Last`  
 An input iterator addressing the position one past the final element in the range from which elements are being removed.  
  
 `_Result`  
 An output iterator addressing the position of the first element in the destination range to which elements are being removed.  
  
 `_Pred`  
 The unary predicate that must be satisfied is the value of an element is to be replaced.  
  
## Return Value  
 A forward iterator addressing the new end position of the destination range, one past the final element of the remnant sequence free of the elements satisfying the predicate.  
  
## Remarks  
 The source range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 There must be enough space in the destination range to contain the remnant elements that will be copied after elements of the specified value are removed.  
  
 The order of the elements not removed remains stable.  
  
 The `operator==` used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear: there are (`_Last` – `_First`) comparisons for equality and at most (`_Last` – `_First`) assignments.  
  
 `remove_copy_if` has two related forms:  
  
-   [checked_remove_copy_if](assetId:///ef1b5d4a-61e2-4000-a991-3a8c4512b574)  
  
-   [unchecked_remove_copy_if](assetId:///dd0a223e-572b-4595-aa7f-d8aa6c4558b8)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// alg_remove_copy_if.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
bool greater6 ( int value ) {  
   return value >6;  
}  
  
int main() {  
   using namespace std;  
   vector <int> v1, v2(10);  
   vector <int>::iterator Iter1, Iter2, new_end;  
  
   int i;  
   for ( i = 0 ; i <= 9 ; i++ )  
      v1.push_back( i );  
  
   int ii;  
   for ( ii = 0 ; ii <= 3 ; ii++ )  
      v1.push_back( 7 );  
  
   random_shuffle ( v1.begin( ), v1.end( ) );  
   cout << "The original vector v1 is:      ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Remove elements with a value greater than 6  
   new_end = remove_copy_if ( v1.begin( ), v1.end( ),   
      v2.begin( ), greater6 );  
  
   cout << "After the appliation of remove_copy_if to v1,\n "  
        << "vector v1 is left unchanged as ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   cout << "Vector v2 is a copy of v1 with values greater "  
        << "than 6 removed:\n ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != new_end ; Iter2++ )  
      cout << *Iter2 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Sample Output  
  
```  
The original vector v1 is:      ( 7 1 9 2 0 7 7 3 4 6 8 5 7 7 ).  
After the appliation of remove_copy_if to v1,  
 vector v1 is left unchanged as ( 7 1 9 2 0 7 7 3 4 6 8 5 7 7 ).  
Vector v2 is a copy of v1 with values greater than 6 removed:  
 ( 1 2 0 3 4 6 5 ).  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [remove_copy_if](../vs140/remove_copy_if--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)