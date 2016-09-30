---
title: "search_n"
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
  - "std.search_n"
  - "search_n"
  - "std::search_n"
  - "algorithm/std::search_n"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "search_n"
  - "search_n function"
ms.assetid: 8daa0c12-bac4-4cef-9213-45ef9a8d86af
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# search_n
Searches for the first subsequence in a range that of a specified number of elements having a particular value or a relation to that value as specified by a binary predicate.  
  
## Syntax  
  
```  
template<class ForwardIterator1, class Diff2, class Type>  
   ForwardIterator1 search_n(  
      ForwardIterator1 _First1,   
      ForwardIterator1 _Last1,  
      Diff2 _Count,   
      const Type& _Val  
   );  
template<class ForwardIterator1, class Diff2, class Type, class BinaryPredicate>  
   ForwardIterator1 search_n(  
      ForwardIterator1 _First1,   
      ForwardIterator1 _Last1,  
      Diff2 _Count,   
      const Type& _Val,  
      BinaryPredicate _Comp  
   );  
```  
  
#### Parameters  
 `_First1`  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 `_Last1`  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 `_Count`  
 The size of the subsequence being searched for.  
  
 `_Val`  
 The value of the elements in the sequence being searched for.  
  
 `_Comp`  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A forward iterator addressing the position of the first element of the first subsequence that matches the specified sequence or that is equivalent in a sense specified by a binary predicate.  
  
## Remarks  
 The `operator==` used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Complexity is linear with respect to the size of the searched.  
  
## Example  
  
```  
// alg_search_n.cpp  
// compile with: /EHsc  
#include <vector>  
#include <list>  
#include <algorithm>  
#include <iostream>  
  
// Return whether second element is 1/2 of the first  
bool one_half ( int elem1, int elem2 )  
{  
   return elem1 == 2 * elem2;  
}  
  
int main( )   
{  
   using namespace std;  
   vector <int> v1, v2;  
   vector <int>::iterator Iter1;  
  
   int i;  
   for ( i = 0 ; i <= 5 ; i++ )  
   {  
      v1.push_back( 5 * i );  
   }  
  
   for ( i = 0 ; i <= 2 ; i++ )  
   {  
      v1.push_back( 5  );  
   }  
  
   for ( i = 0 ; i <= 5 ; i++ )  
   {  
      v1.push_back( 5 * i );  
   }  
  
   for ( i = 0 ; i <= 2 ; i++ )  
   {  
      v1.push_back( 10  );  
   }  
  
   cout << "Vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // Searching v1 for first match to (5 5 5) under identity  
   vector <int>::iterator result1;  
   result1 = search_n ( v1.begin( ), v1.end( ), 3, 5 );  
  
   if ( result1 == v1.end( ) )  
      cout << "There is no match for a sequence ( 5 5 5 ) in v1."  
           << endl;  
   else  
      cout << "There is at least one match of a sequence ( 5 5 5 )"  
           << "\n in v1 and the first one begins at "  
           << "position "<< result1 - v1.begin( ) << "." << endl;  
  
   // Searching v1 for first match to (5 5 5) under one_half  
   vector <int>::iterator result2;  
   result2 = search_n (v1.begin( ), v1.end( ), 3, 5, one_half );  
  
   if ( result2 == v1.end( ) )  
      cout << "There is no match for a sequence ( 5 5 5 ) in v1"  
           << " under the equivalence predicate one_half." << endl;  
   else  
      cout << "There is a match of a sequence ( 5 5 5 ) "  
           << "under the equivalence\n predicate one_half "  
           << "in v1 and the first one begins at "  
           << "position "<< result2 - v1.begin( ) << "." << endl;  
}  
```  
  
 **Vector v1 = ( 0 5 10 15 20 25 5 5 5 0 5 10 15 20 25 10 10 10 )**  
**There is at least one match of a sequence ( 5 5 5 )**  
 **in v1 and the first one begins at position 6.**  
**There is a match of a sequence ( 5 5 5 ) under the equivalence**  
 **predicate one_half in v1 and the first one begins at position 15.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)