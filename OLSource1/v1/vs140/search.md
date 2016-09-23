---
title: "search"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - search
  - algorithm/std::search
  - std.search
  - std::search
dev_langs: 
  - C++
helpviewer_keywords: 
  - search function
  - searches
ms.assetid: fe692c77-c55e-4f4c-b6da-9fe456fff540
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# search
Searches for the first occurrence of a sequence within a target range whose elements are equal to those in a given sequence of elements or whose elements are equivalent in a sense specified by a binary predicate to the elements in the given sequence.  
  
## Syntax  
  
```  
template<class ForwardIterator1, class ForwardIterator2>  
   ForwardIterator1 search(  
      ForwardIterator1 _First1,   
      ForwardIterator1 _Last1,  
      ForwardIterator2 _First2,   
      ForwardIterator2 _Last2  
   );  
template<class ForwardIterator1, class ForwardIterator2, class Predicate>  
   ForwardIterator1 search(  
      ForwardIterator1 _First1,   
      ForwardIterator1 _Last1,  
      ForwardIterator2 _First2,   
      ForwardIterator2 _Last2  
      Predicate _Comp  
   );  
```  
  
#### Parameters  
 `_First1`  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 `_Last1`  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 `_First2`  
 A forward iterator addressing the position of the first element in the range to be matched.  
  
 `_Last2`  
 A forward iterator addressing the position one past the final element in the range to be matched.  
  
 `_Comp`  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A forward iterator addressing the position of the first element of the first subsequence that matches the specified sequence or that is equivalent in a sense specified by a binary predicate.  
  
## Remarks  
 The `operator==` used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 The ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position is reachable from the first by incrementation.  
  
 Average complexity is linear with respect to the size of the searched range, and worst case complexity is also linear with respect to the size of the sequence being searched for.  
  
## Example  
  
```  
// alg_search.cpp  
// compile with: /EHsc  
#include <vector>  
#include <list>  
#include <algorithm>  
#include <iostream>  
  
// Return whether second element is twice the first  
bool twice (int elem1, int elem2 )  
{  
   return 2 * elem1 == elem2;  
}  
  
int main( ) {  
   using namespace std;  
   vector <int> v1, v2;  
   list <int> L1;  
   vector <int>::iterator Iter1, Iter2;  
   list <int>::iterator L1_Iter, L1_inIter;  
  
   int i;  
   for ( i = 0 ; i <= 5 ; i++ )  
   {  
      v1.push_back( 5 * i );  
   }  
   for ( i = 0 ; i <= 5 ; i++ )  
   {  
      v1.push_back( 5 * i );  
   }  
  
   int ii;  
   for ( ii = 4 ; ii <= 5 ; ii++ )  
   {  
      L1.push_back( 5 * ii );  
   }  
  
   int iii;  
   for ( iii = 2 ; iii <= 4 ; iii++ )  
   {  
      v2.push_back( 10 * iii );  
   }  
  
   cout << "Vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   cout << "List L1 = ( " ;  
   for ( L1_Iter = L1.begin( ) ; L1_Iter!= L1.end( ) ; L1_Iter++ )  
      cout << *L1_Iter << " ";  
   cout << ")" << endl;  
  
   cout << "Vector v2 = ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != v2.end( ) ; Iter2++ )  
      cout << *Iter2 << " ";  
      cout << ")" << endl;  
  
   // Searching v1 for first match to L1 under identity  
   vector <int>::iterator result1;  
   result1 = search (v1.begin( ), v1.end( ), L1.begin( ), L1.end( ) );  
  
   if ( result1 == v1.end( ) )  
      cout << "There is no match of L1 in v1."  
           << endl;  
   else  
      cout << "There is at least one match of L1 in v1"  
           << "\n and the first one begins at "  
           << "position "<< result1 - v1.begin( ) << "." << endl;  
  
   // Searching v1 for a match to L1 under the binary predicate twice  
   vector <int>::iterator result2;  
   result2 = search  (v1.begin( ), v1.end( ), v2.begin( ), v2.end( ), twice );  
  
   if ( result2 == v1.end( ) )  
      cout << "There is no match of L1 in v1."  
           << endl;  
   else  
      cout << "There is a sequence of elements in v1 that "  
           << "are equivalent\n to those in v2 under the binary "  
           << "predicate twice\n and the first one begins at position "  
           << result2 - v1.begin( ) << "." << endl;  
}  
```  
  
 **Vector v1 = ( 0 5 10 15 20 25 0 5 10 15 20 25 )**  
**List L1 = ( 20 25 )**  
**Vector v2 = ( 20 30 40 )**  
**There is at least one match of L1 in v1**  
 **and the first one begins at position 4.**  
**There is a sequence of elements in v1 that are equivalent**  
 **to those in v2 under the binary predicate twice**  
 **and the first one begins at position 2.**   
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)