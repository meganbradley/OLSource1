---
title: "set_symmetric_difference"
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
  - "std::set_symmetric_difference"
  - "set_symmetric_difference"
  - "algorithm/std::set_symmetric_difference"
  - "std.set_symmetric_difference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set_symmetric_difference function"
  - "set_symmetric_difference"
ms.assetid: 39c673df-ea67-4336-a60e-8729e69e2ee4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set_symmetric_difference
Unites all of the elements that belong to one, but not both, of the sorted source ranges into a single, sorted destination range, where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
```  
  
      template<class InputIterator1, class InputIterator2, class OutputIterator>  
   OutputIterator set_symmetric_difference(  
      InputIterator1 _First1,   
      InputIterator1 _Last1,  
      InputIterator2 _First2,   
      InputIterator2 _Last2,   
      OutputIterator _Result  
   );  
template<class InputIterator1, class InputIterator2, class OutputIterator, class BinaryPredicate>  
   OutputIterator set_symmetric_difference(  
      InputIterator1 _First1,   
      InputIterator1 _Last1,  
      InputIterator2 _First2,   
      InputIterator2 _Last2,   
      OutputIterator _Result,  
      BinaryPredicate _Comp  
   );  
```  
  
#### Parameters  
 `_First1`  
 An input iterator addressing the position of the first element in the first of two sorted source ranges to be united and sorted into a single range representing the symmetric difference of the two source ranges.  
  
 `_Last1`  
 An input iterator addressing the position one past the last element in the first of two sorted source ranges to be united and sorted into a single range representing the symmetric difference of the two source ranges.  
  
 `_First2`  
 An input iterator addressing the position of the first element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the symmetric difference of the two source ranges.  
  
 `_Last2`  
 An input iterator addressing the position one past the last element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the symmetric difference of the two source ranges.  
  
 **_** *Result*  
 An output iterator addressing the position of the first element in the destination range where the two source ranges are to be united into a single sorted range representing the symmetric difference of the two source ranges.  
  
 `_Comp`  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
## Return Value  
 An output iterator addressing the position one past the last element in the sorted destination range representing the symmetric difference of the two source ranges.  
  
## Remarks  
 The sorted source ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation.  
  
 The destination range should not overlap either of the source ranges and should be large enough to contain the destination range.  
  
 The sorted source ranges must each be arranged as a precondition to the application of the **merge** algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The operation is stable as the relative order of elements within each range is preserved in the destination range. The source ranges are not modified by the algorithm merge.  
  
 The value types of the input iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. When there are equivalent elements in both source ranges, the elements in the first range precede the elements from the second source range in the destination range. If the source ranges contain duplicates of an element, then the destination range will contain the absolute value of the number by which the occurrences of those elements in the one of the source ranges exceeds the occurrences of those elements in the second source range.  
  
 The complexity of the algorithm is linear with at most 2 \* ( (*_Last1 – _First1*) – (*_Last2 – _First2*) ) – 1 comparisons for nonempty source ranges.  
  
 `set_symmetric_difference` has two related forms:  
  
-   [checked_set_symmetric_difference](assetId:///5c3c699c-0f75-4a27-b1a1-2429f493682f)  
  
-   [unchecked_set_symmetric_difference](assetId:///344f059a-ddce-4d44-ade4-32c5a79e3d5f)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// alg_set_sym_diff.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>      // For greater<int>( )  
#include <iostream>  
  
// Return whether modulus of elem1 is less than modulus of elem2  
bool mod_lesser (int elem1, int elem2 )  
{  
   if ( elem1 < 0 )   
      elem1 = - elem1;  
   if ( elem2 < 0 )   
      elem2 = - elem2;  
   return elem1 < elem2;  
}  
  
int main( )  
{  
   using namespace std;  
   vector <int> v1a, v1b, v1 ( 12 );  
   vector <int>::iterator Iter1a,  Iter1b, Iter1, Result1;  
  
   // Constructing vectors v1a & v1b with default less-than ordering  
   int i;  
   for ( i = -1 ; i <= 4 ; i++ )  
   {  
      v1a.push_back(  i );  
   }  
  
   int ii;  
   for ( ii =-3 ; ii <= 0 ; ii++ )  
   {  
      v1b.push_back(  ii  );  
   }  
  
   cout << "Original vector v1a with range sorted by the\n "  
        <<  "binary predicate less than is  v1a = ( " ;  
   for ( Iter1a = v1a.begin( ) ; Iter1a != v1a.end( ) ; Iter1a++ )  
      cout << *Iter1a << " ";  
   cout << ")." << endl;  
  
   cout << "Original vector v1b with range sorted by the\n "  
        <<  "binary predicate less than is  v1b = ( " ;  
   for ( Iter1b = v1b.begin ( ) ; Iter1b != v1b.end ( ) ; Iter1b++ )  
      cout << *Iter1b << " ";  
   cout << ")." << endl;  
  
   // Constructing vectors v2a & v2b with ranges sorted by greater  
   vector <int> v2a ( v1a ) , v2b ( v1b ) ,  v2 ( v1 );  
   vector <int>::iterator Iter2a, Iter2b, Iter2, Result2;  
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
  
   // Constructing vectors v3a & v3b with ranges sorted by mod_lesser  
   vector <int> v3a ( v1a ), v3b ( v1b ) ,  v3 ( v1 );  
   vector <int>::iterator Iter3a, Iter3b, Iter3, Result3;  
   sort ( v3a.begin ( ) , v3a.end ( ) , mod_lesser );  
   sort ( v3b.begin ( ) , v3b.end ( ) , mod_lesser  );  
  
   cout << "Original vector v3a with range sorted by the\n "  
        <<  "binary predicate mod_lesser is   v3a =  ( " ;  
   for ( Iter3a = v3a.begin ( ) ; Iter3a != v3a.end ( ) ; Iter3a++ )  
      cout << *Iter3a << " ";  
   cout << ")." << endl;  
  
   cout << "Original vector v3b with range sorted by the\n "  
        <<  "binary predicate mod_lesser is   v3b =  ( " ;  
   for ( Iter3b = v3b.begin ( ) ; Iter3b != v3b.end ( ) ; Iter3b++ )  
      cout << *Iter3b << " ";  
   cout << ")." << endl;  
  
   // To combine into a symmetric difference in ascending  
   // order with the default binary predicate less <int> ( )  
   Result1 = set_symmetric_difference ( v1a.begin ( ) , v1a.end ( ) ,  
      v1b.begin ( ) , v1b.end ( ) , v1.begin ( ) );  
   cout << "Set_symmetric_difference of source ranges with default order,"  
        << "\n vector v1mod =  ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != Result1 ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // To combine into a symmetric difference in descending  
   // order, specify binary predicate greater<int>( )  
   Result2 = set_symmetric_difference ( v2a.begin ( ) , v2a.end ( ) ,  
      v2b.begin ( ) , v2b.end ( ) ,v2.begin ( ) , greater <int> ( ) );  
   cout << "Set_symmetric_difference of source ranges with binary"  
        << "predicate greater specified,\n vector v2mod  = ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != Result2 ; Iter2++ )  
      cout << *Iter2 << " ";  
   cout << ")." << endl;  
  
   // To combine into a symmetric difference applying a user  
   // defined binary predicate mod_lesser  
   Result3 = set_symmetric_difference ( v3a.begin ( ) , v3a.end ( ) ,  
      v3b.begin ( ) , v3b.end ( ) , v3.begin ( ) , mod_lesser );  
   cout << "Set_symmetric_difference of source ranges with binary "  
        << "predicate mod_lesser specified,\n vector v3mod  = ( " ; ;  
   for ( Iter3 = v3.begin( ) ; Iter3 != Result3 ; Iter3++ )  
      cout << *Iter3 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Output  
  
```  
Original vector v1a with range sorted by the  
 binary predicate less than is  v1a = ( -1 0 1 2 3 4 ).  
Original vector v1b with range sorted by the  
 binary predicate less than is  v1b = ( -3 -2 -1 0 ).  
Original vector v2a with range sorted by the  
 binary predicate greater is   v2a =  ( 4 3 2 1 0 -1 ).  
Original vector v2b with range sorted by the  
 binary predicate greater is   v2b =  ( 0 -1 -2 -3 ).  
Original vector v3a with range sorted by the  
 binary predicate mod_lesser is   v3a =  ( 0 -1 1 2 3 4 ).  
Original vector v3b with range sorted by the  
 binary predicate mod_lesser is   v3b =  ( 0 -1 -2 -3 ).  
Set_symmetric_difference of source ranges with default order,  
 vector v1mod =  ( -3 -2 1 2 3 4 ).  
Set_symmetric_difference of source ranges with binarypredicate greater specified,  
 vector v2mod  = ( 4 3 2 1 -2 -3 ).  
Set_symmetric_difference of source ranges with binary predicate mod_lesser specified,  
 vector v3mod  = ( 1 4 ).  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)