---
title: "reverse_copy"
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
  - "algorithm/std::reverse_copy"
  - "std::reverse_copy"
  - "reverse_copy"
  - "std.reverse_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse_copy function"
  - "reverse_copy"
ms.assetid: 84567cb2-dc19-43a0-831f-6a03a85acb66
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_copy
Reverses the order of the elements within a source range while copying them into a destination range  
  
## Syntax  
  
```  
  
   template<class BidirectionalIterator, class OutputIterator>  
OutputIterator reverse_copy(  
   BidirectionalIterator _First,   
   BidirectionalIterator _Last,   
   OutputIterator _Result  
);  
```  
  
#### Parameters  
 `_First`  
 A bidirectional iterator pointing to the position of the first element in the source range within which the elements are being permuted.  
  
 `_Last`  
 A bidirectional iterator pointing to the position one past the final element in the source range within which the elements are being permuted.  
  
 `_Result`  
 An output iterator pointing to the position of the first element in the destination range to which elements are being copied.  
  
## Return Value  
 An output iterator pointing to the position one past the final element in the destination range to where the altered sequence of elements is being copied.  
  
## Remarks  
 The source and destination ranges referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 `reverse_copy` has two related forms:  
  
-   [checked_reverse_copy](assetId:///85080fe0-cccb-446b-92c2-0079a3521196)  
  
-   [unchecked_reverse_copy](assetId:///08096345-e103-4af3-b278-ba47f07f8d34)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// alg_reverse_copy.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
int main( ) {  
   using namespace std;  
   vector <int> v1, v2( 10 );  
   vector <int>::iterator Iter1, Iter2;  
  
   int i;  
   for ( i = 0 ; i <= 9 ; i++ )  
   {  
      v1.push_back( i );  
   }  
  
   cout << "The original vector v1 is:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Reverse the elements in the vector   
   reverse_copy (v1.begin( ), v1.end( ), v2.begin( ) );  
  
   cout << "The copy v2 of the reversed vector v1 is:\n ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != v2.end( ) ; Iter2++ )  
      cout << *Iter2 << " ";  
   cout << ")." << endl;  
  
   cout << "The original vector v1 remains unmodified as:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Output  
  
```  
The original vector v1 is:  
 ( 0 1 2 3 4 5 6 7 8 9 ).  
The copy v2 of the reversed vector v1 is:  
 ( 9 8 7 6 5 4 3 2 1 0 ).  
The original vector v1 remains unmodified as:  
 ( 0 1 2 3 4 5 6 7 8 9 ).  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_copy](../vs140/reverse_copy--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)