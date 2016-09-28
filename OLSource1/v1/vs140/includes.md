---
title: "includes"
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
  - "Includes"
  - "std::includes"
  - "std.includes"
  - "algorithm/std::includes"
  - "includes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "includes"
  - "includes function"
ms.assetid: 7038e179-3813-46f3-9b6f-85d8214e9768
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# includes
Tests whether one sorted range contains all the elements contained in a second sorted range, where the ordering or equivalence criterion between elements may be specified by a binary predicate.  
  
## Syntax  
  
```  
  
      template<class InputIterator1, class InputIterator2>  
   bool includes(  
      InputIterator1 _First1,   
      InputIterator1 _Last1,  
      InputIterator2 _First2,   
      InputIterator2 _Last1  
   );  
template<class InputIterator1, class InputIterator2, class BinaryPredicate>  
   bool includes(  
      InputIterator1 _First1,   
      InputIterator1 _Last1,  
      InputIterator2 _First2,   
      InputIterator2 _Last1,  
      BinaryPredicate _Comp  
   );  
```  
  
#### Parameters  
 `_First1`  
 An input iterator addressing the position of the first element in the first of two sorted source ranges to be tested for whether all the elements of the second are contained in the first.  
  
 `_Last1`  
 An input iterator addressing the position one past the last element in the first of two sorted source ranges to be tested for whether all the elements of the second are contained in the first.  
  
 `_First2`  
 An input iterator addressing the position of the first element in second of two consecutive sorted source ranges to be tested for whether all the elements of the second are contained in the first.  
  
 `_Last2`  
 An input iterator addressing the position one past the last element in second of two consecutive sorted source ranges to be tested for whether all the elements of the second are contained in the first.  
  
 `_Comp`  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 **true** if the first sorted range contains all the elements in the second sorted range; otherwise, **false**.  
  
## Remarks  
 Another way to think of this test is that it determined whether the second source range is a subset of the first source range.  
  
 The sorted source ranges referenced must be valid; all pointers must be dereferenceable and, within each sequence, the last position must be reachable from the first by incrementation.  
  
 The sorted source ranges must each be arranged as a precondition to the application of the algorithm includes in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The source ranges are not modified by the algorithm **merge**.  
  
 The value types of the input iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. More precisely, the algorithm tests whether all the elements in the first sorted range under a specified binary predicate have equivalent ordering to those in the second sorted range.  
  
 The complexity of the algorithm is linear with at most 2 \* ( (*_Last1 – _First1*) – (*_Last2 – _First2*) ) – 1 comparisons for nonempty source ranges.  
  
## Example  
  
```  
// alg_includes.cpp  
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
   vector <int> v1a, v1b;  
   vector <int>::iterator Iter1a,  Iter1b;  
  
   // Constructing vectors v1a & v1b with default less-than ordering  
   int i;  
   for ( i = -2 ; i <= 4 ; i++ )  
   {  
      v1a.push_back(  i );  
   }  
  
   int ii;  
   for ( ii =-2 ; ii <= 3 ; ii++ )  
   {  
      v1b.push_back(  ii  );  
   }  
  
   cout << "Original vector v1a with range sorted by the\n "  
        << "binary predicate less than is v1a = ( " ;  
   for ( Iter1a = v1a.begin( ) ; Iter1a != v1a.end( ) ; Iter1a++ )  
      cout << *Iter1a << " ";  
   cout << ")." << endl;  
  
   cout << "Original vector v1b with range sorted by the\n "  
        <<  "binary predicate less than is v1b = ( " ;  
   for ( Iter1b = v1b.begin ( ) ; Iter1b != v1b.end ( ) ; Iter1b++ )  
      cout << *Iter1b << " ";  
   cout << ")." << endl;  
  
   // Constructing vectors v2a & v2b with ranges sorted by greater  
   vector <int> v2a ( v1a ) , v2b ( v1b );  
   vector <int>::iterator Iter2a,  Iter2b;  
   sort ( v2a.begin ( ) , v2a.end ( ) , greater<int> ( ) );  
   sort ( v2b.begin ( ) , v2b.end ( ) , greater<int> ( ) );  
   v2a.pop_back ( );  
  
   cout << "Original vector v2a with range sorted by the\n "  
        <<  "binary predicate greater is v2a = ( " ;  
   for ( Iter2a = v2a.begin ( ) ; Iter2a != v2a.end ( ) ; Iter2a++ )  
      cout << *Iter2a << " ";  
   cout << ")." << endl;  
  
   cout << "Original vector v2b with range sorted by the\n "  
        <<  "binary predicate greater is v2b = ( " ;  
   for ( Iter2b = v2b.begin ( ) ; Iter2b != v2b.end ( ) ; Iter2b++ )  
      cout << *Iter2b << " ";  
   cout << ")." << endl;  
  
   // Constructing vectors v3a & v3b with ranges sorted by mod_lesser  
   vector <int> v3a ( v1a ), v3b ( v1b ) ;  
   vector <int>::iterator Iter3a, Iter3b;  
   reverse (v3a.begin( ), v3a.end( ) );  
   v3a.pop_back ( );  
   v3a.pop_back ( );  
   sort ( v3a.begin ( ) , v3a.end ( ) , mod_lesser );  
   sort ( v3b.begin ( ) , v3b.end ( ) , mod_lesser );  
  
   cout << "Original vector v3a with range sorted by the\n "  
        <<  "binary predicate mod_lesser is v3a = ( " ;  
   for ( Iter3a = v3a.begin ( ) ; Iter3a != v3a.end ( ) ; Iter3a++ )  
      cout << *Iter3a << " ";  
   cout << ")." << endl;  
  
   cout << "Original vector v3b with range sorted by the\n "  
        <<  "binary predicate mod_lesser is v3b = ( " ;  
   for ( Iter3b = v3b.begin ( ) ; Iter3b != v3b.end ( ) ; Iter3b++ )  
      cout << *Iter3b << " ";  
   cout << ")." << endl;  
  
   // To test for inclusion under an asscending order  
   // with the default binary predicate less <int> ( )  
   bool Result1;  
   Result1 = includes ( v1a.begin ( ) , v1a.end ( ) ,  
      v1b.begin ( ) , v1b.end ( ) );  
   if ( Result1 )  
      cout << "All the elements in vector v1b are "  
           << "contained in vector v1a." << endl;  
   else  
      cout << "At least one of the elements in vector v1b "  
           << "is not contained in vector v1a." << endl;  
  
   // To test for inclusion under descending  
   // order specify binary predicate greater<int>( )  
   bool Result2;  
   Result2 = includes ( v2a.begin ( ) , v2a.end ( ) ,  
      v2b.begin ( ) , v2b.end ( ) , greater <int> ( ) );  
   if ( Result2 )  
      cout << "All the elements in vector v2b are "  
           << "contained in vector v2a." << endl;  
   else  
      cout << "At least one of the elements in vector v2b "  
           << "is not contained in vector v2a." << endl;  
  
   // To test for inclusion under a user  
   // defined binary predicate mod_lesser  
   bool Result3;  
   Result3 = includes ( v3a.begin ( ) , v3a.end ( ) ,  
      v3b.begin ( ) , v3b.end ( ) , mod_lesser );  
   if ( Result3 )  
      cout << "All the elements in vector v3b are "  
           << "contained under mod_lesser in vector v3a."  
           << endl;  
   else  
      cout << "At least one of the elements in vector v3b is "  
           << " not contained under mod_lesser in vector v3a."   
           << endl;  
}  
```  
  
 **Original vector v1a with range sorted by the**  
 **binary predicate less than is v1a = ( -2 -1 0 1 2 3 4 ).**  
**Original vector v1b with range sorted by the**  
 **binary predicate less than is v1b = ( -2 -1 0 1 2 3 ).**  
**Original vector v2a with range sorted by the**  
 **binary predicate greater is v2a = ( 4 3 2 1 0 -1 ).**  
**Original vector v2b with range sorted by the**  
 **binary predicate greater is v2b = ( 3 2 1 0 -1 -2 ).**  
**Original vector v3a with range sorted by the**  
 **binary predicate mod_lesser is v3a = ( 0 1 2 3 4 ).**  
**Original vector v3b with range sorted by the**  
 **binary predicate mod_lesser is v3b = ( 0 -1 1 -2 2 3 ).**  
**All the elements in vector v1b are contained in vector v1a.**  
**At least one of the elements in vector v2b is not contained in vector v2a.**  
**At least one of the elements in vector v3b is  not contained under mod_lesser in vector v3a.**   
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [includes](../vs140/includes--stl-samples-.md)   
 [Predicate Version of includes](../vs140/predicate-version-of-includes.md)   
 [Standard Template Library](../vs140/standard-template-library.md)