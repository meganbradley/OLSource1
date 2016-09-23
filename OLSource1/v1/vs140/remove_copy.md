---
title: "remove_copy"
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
  - std::remove_copy
  - remove_copy
  - std.remove_copy
  - algorithm/std::remove_copy
dev_langs: 
  - C++
helpviewer_keywords: 
  - remove_copy function
  - remove_copy
ms.assetid: 04a5af2c-4d15-483e-9ee0-39812fb344c4
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# remove_copy
Copies elements from a source range to a destination range, except that elements of a specified value are not copied, without disturbing the order of the remaining elements and returning the end of a new destination range.  
  
## Syntax  
  
```  
  
   template<class InputIterator, class OutputIterator, class Type>  
OutputIterator remove_copy(  
   InputIterator _First,   
   InputIterator _Last,   
   OutputIterator _Result,  
   const Type& _Val  
);  
```  
  
#### Parameters  
 `_First`  
 An input iterator addressing the position of the first element in the range from which elements are being removed.  
  
 `_Last`  
 An input iterator addressing the position one past the final element in the range from which elements are being removed.  
  
 `_Result`  
 An output iterator addressing the position of the first element in the destination range to which elements are being removed.  
  
 `_Val`  
 The value that is to be removed from the range.  
  
## Return Value  
 A forward iterator addressing the new end position of the destination range, one past the final element of the copy of the remnant sequence free of the specified value.  
  
## Remarks  
 The source and destination ranges referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 There must be enough space in the destination range to contain the remnant elements that will be copied after elements of the specified value are removed.  
  
 The order of the elements not removed remains stable.  
  
 The `operator==` used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear; there are (`_Last` – `_First`) comparisons for equality and at most (`_Last` – `_First`) assignments.  
  
 `remove_copy` has two related forms:  
  
-   [checked_remove_copy](assetId:///1379d7c3-cad6-4599-b642-2d6102d739b4)  
  
-   [unchecked_remove_copy](assetId:///b4366b16-f494-49cf-b383-a82bbfe9de58)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// alg_remove_copy.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
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
  
   random_shuffle (v1.begin( ), v1.end( ) );  
   cout << "The original vector v1 is:     ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Remove elements with a value of 7  
   new_end = remove_copy ( v1.begin( ), v1.end( ), v2.begin( ), 7 );  
  
   cout << "Vector v1 is left unchanged as ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   cout << "Vector v2 is a copy of v1 with the value 7 removed:\n ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != v2.end( ) ; Iter2++ )  
      cout << *Iter2 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Sample Output  
  
```  
The original vector v1 is:     ( 7 1 9 2 0 7 7 3 4 6 8 5 7 7 ).  
Vector v1 is left unchanged as ( 7 1 9 2 0 7 7 3 4 6 8 5 7 7 ).  
Vector v2 is a copy of v1 with the value 7 removed:  
 ( 1 9 2 0 3 4 6 8 5 0 ).  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [remove_copy](../vs140/remove_copy--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)