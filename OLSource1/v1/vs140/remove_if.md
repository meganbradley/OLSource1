---
title: "remove_if"
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
  - remove_if
  - std.remove_if
  - algorithm/std::remove_if
  - std::remove_if
dev_langs: 
  - C++
helpviewer_keywords: 
  - remove_if function
  - remove_if
ms.assetid: 3b784953-0db6-42a8-84fc-865101abf901
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# remove_if
Eliminates elements that satisfy a predicate from a given range without disturbing the order of the remaining elements and returning the end of a new range free of the specified value.  
  
## Syntax  
  
```  
  
   template<class ForwardIterator, class Predicate>  
ForwardIterator remove_if(  
   ForwardIterator _First,   
   ForwardIterator _Last,  
   Predicate _Pred  
);  
```  
  
#### Parameters  
 `_First`  
 A forward iterator pointing to the position of the first element in the range from which elements are being removed.  
  
 `_Last`  
 A forward iterator pointing to the position one past the final element in the range from which elements are being removed.  
  
 `_Pred`  
 The unary predicate that must be satisfied is the value of an element is to be replaced.  
  
## Return Value  
 A forward iterator addressing the new end position of the modified range, one past the final element of the remnant sequence free of the specified value.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The order of the elements not removed remains stable.  
  
 The `operator==` used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear: there are (`_Last` – `_First`) comparisons for equality.  
  
 List has a more efficient member function version of remove which relinks pointers.  
  
## Example  
  
```  
// alg_remove_if.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
bool greater6 ( int value ) {  
   return value >6;  
}  
  
int main( ) {  
   using namespace std;  
   vector <int> v1, v2;  
   vector <int>::iterator Iter1, Iter2, new_end;  
  
   int i;  
   for ( i = 0 ; i <= 9 ; i++ )  
      v1.push_back( i );  
  
   int ii;  
   for ( ii = 0 ; ii <= 3 ; ii++ )  
      v1.push_back( 7 );  
  
   random_shuffle ( v1.begin( ), v1.end( ) );  
   cout << "Vector v1 is ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Remove elements satisfying predicate greater6  
   new_end = remove_if (v1.begin( ), v1.end( ), greater6 );  
  
   cout << "Vector v1 with elements satisfying greater6 removed is\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // To change the sequence size, use erase  
   v1.erase (new_end, v1.end( ) );  
  
   cout << "Vector v1 resized elements satisfying greater6 removed is\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Sample Output  
  
```  
Vector v1 is ( 7 1 9 2 0 7 7 3 4 6 8 5 7 7 ).  
Vector v1 with elements satisfying greater6 removed is  
 ( 1 2 0 3 4 6 5 3 4 6 8 5 7 7 ).  
Vector v1 resized elements satisfying greater6 removed is  
 ( 1 2 0 3 4 6 5 ).  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [remove_if](../vs140/remove_if--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)