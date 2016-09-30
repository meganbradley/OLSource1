---
title: "replace_copy"
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
  - "std::replace_copy"
  - "algorithm/std::replace_copy"
  - "replace_copy"
  - "std.replace_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace_copy"
  - "replace_copy function"
ms.assetid: 2493e702-894c-4798-87a1-0138cc348e6f
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# replace_copy
Examines each element in a source range and replaces it if it matches a specified value while copying the result into a new destination range.  
  
## Syntax  
  
```  
  
   template<class InputIterator, class OutputIterator, class Type>  
OutputIterator replace_copy(  
   InputIterator _First,   
   InputIterator _Last,   
   OutputIterator _Result,  
   const Type& _OldVal,   
   const Type& _NewVal  
);  
```  
  
#### Parameters  
 `_First`  
 An input iterator pointing to the position of the first element in the range from which elements are being replaced.  
  
 `_Last`  
 An input iterator pointing to the position one past the final element in the range from which elements are being replaced.  
  
 `_Result`  
 An output iterator pointing to the first element in the destination range to where the altered sequence of elements is being copied.  
  
 `_OldVal`  
 The old value of the elements being replaced.  
  
 `_NewVal`  
 The new value being assigned to the elements with the old value.  
  
## Return Value  
 An output iterator pointing to the position one past the final element in the destination range to where the altered sequence of elements is being copied.  
  
## Remarks  
 The source and destination ranges referenced must not overlap and must both be valid: all pointers must be dereferenceable and within the sequences the last position is reachable from the first by incrementation.  
  
 The order of the elements not replaced remains stable.  
  
 The `operator==` used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear: there are (`_Last` – `_First`) comparisons for equality and at most (`_Last` – `_First`) assignments of new values.  
  
 `replace_copy` has two related forms:  
  
-   [checked_replace_copy](assetId:///303b3494-5409-4d68-80ad-8224da992f73)  
  
-   [unchecked_replace_copy](assetId:///67d61275-b132-4d32-bdc7-a2b8eb5aa48f)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// alg_replace_copy.cpp  
// compile with: /EHsc  
#include <vector>  
#include <list>  
#include <algorithm>  
#include <iostream>  
  
int main( ) {  
   using namespace std;  
   vector <int> v1;  
   list <int> L1 (15);  
   vector <int>::iterator Iter1;  
   list <int>::iterator L_Iter1;  
  
   int i;  
   for ( i = 0 ; i <= 9 ; i++ )  
      v1.push_back( i );  
  
   int ii;  
   for ( ii = 0 ; ii <= 3 ; ii++ )  
      v1.push_back( 7 );  
  
   random_shuffle ( v1.begin( ), v1.end( ) );  
  
   int iii;  
   for ( iii = 0 ; iii <= 15 ; iii++ )  
      v1.push_back( 1 );  
  
   cout << "The original vector v1 is:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Replace elements in one part of a vector with a value of 7  
   // with a value of 70 and copy into another part of the vector  
   replace_copy ( v1.begin( ), v1.begin( ) + 14,v1.end( ) -15, 7 , 70);  
  
   cout << "The vector v1 with a value 70 replacing that of 7 is:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Replace elements in a vector with a value of 70  
   // with a value of 1 and copy into a list  
   replace_copy ( v1.begin( ), v1.begin( ) + 14,L1.begin( ), 7 , 1);  
  
   cout << "The list copy L1 of v1 with the value 0 replacing "  
        << "that of 7 is:\n ( " ;  
   for ( L_Iter1 = L1.begin( ) ; L_Iter1 != L1.end( ) ; L_Iter1++ )  
      cout << *L_Iter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Sample Output  
  
```  
The original vector v1 is:  
 ( 7 1 9 2 0 7 7 3 4 6 8 5 7 7 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 ).  
The vector v1 with a value 70 replacing that of 7 is:  
 ( 7 1 9 2 0 7 7 3 4 6 8 5 7 7 1 70 1 9 2 0 70 70 3 4 6 8 5 70 70 1 ).  
The list copy L1 of v1 with the value 0 replacing that of 7 is:  
 ( 1 1 9 2 0 1 1 3 4 6 8 5 1 1 0 ).  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [replace_copy](../vs140/replace_copy--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)