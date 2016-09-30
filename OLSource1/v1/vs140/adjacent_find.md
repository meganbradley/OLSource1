---
title: "adjacent_find"
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
  - "algorithm/std::adjacent_find"
  - "std.adjacent_find"
  - "adjacent_find"
  - "std::adjacent_find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "adjacent_find function"
  - "adjacent_find"
ms.assetid: 81efd39c-ff0e-476a-9a72-740ea788d966
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# adjacent_find
Searches for two adjacent elements that are either equal or satisfy a specified condition.  
  
## Syntax  
  
```  
template<class ForwardIterator>  
   ForwardIterator adjacent_find(  
      ForwardIterator _First,   
      ForwardIterator _Last  
   );  
template<class ForwardIterator , class BinaryPredicate>  
   ForwardIterator adjacent_find(  
      ForwardIterator _First,   
      ForwardIterator _Last,   
      BinaryPredicate _Comp  
   );  
```  
  
#### Parameters  
 `_First`  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 `_Last`  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 `_Comp`  
 The binary predicate giving the condition to be satisfied by the values of the adjacent elements in the range being searched.  
  
## Return Value  
 A forward iterator to the first element of the adjacent pair that are either equal to each other (in the first version) or that satisfy the condition given by the binary predicate (in the second version), provided that such a pair of elements is found. Otherwise, an iterator pointing to `_Last` is returned.  
  
## Remarks  
 The `adjacent_find` algorithm is a nonmutating sequence algorithm. The range to be searched must be valid; all pointers must be dereferenceable and the last position is reachable from the first by incrementation. The time complexity of the algorithm is linear in the number of elements contained in the range.  
  
 The `operator==` used to determine the match between elements must impose an equivalence relation between its operands.  
  
## Example  
  
```  
// alg_adj_fnd.cpp  
// compile with: /EHsc  
#include <list>  
#include <algorithm>  
#include <iostream>  
  
// Returns whether second element is twice the first  
bool twice (int elem1, int elem2 )  
{  
   return elem1 * 2 == elem2;  
}  
  
int main( )   
{  
   using namespace std;  
   list <int> L;  
   list <int>::iterator Iter;  
   list <int>::iterator result1, result2;  
  
   L.push_back( 50 );  
   L.push_back( 40 );  
   L.push_back( 10 );  
   L.push_back( 20 );  
   L.push_back( 20 );  
  
   cout << "L = ( " ;  
   for ( Iter = L.begin( ) ; Iter != L.end( ) ; Iter++ )  
      cout << *Iter << " ";  
   cout << ")" << endl;  
  
   result1 = adjacent_find( L.begin( ), L.end( ) );  
   if ( result1 == L.end( ) )  
      cout << "There are not two adjacent elements that are equal."  
           << endl;  
   else  
      cout << "There are two adjacent elements that are equal."  
           << "\n They have a value of "  
           <<  *( result1 ) << "." << endl;  
  
   result2 = adjacent_find( L.begin( ), L.end( ), twice );  
   if ( result2 == L.end( ) )  
      cout << "There are not two adjacent elements where the "  
           << " second is twice the first." << endl;  
   else  
      cout << "There are two adjacent elements where "  
           << "the second is twice the first."  
           << "\n They have values of " << *(result2++);  
      cout << " & " << *result2 << "." << endl;  
}  
```  
  
 **L = ( 50 40 10 20 20 )**  
**There are two adjacent elements that are equal.**  
 **They have a value of 20.**  
**There are two adjacent elements where the second is twice the first.**  
 **They have values of 10 & 20.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Nonpredicate Version of adjacent_find](../vs140/nonpredicate-version-of-adjacent_find.md)   
 [Predicate Version of adjacent_find](../vs140/predicate-version-of-adjacent_find.md)   
 [Standard Template Library](../vs140/standard-template-library.md)