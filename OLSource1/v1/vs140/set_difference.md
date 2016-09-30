---
title: "set_difference"
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
  - "set_difference"
  - "std::set_difference"
  - "std.set_difference"
  - "algorithm/std::set_difference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set_difference function"
  - "set_difference"
ms.assetid: cd96abfe-5028-47de-ae29-cb9aa4a0acf3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set_difference
Unites all of the elements that belong to one sorted source range, but not to a second sorted source range, into a single, sorted destination range, where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
```  
  
      template<class InputIterator1, class InputIterator2, class OutputIterator>  
   OutputIterator set_difference(  
      InputIterator1 first1,   
      InputIterator1 last1,  
      InputIterator2 first2,   
      InputIterator2 last2,   
      OutputIterator result  
   );  
template<class InputIterator1, class InputIterator2, class OutputIterator, class BinaryPredicate>  
   OutputIterator set_difference(  
      InputIterator1 first1,   
      InputIterator1 last1,  
      InputIterator2 first2,   
      InputIterator2 last2,   
      OutputIterator result,  
      BinaryPredicate comp  
   );  
```  
  
#### Parameters  
 `first1`  
 An input iterator addressing the position of the first element in the first of two sorted source ranges to be united and sorted into a single range representing the difference of the two source ranges.  
  
 `last1`  
 An input iterator addressing the position one past the last element in the first of two sorted source ranges to be united and sorted into a single range representing the difference of the two source ranges.  
  
 `first2`  
 An input iterator addressing the position of the first element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the difference of the two source ranges.  
  
 `last2`  
 An input iterator addressing the position one past the last element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the difference of the two source ranges.  
  
 `result`  
 An output iterator addressing the position of the first element in the destination range where the two source ranges are to be united into a single sorted range representing the difference of the two source ranges.  
  
 `comp`  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
## Return Value  
 An output iterator addressing the position one past the last element in the sorted destination range representing the difference of the two source ranges.  
  
## Remarks  
 The sorted source ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation.  
  
 The destination range should not overlap either of the source ranges and should be large enough to contain the first source range.  
  
 The sorted source ranges must each be arranged as a precondition to the application of the `set_difference` algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The operation is stable as the relative order of elements within each range is preserved in the destination range. The source ranges are not modified by the algorithm merge.  
  
 The value types of the input iterators need be less-than-comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. When there are equivalent elements in both source ranges, the elements in the first range precede the elements from the second source range in the destination range. If the source ranges contain duplicates of an element such that there are more in the first source range than in the second, then the destination range will contain the number by which the occurrences of those elements in the first source range exceed the occurrences of those elements in the second source range.  
  
 The complexity of the algorithm is linear with at most 2 \* ( (*last1 – first1*) – (*last2 – first2*) ) – 1 comparisons for nonempty source ranges.  
  
 `set_difference` has two related forms:  
  
-   [checked_set_difference](assetId:///6f5dc1d6-4a1f-4fdb-be14-22cef40eb84d)  
  
-   [unchecked_set_difference](assetId:///6e5abff6-9e79-48ef-9607-7ca2bd2b5434)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// alg_set_diff.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>      // For greater<int>( )  
#include <iostream>  
  
// Return whether modulus of elem1 is less than modulus of elem2  
bool mod_lesser (int elem1, int elem2 )  
{  
   if (elem1 < 0)   
      elem1 = - elem1;  
   if (elem2 < 0)   
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
   vector <int>::iterator Iter3a,  Iter3b, Iter3, Result3;  
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
  
   // To combine into a difference in asscending  
   // order with the default binary predicate less <int> ( )  
   Result1 = set_difference ( v1a.begin ( ) , v1a.end ( ) ,  
      v1b.begin ( ) , v1b.end ( ) , v1.begin ( ) );  
   cout << "Set_difference of source ranges with default order,"  
        << "\n vector v1mod =  ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != Result1 ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // To combine into a difference in descending  
   // order specify binary predicate greater<int>( )  
   Result2 = set_difference ( v2a.begin ( ) , v2a.end ( ) ,  
      v2b.begin ( ) , v2b.end ( ) ,v2.begin ( ) , greater <int> ( ) );  
   cout << "Set_difference of source ranges with binary"  
        << "predicate greater specified,\n vector v2mod  = ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != Result2 ; Iter2++ )  
      cout << *Iter2 << " ";  
   cout << ")." << endl;  
  
   // To combine into a difference applying a user  
   // defined binary predicate mod_lesser  
   Result3 = set_difference (  v3a.begin ( ) , v3a.end ( ) ,  
      v3b.begin ( ) , v3b.end ( ) , v3.begin ( ) , mod_lesser );  
   cout << "Set_difference of source ranges with binary "  
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
Set_difference of source ranges with default order,  
 vector v1mod =  ( 1 2 3 4 ).  
Set_difference of source ranges with binarypredicate greater specified,  
 vector v2mod  = ( 4 3 2 1 ).  
Set_difference of source ranges with binary predicate mod_lesser specified,  
 vector v3mod  = ( 1 4 ).  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)