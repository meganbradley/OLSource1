---
title: "unique_copy"
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
  - "unique_copy"
  - "std::unique_copy"
  - "std.unique_copy"
  - "algorithm/std::unique_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unique_copy function"
  - "unique_copy"
ms.assetid: cdbc77b9-81d8-4453-88f5-e701b6dae02d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_copy
Copies elements from a source range into a destination range except for the duplicate elements that are adjacent to each other.  
  
## Syntax  
  
```  
  
      template<class InputIterator, class OutputIterator>  
   OutputIterator unique_copy(  
      InputIterator _First,   
      InputIterator _Last,   
      OutputIterator _Result  
   );  
template<class InputIterator, class OutputIterator, class BinaryPredicate>  
   OutputIterator unique_copy(  
      InputIterator _First,   
      InputIterator _Last,   
      OutputIterator _Result,  
      BinaryPredicate _Comp,  
   );  
```  
  
#### Parameters  
 `_First`  
 A forward iterator addressing the position of the first element in the source range to be copied.  
  
 `_Last`  
 A forward iterator addressing the position one past the final element in the source range to be copied.  
  
 `_Result`  
 An output iterator addressing the position of the first element in the destination range that is receiving the copy with consecutive duplicates removed.  
  
 `_Comp`  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 An output iterator addressing the position one past the final element in the destination range that is receiving the copy with consecutive duplicates removed.  
  
## Remarks  
 Both forms of the algorithm remove the second duplicate of a consecutive pair of equal elements.  
  
 The operation of the algorithm is stable so that the relative order of the undeleted elements is not changed.  
  
 The ranges referenced must be valid; all pointers must be dereferenceable and within a sequence the last position is reachable from the first by incrementation.  
  
 The complexity is linear, requiring (`_Last` – `_First`) comparisons.  
  
 `unique_copy` has two related forms:  
  
-   [checked_unique_copy](assetId:///e2fa08a7-9eff-4f3f-ba42-7bdff0a57b76)  
  
-   [unchecked_unique_copy](assetId:///408c5952-abc0-4374-8145-5d9c720bcc43)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// alg_unique_copy.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>  
#include <iostream>  
#include <ostream>  
  
using namespace std;  
  
// Return whether modulus of elem1 is equal to modulus of elem2  
bool mod_equal ( int elem1, int elem2 ) {  
   if ( elem1 < 0 )   
      elem1 = - elem1;  
   if ( elem2 < 0 )   
      elem2 = - elem2;  
   return elem1 == elem2;  
};  
  
int main() {  
   vector <int> v1;  
   vector <int>::iterator v1_Iter1, v1_Iter2,  
         v1_NewEnd1, v1_NewEnd2;  
  
   int i;  
   for ( i = 0 ; i <= 1 ; i++ ) {  
      v1.push_back( 5 );  
      v1.push_back( -5 );  
   }  
  
   int ii;  
   for ( ii = 0 ; ii <= 2 ; ii++ )  
      v1.push_back( 4 );  
   v1.push_back( 7 );  
  
   int iii;  
   for ( iii = 0 ; iii <= 5 ; iii++ )  
      v1.push_back( 10 );  
  
   cout << "Vector v1 is\n ( " ;  
   for ( v1_Iter1 = v1.begin( ) ; v1_Iter1 != v1.end( ) ; v1_Iter1++ )  
      cout << *v1_Iter1 << " ";  
   cout << ")." << endl;  
  
   // Copy first half to second, removing consecutive duplicates  
   v1_NewEnd1 = unique_copy ( v1.begin ( ) , v1.begin ( ) + 8, v1.begin ( ) + 8 );  
  
   cout << "Copying the first half of the vector to the second half\n "  
        << "while removing adjacent duplicates gives\n ( " ;  
   for ( v1_Iter1 = v1.begin( ) ; v1_Iter1 != v1_NewEnd1 ; v1_Iter1++ )  
      cout << *v1_Iter1 << " ";  
   cout << ")." << endl;  
  
   int iv;  
   for ( iv = 0 ; iv <= 7 ; iv++ )  
      v1.push_back( 10 );  
  
   // Remove consecutive duplicates under the binary prediate mod_equals  
   v1_NewEnd2 = unique_copy ( v1.begin ( ) , v1.begin ( ) + 14,   
      v1.begin ( ) + 14 , mod_equal );  
  
   cout << "Copying the first half of the vector to the second half\n "  
        << " removing adjacent duplicates under mod_equals gives\n ( " ;  
   for ( v1_Iter2 = v1.begin( ) ; v1_Iter2 != v1_NewEnd2 ; v1_Iter2++ )  
      cout << *v1_Iter2 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Output  
  
```  
Vector v1 is  
 ( 5 -5 5 -5 4 4 4 7 10 10 10 10 10 10 ).  
Copying the first half of the vector to the second half  
 while removing adjacent duplicates gives  
 ( 5 -5 5 -5 4 4 4 7 5 -5 5 -5 4 7 ).  
Copying the first half of the vector to the second half  
  removing adjacent duplicates under mod_equals gives  
 ( 5 -5 5 -5 4 4 4 7 5 -5 5 -5 4 7 5 4 7 5 4 7 ).  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)