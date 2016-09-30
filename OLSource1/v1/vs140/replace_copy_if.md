---
title: "replace_copy_if"
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
  - "std::replace_copy_if"
  - "std.replace_copy_if"
  - "replace_copy_if"
  - "algorithm/std::replace_copy_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace_copy_if"
  - "replace_copy_if function"
ms.assetid: 3541f157-b8e0-4f83-bfdf-3e786ed26a3b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# replace_copy_if
Examines each element in a source range and replaces it if it satisfies a specified predicate while copying the result into a new destination range.  
  
## Syntax  
  
```  
  
   template<class InputIterator, class OutputIterator, class Predicate, class Type>  
OutputIterator replace_copy_if(  
   InputIterator _First,   
   InputIterator _Last,   
   OutputIterator _Result,   
   Predicate _Pred,   
   const Type& _Val  
);  
```  
  
#### Parameters  
 `_First`  
 An input iterator pointing to the position of the first element in the range from which elements are being replaced.  
  
 `_Last`  
 An input iterator pointing to the position one past the final element in the range from which elements are being replaced.  
  
 `_Result`  
 An output iterator pointing to the position of the first element in the destination range to which elements are being copied.  
  
 `_Pred`  
 The unary predicate that must be satisfied is the value of an element is to be replaced.  
  
 `_Val`  
 The new value being assigned to the elements whose old value satisfies the predicate.  
  
## Return Value  
 An output iterator pointing to the position one past the final element in the destination range to where the altered sequence of elements is being copied.  
  
## Remarks  
 The source and destination ranges referenced must not overlap and must both be valid: all pointers must be dereferenceable and within the sequences the last position is reachable from the first by incrementation.  
  
 The order of the elements not replaced remains stable.  
  
 The `operator==` used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear; there are (`_Last` – `_First`) comparisons for equality and at most (`_Last` – `_First`) assignments of new values.  
  
 `replace_copy_if` has two related forms:  
  
-   [checked_replace_copy_if](assetId:///f483ca68-2ca7-443b-8920-6a2d01af33e4)  
  
-   [unchecked_replace_copy_if](assetId:///6eb746dd-c2c6-4b22-ae04-c135124665fc)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// alg_replace_copy_if.cpp  
// compile with: /EHsc  
#include <vector>  
#include <list>  
#include <algorithm>  
#include <iostream>  
  
bool greater6 ( int value ) {  
   return value >6;  
}  
  
int main( ) {  
   using namespace std;  
   vector <int> v1;  
   list <int> L1 (13);  
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
   for ( iii = 0 ; iii <= 13 ; iii++ )  
      v1.push_back( 1 );  
  
   cout << "The original vector v1 is:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Replace elements with a value of 7 in the 1st half of a vector  
   // with a value of 70 and copy it into the 2nd half of the vector  
   replace_copy_if ( v1.begin( ), v1.begin( ) + 14,v1.end( ) -14,  
      greater6 , 70);  
  
   cout << "The vector v1 with values of 70 replacing those greater"  
        << "\n than 6 in the 1st half & copied into the 2nd half is:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Replace elements in a vector with a value of 70  
   // with a value of 1 and copy into a list  
   replace_copy_if ( v1.begin( ), v1.begin( ) + 13,L1.begin( ),  
      greater6 , -1 );  
  
   cout << "A list copy of vector v1 with the value -1\n replacing "  
        << "those greater than 6 is:\n ( " ;  
   for ( L_Iter1 = L1.begin( ) ; L_Iter1 != L1.end( ) ; L_Iter1++ )  
      cout << *L_Iter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Sample Output  
  
```  
The original vector v1 is:  
 ( 7 1 9 2 0 7 7 3 4 6 8 5 7 7 1 1 1 1 1 1 1 1 1 1 1 1 1 1 ).  
The vector v1 with values of 70 replacing those greater  
 than 6 in the 1st half & copied into the 2nd half is:  
 ( 7 1 9 2 0 7 7 3 4 6 8 5 7 7 70 1 70 2 0 70 70 3 4 6 70 5 70 70 ).  
A list copy of vector v1 with the value -1  
 replacing those greater than 6 is:  
 ( -1 1 -1 2 0 -1 -1 3 4 6 -1 5 -1 ).  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [replace_copy_if](../vs140/replace_copy_if--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)