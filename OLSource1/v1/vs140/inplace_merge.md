---
title: "inplace_merge"
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
  - "inplace_merge"
  - "algorithm/std::inplace_merge"
  - "std.inplace_merge"
  - "std::inplace_merge"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "inplace_merge function"
  - "inplace_merge"
ms.assetid: a3a7d861-2b47-4b0c-a2ac-df805c813437
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# inplace_merge
Combines the elements from two consecutive sorted ranges into a single sorted range, where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
```  
template<class BidirectionalIterator>  
   void inplace_merge(  
      BidirectionalIterator _First,   
      BidirectionalIterator _Middle,  
      BidirectionalIterator _Last  
   );  
template<class BidirectionalIterator, class Predicate>  
   void inplace_merge(  
      BidirectionalIterator _First,   
      BidirectionalIterator _Middle,  
      BidirectionalIterator _Last,  
      Predicate _Comp  
   );  
```  
  
#### Parameters  
 `_First`  
 A bidirectional iterator addressing the position of the first element in the first of two consecutive sorted ranges to be combined and sorted into a single range.  
  
 `_Middle`  
 A bidirectional iterator addressing the position of the first element in the second of two consecutive sorted ranges to be combined and sorted into a single range.  
  
 `_Last`  
 A bidirectional iterator addressing the position one past the last element in the second of two consecutive sorted ranges to be combined and sorted into a single range.  
  
 `_Comp`  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
## Remarks  
 The sorted consecutive ranges referenced must be valid; all pointers must be dereferenceable and, within each sequence, the last position must be reachable from the first by incrementation.  
  
 The sorted consecutive ranges must each be arranged as a precondition to the application of the `inplace_merge` algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges. The operation is stable as the relative order of elements within each range is preserved. When there are equivalent elements in both source ranges, the element is the first range precedes the element from the second in the combined range.  
  
 The complexity depends on the available memory as the algorithm allocates memory to a temporary buffer. If sufficient memory is available, the best case is linear with (*_Last – _First*) – 1 comparisons; if no auxiliary memory is available, the worst case is *N* log*(N)*, where *N* = (*_Last – _First*).  
  
## Example  
  
```  
// alg_inplace_merge.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>      //For greater<int>( )  
#include <iostream>  
  
// Return whether modulus of elem1 is less than modulus of elem2  
bool mod_lesser ( int elem1, int elem2 )  
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
   vector <int> v1;  
   vector <int>::iterator Iter1, Iter2, Iter3;  
  
   // Constructing vector v1 with default less-than ordering  
   int i;  
   for ( i = 0 ; i <= 5 ; i++ )  
   {  
      v1.push_back( i );  
   }  
  
   int ii;  
   for ( ii =-5 ; ii <= 0 ; ii++ )  
   {  
      v1.push_back(  ii  );  
   }  
  
   cout << "Original vector v1 with subranges sorted by the\n "  
        <<  "binary predicate less than is  v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // Constructing vector v2 with ranges sorted by greater  
   vector <int> v2 ( v1 );  
   vector <int>::iterator break2;  
   break2 = find ( v2.begin ( ) , v2.end ( ) , -5 );  
   sort ( v2.begin ( ) , break2 , greater<int> ( ) );  
   sort ( break2 , v2.end ( ) , greater<int> ( ) );  
   cout << "Original vector v2 with subranges sorted by the\n "  
        << "binary predicate greater is v2 = ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != v2.end( ) ; Iter2++ )  
      cout << *Iter2 << " ";  
   cout << ")" << endl;  
  
   // Constructing vector v3 with ranges sorted by mod_lesser  
   vector <int> v3 ( v1 );  
   vector <int>::iterator break3;  
   break3 = find ( v3.begin ( ) , v3.end ( ) , -5 );  
   sort ( v3.begin ( ) , break3 , mod_lesser );  
   sort ( break3 , v3.end ( ) , mod_lesser );  
   cout << "Original vector v3 with subranges sorted by the\n "  
        << "binary predicate mod_lesser is v3 = ( " ;  
   for ( Iter3 = v3.begin( ) ; Iter3 != v3.end( ) ; Iter3++ )  
      cout << *Iter3 << " ";  
   cout << ")" << endl;  
  
   vector <int>::iterator break1;  
   break1 = find (v1.begin ( ) , v1.end ( ) , -5 );  
   inplace_merge ( v1.begin( ), break1, v1.end( ) );  
   cout << "Merged inplace with default order,\n vector v1mod = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // To merge inplace in descending order, specify binary   
   // predicate greater<int>( )  
   inplace_merge ( v2.begin( ), break2 , v2.end( ) , greater<int>( ) );  
   cout << "Merged inplace with binary predicate greater specified,\n "  
        << "vector v2mod = ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != v2.end( ) ; Iter2++ )  
      cout << *Iter2 << " ";  
   cout << ")" << endl;  
  
   // Applying a user defined (UD) binary predicate mod_lesser  
   inplace_merge ( v3.begin( ), break3, v3.end( ), mod_lesser );  
   cout << "Merged inplace with binary predicate mod_lesser specified,\n "  
        << "vector v3mod = ( " ; ;  
   for ( Iter3 = v3.begin( ) ; Iter3 != v3.end( ) ; Iter3++ )  
      cout << *Iter3 << " ";  
   cout << ")" << endl;  
}  
```  
  
 **Original vector v1 with subranges sorted by the**  
 **binary predicate less than is  v1 = ( 0 1 2 3 4 5 -5 -4 -3 -2 -1 0 )**  
**Original vector v2 with subranges sorted by the**  
 **binary predicate greater is v2 = ( 5 4 3 2 1 0 0 -1 -2 -3 -4 -5 )**  
**Original vector v3 with subranges sorted by the**  
 **binary predicate mod_lesser is v3 = ( 0 1 2 3 4 5 0 -1 -2 -3 -4 -5 )**  
**Merged inplace with default order,**  
 **vector v1mod = ( -5 -4 -3 -2 -1 0 0 1 2 3 4 5 )**  
**Merged inplace with binary predicate greater specified,**  
 **vector v2mod = ( 5 4 3 2 1 0 0 -1 -2 -3 -4 -5 )**  
**Merged inplace with binary predicate mod_lesser specified,**  
 **vector v3mod = ( 0 0 1 -1 2 -2 3 -3 4 -4 5 -5 )**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [inplace_merge](../vs140/inplace_merge--stl-samples-.md)   
 [Predicate Version of inplace_merge](../vs140/predicate-version-of-inplace_merge.md)   
 [Standard Template Library](../vs140/standard-template-library.md)