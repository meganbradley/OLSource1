---
title: "unique (&lt;algorithm&gt;)"
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
  - "algorithm/std::unique"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unique function"
ms.assetid: a9615038-2b77-43bf-876b-9f79be88eff0
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique (&lt;algorithm&gt;)
Removes duplicate elements that are adjacent to each other in a specified range.  
  
## Syntax  
  
```  
template<class ForwardIterator>  
   ForwardIterator unique(  
      ForwardIterator _First,   
      ForwardIterator _Last  
   );  
template<class ForwardIterator, class Predicate>  
   ForwardIterator unique(  
      ForwardIterator _First,   
      ForwardIterator _Last,  
      Predicate _Comp  
   );  
```  
  
#### Parameters  
 `_First`  
 A forward iterator addressing the position of the first element in the range to be scanned for duplicate removal.  
  
 `_Last`  
 A forward iterator addressing the position one past the final element in the range to be scanned for duplicate removal.  
  
 `_Comp`  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A forward iterator to the new end of the modified sequence that contains no consecutive duplicates, addressing the position one past the last element not removed.  
  
## Remarks  
 Both forms of the algorithm remove the second duplicate of a consecutive pair of equal elements.  
  
 The operation of the algorithm is stable so that the relative order of the undeleted elements is not changed.  
  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation. he number of elements in the sequence is not changed by the algorithm **unique** and the elements beyond the end of the modified sequence are dereferenceable but not specified.  
  
 The complexity is linear, requiring (`_Last` – `_First`) – 1 comparisons.  
  
 List provides a more efficient member function [unique](../vs140/list--unique.md), which may perform better.  
  
 These algorithms cannot be used on an associative container.  
  
## Example  
  
```  
// alg_unique.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>  
#include <iostream>  
#include <ostream>  
  
using namespace std;  
  
// Return whether modulus of elem1 is equal to modulus of elem2  
bool mod_equal ( int elem1, int elem2 )  
{  
   if ( elem1 < 0 )   
      elem1 = - elem1;  
   if ( elem2 < 0 )   
      elem2 = - elem2;  
   return elem1 == elem2;  
};  
  
int main( )  
{  
   vector <int> v1;  
   vector <int>::iterator v1_Iter1, v1_Iter2, v1_Iter3,  
         v1_NewEnd1, v1_NewEnd2, v1_NewEnd3;  
  
   int i;  
   for ( i = 0 ; i <= 3 ; i++ )  
   {  
      v1.push_back( 5 );  
      v1.push_back( -5 );  
   }  
  
   int ii;  
   for ( ii = 0 ; ii <= 3 ; ii++ )  
   {  
      v1.push_back( 4 );  
   }  
   v1.push_back( 7 );  
  
   cout << "Vector v1 is ( " ;  
   for ( v1_Iter1 = v1.begin( ) ; v1_Iter1 != v1.end( ) ; v1_Iter1++ )  
      cout << *v1_Iter1 << " ";  
   cout << ")." << endl;  
  
   // Remove consecutive duplicates  
   v1_NewEnd1 = unique ( v1.begin ( ) , v1.end ( ) );  
  
   cout << "Removing adjacent duplicates from vector v1 gives\n ( " ;  
   for ( v1_Iter1 = v1.begin( ) ; v1_Iter1 != v1_NewEnd1 ; v1_Iter1++ )  
      cout << *v1_Iter1 << " ";  
   cout << ")." << endl;  
  
   // Remove consecutive duplicates under the binary prediate mod_equals  
   v1_NewEnd2 = unique ( v1.begin ( ) , v1_NewEnd1 , mod_equal );  
  
   cout << "Removing adjacent duplicates from vector v1 under the\n "  
        << " binary predicate mod_equal gives\n ( " ;  
   for ( v1_Iter2 = v1.begin( ) ; v1_Iter2 != v1_NewEnd2 ; v1_Iter2++ )  
      cout << *v1_Iter2 << " ";  
   cout << ")." << endl;  
  
   // Remove elements if preceded by an element that was greater  
   v1_NewEnd3 = unique ( v1.begin ( ) , v1_NewEnd2, greater<int>( ) );  
  
   cout << "Removing adjacent elements satisfying the binary\n "  
        << " predicate mod_equal from vector v1 gives ( " ;  
   for ( v1_Iter3 = v1.begin( ) ; v1_Iter3 != v1_NewEnd3 ; v1_Iter3++ )  
      cout << *v1_Iter3 << " ";  
   cout << ")." << endl;  
}  
```  
  
 **Vector v1 is ( 5 -5 5 -5 5 -5 5 -5 4 4 4 4 7 ).**  
**Removing adjacent duplicates from vector v1 gives**  
 **( 5 -5 5 -5 5 -5 5 -5 4 7 ).**  
**Removing adjacent duplicates from vector v1 under the**  
 **binary predicate mod_equal gives**  
 **( 5 4 7 ).**  
**Removing adjacent elements satisfying the binary**  
 **predicate mod_equal from vector v1 gives ( 5 7 ).**   
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)