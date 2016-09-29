---
title: "merge"
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
  - "merge"
  - "std::merge"
  - "std.merge"
  - "algorithm/std::merge"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "merge function"
  - "merge"
ms.assetid: f5181f62-4d2f-485f-90c6-6ae92e7bf4d7
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# merge
Combines all of the elements from two sorted source ranges into a single, sorted destination range, where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
```  
  
      template<class InputIterator1, class InputIterator2, class OutputIterator>  
   OutputIterator merge(  
      InputIterator1 _First1,   
      InputIterator1 _Last1,  
      InputIterator2 _First2,   
      InputIterator2 _Last2,   
      OutputIterator _Result  
   );  
template<class InputIterator1, class InputIterator2, class OutputIterator, class BinaryPredicate>  
   OutputIterator merge(  
      InputIterator1 _First1,   
      InputIterator1 _Last1,  
      InputIterator2 _First2,   
      InputIterator2 _Last2,   
      OutputIterator _Result  
      BinaryPredicate _Comp  
   );  
```  
  
#### Parameters  
 `_First1`  
 An input iterator addressing the position of the first element in the first of two sorted source ranges to be combined and sorted into a single range.  
  
 `_Last1`  
 An input iterator addressing the position one past the last element in the first of two sorted source ranges to be combined and sorted into a single range.  
  
 `_First2`  
 An input iterator addressing the position of the first element in second of two consecutive sorted source ranges to be combined and sorted into a single range.  
  
 `_Last2`  
 An input iterator addressing the position one past the last element in second of two consecutive sorted source ranges to be combined and sorted into a single range.  
  
 `_Result`  
 An output iterator addressing the position of the first element in the destination range where the two source ranges are to be combined into a single sorted range.  
  
 `_Comp`  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
## Return Value  
 An output iterator addressing the position one past the last element in the sorted destination range.  
  
## Remarks  
 The sorted source ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation.  
  
 The destination range should not overlap either of the source ranges and should be large enough to contain the destination range.  
  
 The sorted source ranges must each be arranged as a precondition to the application of the **merge** algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The operation is stable as the relative order of elements within each range is preserved in the destination range. The source ranges are not modified by the algorithm **merge**.  
  
 The value types of the input iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. When there are equivalent elements in both source ranges, the elements in the first range precede the elements from the second source range in the destination range.  
  
 The complexity of the algorithm is linear with at most (*_Last1 – _First1*) – (*_Last2 – _First2*) – 1 comparisons.  
  
 The [list](../vs140/list-class.md) class provides a member function [merge](../vs140/list--merge.md) to merge the elements of two lists.  
  
 `merge` has two related forms:  
  
 [checked_merge](assetId:///48c4d215-e7e2-4ae6-94a2-68a17319d28f)  
  
 [unchecked_merge](assetId:///a82bb917-0d83-4959-9c8f-a73548e6162f)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// alg_merge.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>   // For greater<int>( )  
#include <iostream>  
  
// Return whether modulus of elem1 is less than modulus of elem2  
bool mod_lesser ( int elem1, int elem2 ) {  
   if (elem1 < 0)   
      elem1 = - elem1;  
   if (elem2 < 0)   
      elem2 = - elem2;  
   return elem1 < elem2;  
}  
  
int main() {  
   using namespace std;  
   vector <int> v1a, v1b, v1 ( 12 );  
   vector <int>::iterator Iter1a,  Iter1b, Iter1;  
  
   // Constructing vector v1a and v1b with default less than ordering  
   int i;  
   for ( i = 0 ; i <= 5 ; i++ )  
      v1a.push_back(  i );  
  
   int ii;  
   for ( ii =-5 ; ii <= 0 ; ii++ )  
      v1b.push_back(  ii  );  
  
   cout << "Original vector v1a with range sorted by the\n "  
        << "binary predicate less than is  v1a = ( " ;  
   for ( Iter1a = v1a.begin( ) ; Iter1a != v1a.end( ) ; Iter1a++ )  
      cout << *Iter1a << " ";  
   cout << ")." << endl;  
  
   cout << "Original vector v1b with range sorted by the\n "  
        << "binary predicate less than is  v1b = ( " ;  
   for ( Iter1b = v1b.begin ( ) ; Iter1b != v1b.end ( ) ; Iter1b++ )  
      cout << *Iter1b << " ";  
   cout << ")." << endl;  
  
   // Constructing vector v2 with ranges sorted by greater  
   vector <int> v2a ( v1a ) , v2b ( v1b ) ,  v2 ( v1 );  
   vector <int>::iterator Iter2a,  Iter2b, Iter2;  
   sort ( v2a.begin ( ) , v2a.end ( ) , greater<int> ( ) );  
   sort ( v2b.begin ( ) , v2b.end ( ) , greater<int> ( ) );  
  
   cout << "Original vector v2a with range sorted by the\n "  
        <<  "binary predicate greater is   v2a =  ( " ;  
   for ( Iter2a = v2a.begin ( ) ; Iter2a != v2a.end ( ) ; Iter2a++ )  
      cout << *Iter2a << " ";  
   cout << ")." << endl;  
  
   cout << "Original vector v2b with range sorted by the\n "  
        <<  "binary predicate greater is   v2b =  ( " ;  
   for ( Iter2b = v2b.begin ( ) ; Iter2b != v2b.end ( ) ; Iter2b++ )  
      cout << *Iter2b << " ";  
   cout << ")." << endl;  
  
   // Constructing vector v3 with ranges sorted by mod_lesser  
   vector <int> v3a ( v1a ), v3b ( v1b ) ,  v3 ( v1 );  
   vector <int>::iterator Iter3a,  Iter3b, Iter3;  
   sort ( v3a.begin ( ) , v3a.end ( ) , mod_lesser );  
   sort ( v3b.begin ( ) , v3b.end ( ) , mod_lesser );  
  
   cout << "Original vector v3a with range sorted by the\n "  
        << "binary predicate mod_lesser is   v3a =  ( " ;  
   for ( Iter3a = v3a.begin ( ) ; Iter3a != v3a.end ( ) ; Iter3a++ )  
      cout << *Iter3a << " ";  
   cout << ")." << endl;  
  
   cout << "Original vector v3b with range sorted by the\n "  
        << "binary predicate mod_lesser is   v3b =  ( " ;  
   for ( Iter3b = v3b.begin ( ) ; Iter3b != v3b.end ( ) ; Iter3b++ )  
      cout << *Iter3b << " ";  
   cout << ")." << endl;  
  
   // To merge inplace in ascending order with default binary   
   // predicate less <int> ( )  
   merge ( v1a.begin ( ) , v1a.end ( ) , v1b.begin ( ) , v1b.end ( ) , v1.begin ( ) );  
   cout << "Merged inplace with default order,\n vector v1mod =  ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // To merge inplace in descending order, specify binary   
   // predicate greater<int>( )  
   merge ( v2a.begin ( ) , v2a.end ( ) , v2b.begin ( ) , v2b.end ( ) ,  
       v2.begin ( ) ,  greater <int> ( ) );  
   cout << "Merged inplace with binary predicate greater specified,\n "  
        << "vector v2mod  = ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != v2.end( ) ; Iter2++ )  
      cout << *Iter2 << " ";  
   cout << ")." << endl;  
  
   // Applying A user-defined (UD) binary predicate mod_lesser  
   merge ( v3a.begin ( ) , v3a.end ( ) , v3b.begin ( ) , v3b.end ( ) ,  
       v3.begin ( ) ,  mod_lesser );  
   cout << "Merged inplace with binary predicate mod_lesser specified,\n "  
        << "vector v3mod  = ( " ; ;  
   for ( Iter3 = v3.begin( ) ; Iter3 != v3.end( ) ; Iter3++ )  
      cout << *Iter3 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Output  
  
```  
Original vector v1a with range sorted by the  
 binary predicate less than is  v1a = ( 0 1 2 3 4 5 ).  
Original vector v1b with range sorted by the  
 binary predicate less than is  v1b = ( -5 -4 -3 -2 -1 0 ).  
Original vector v2a with range sorted by the  
 binary predicate greater is   v2a =  ( 5 4 3 2 1 0 ).  
Original vector v2b with range sorted by the  
 binary predicate greater is   v2b =  ( 0 -1 -2 -3 -4 -5 ).  
Original vector v3a with range sorted by the  
 binary predicate mod_lesser is   v3a =  ( 0 1 2 3 4 5 ).  
Original vector v3b with range sorted by the  
 binary predicate mod_lesser is   v3b =  ( 0 -1 -2 -3 -4 -5 ).  
Merged inplace with default order,  
 vector v1mod =  ( -5 -4 -3 -2 -1 0 0 1 2 3 4 5 ).  
Merged inplace with binary predicate greater specified,  
 vector v2mod  = ( 5 4 3 2 1 0 0 -1 -2 -3 -4 -5 ).  
Merged inplace with binary predicate mod_lesser specified,  
 vector v3mod  = ( 0 0 1 -1 2 -2 3 -3 4 -4 5 -5 ).  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [merge](../vs140/merge--stl-samples-.md)   
 [Predicate Version of merge](../vs140/predicate-version-of-merge.md)   
 [Standard Template Library](../vs140/standard-template-library.md)