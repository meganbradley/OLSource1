---
title: "find_end"
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
  - "std::find_end"
  - "find_end"
  - "std.find_end"
  - "algorithm/std::find_end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find_end function"
  - "find_end"
ms.assetid: 831c0501-75d0-4ed8-9519-9b8c1dfef98a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# find_end
Looks in a range for the last subsequence that is identical to a specified sequence or that is equivalent in a sense specified by a binary predicate.  
  
## Syntax  
  
```  
template<class ForwardIterator1, class ForwardIterator2>  
   ForwardIterator1 find_end(  
      ForwardIterator1 First1,   
      ForwardIterator1 Last1,  
      ForwardIterator2 First2,   
      ForwardIterator2 Last2  
   );  
template<class ForwardIterator1, class ForwardIterator2, class Pred>  
   ForwardIterator1 find_end(  
      ForwardIterator1 First1,   
      ForwardIterator1 Last1,  
      ForwardIterator2 First2,   
      ForwardIterator2 Last2,  
      Pred Comp  
   );  
```  
  
#### Parameters  
 `First1`  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 `Last1`  
 A forward iterator addressing the position one past the last element in the range to be searched.  
  
 `First2`  
 A forward iterator addressing the position of the first element in the range to search for.  
  
 `Last2`  
 A forward iterator addressing the position one past the last element in the range to search for.  
  
 `Comp`  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A forward iterator addressing the position of the first element of the last subsequence within [First1, Last1) that matches the specified sequence [First2, Last2).  
  
## Remarks  
 The `operator==` used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 The ranges referenced must be valid; all pointers must be dereferenceable and, within each sequence, the last position is reachable from the first by incrementation.  
  
## Example  
  
```  
// alg_find_end.cpp  
// compile with: /EHsc  
#include <vector>  
#include <list>  
#include <algorithm>  
#include <iostream>  
  
// Return whether second element is twice the first  
bool twice ( int elem1, int elem2 )  
{  
   return 2 * elem1 == elem2;  
}  
  
int main( )  
{  
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
   for ( ii = 1 ; ii <= 4 ; ii++ )  
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
  
   // Searching v1 for a match to L1 under identity  
   vector <int>::iterator result1;  
   result1 = find_end ( v1.begin( ), v1.end( ), L1.begin( ), L1.end( ) );  
  
   if ( result1 == v1.end( ) )  
      cout << "There is no match of L1 in v1."  
           << endl;  
   else  
      cout << "There is a match of L1 in v1 that begins at "  
           << "position "<< result1 - v1.begin( ) << "." << endl;  
  
   // Searching v1 for a match to L1 under the binary predicate twice  
   vector <int>::iterator result2;  
   result2 = find_end ( v1.begin( ), v1.end( ), v2.begin( ), v2.end( ), twice );  
  
   if ( result2 == v1.end( ) )  
      cout << "There is no match of L1 in v1."  
           << endl;  
   else  
      cout << "There is a sequence of elements in v1 that "  
           << "are equivalent to those\n in v2 under the binary "  
           << "predicate twice and that begins at position "  
           << result2 - v1.begin( ) << "." << endl;  
}  
```  
  
 **Vector v1 = ( 0 5 10 15 20 25 0 5 10 15 20 25 )**  
**List L1 = ( 5 10 15 20 )**  
**Vector v2 = ( 20 30 40 )**  
**There is a match of L1 in v1 that begins at position 7.**  
**There is a sequence of elements in v1 that are equivalent to those**  
 **in v2 under the binary predicate twice and that begins at position 8.**   
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)