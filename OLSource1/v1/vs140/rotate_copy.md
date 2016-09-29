---
title: "rotate_copy"
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
  - "std.rotate_copy"
  - "algorithm/std::rotate_copy"
  - "std::rotate_copy"
  - "rotate_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rotate_copy function"
  - "rotate_copy"
ms.assetid: 06c5bb1d-3b44-4c06-8f39-e926c0829bae
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rotate_copy
Exchanges the elements in two adjacent ranges within a source range and copies the result to a destination range.  
  
## Syntax  
  
```  
  
   template<class ForwardIterator, class OutputIterator>  
OutputIterator rotate_copy(  
   ForwardIterator _First,   
   ForwardIterator _Middle,  
   ForwardIterator _Last,   
   OutputIterator _Result  
);  
```  
  
#### Parameters  
 `_First`  
 A forward iterator addressing the position of the first element in the range to be rotated.  
  
 `_Middle`  
 A forward iterator defining the boundary within the range that addresses the position of the first element in the second part of the range whose elements are to be exchanged with those in the first part of the range.  
  
 _ `Last`  
 A forward iterator addressing the position one past the final element in the range to be rotated.  
  
 `_Result`  
 An output iterator addressing the position of the first element in the destination range.  
  
## Return Value  
 An output iterator addressing the position one past the final element in the destination range.  
  
## Remarks  
 The ranges referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The complexity is linear with at most (`_Last` – `_First`) swaps.  
  
 `rotate_copy` has two related forms:  
  
-   [checked_rotate_copy](assetId:///a0f70a3e-a86d-4edb-90d6-728457fe8759)  
  
-   [unchecked_rotate_copy](assetId:///6556e8d8-f3a9-4931-bbcc-704f0f0a1b34)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// alg_rotate_copy.cpp  
// compile with: /EHsc  
#include <vector>  
#include <deque>  
#include <algorithm>  
#include <iostream>  
  
int main() {  
   using namespace std;  
   vector <int> v1 , v2 ( 9 );  
   deque <int> d1 , d2 ( 6 );  
   vector <int>::iterator v1Iter , v2Iter;  
   deque<int>::iterator d1Iter , d2Iter;  
  
   int i;  
   for ( i = -3 ; i <= 5 ; i++ )  
      v1.push_back( i );  
  
   int ii;  
   for ( ii =0 ; ii <= 5 ; ii++ )  
      d1.push_back( ii );  
  
   cout << "Vector v1 is ( " ;  
   for ( v1Iter = v1.begin( ) ; v1Iter != v1.end( ) ;v1Iter ++ )  
      cout << *v1Iter  << " ";  
   cout << ")." << endl;  
  
   rotate_copy ( v1.begin ( ) , v1.begin ( ) + 3 , v1.end ( ) , v2.begin ( ) );  
   cout << "After rotating, the vector v1 remains unchanged as:\n v1 = ( " ;  
   for ( v1Iter = v1.begin( ) ; v1Iter != v1.end( ) ;v1Iter ++ )  
      cout << *v1Iter  << " ";  
   cout << ")." << endl;  
  
   cout << "After rotating, the copy of vector v1 in v2 is:\n v2 = ( " ;  
   for ( v2Iter = v2.begin( ) ; v2Iter != v2.end( ) ;v2Iter ++ )  
      cout << *v2Iter  << " ";  
   cout << ")." << endl;  
  
   cout << "The original deque d1 is ( " ;  
   for ( d1Iter = d1.begin( ) ; d1Iter != d1.end( ) ;d1Iter ++ )  
      cout << *d1Iter  << " ";  
   cout << ")." << endl;  
  
   int iii = 1;  
   while ( iii <= d1.end ( ) - d1.begin ( ) )  
   {  
      rotate_copy ( d1.begin ( ) , d1.begin ( ) + iii , d1.end ( ) , d2.begin ( ) );  
      cout << "After the rotation of a single deque element to the back,\n d2 is   ( " ;  
      for ( d2Iter = d2.begin( ) ; d2Iter != d2.end( ) ;d2Iter ++ )  
         cout << *d2Iter  << " ";  
      cout << ")." << endl;  
      iii++;  
   }  
}  
```  
  
## Output  
  
```  
Vector v1 is ( -3 -2 -1 0 1 2 3 4 5 ).  
After rotating, the vector v1 remains unchanged as:  
 v1 = ( -3 -2 -1 0 1 2 3 4 5 ).  
After rotating, the copy of vector v1 in v2 is:  
 v2 = ( 0 1 2 3 4 5 -3 -2 -1 ).  
The original deque d1 is ( 0 1 2 3 4 5 ).  
After the rotation of a single deque element to the back,  
 d2 is   ( 1 2 3 4 5 0 ).  
After the rotation of a single deque element to the back,  
 d2 is   ( 2 3 4 5 0 1 ).  
After the rotation of a single deque element to the back,  
 d2 is   ( 3 4 5 0 1 2 ).  
After the rotation of a single deque element to the back,  
 d2 is   ( 4 5 0 1 2 3 ).  
After the rotation of a single deque element to the back,  
 d2 is   ( 5 0 1 2 3 4 ).  
After the rotation of a single deque element to the back,  
 d2 is   ( 0 1 2 3 4 5 ).  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [rotate_copy](../vs140/rotate_copy--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)