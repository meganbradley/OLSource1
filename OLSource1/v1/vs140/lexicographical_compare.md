---
title: "lexicographical_compare"
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
  - "std.lexicographical_compare"
  - "std::lexicographical_compare"
  - "xutility/std::lexicographical_compare"
  - "lexicographical_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lexicographical_compare"
  - "lexicographical_compare function"
ms.assetid: 403f8526-50a4-4c1c-865e-391b1095fc32
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# lexicographical_compare
Compares element by element between two sequences to determine which is lesser of the two.  
  
## Syntax  
  
```  
  
      template<class InputIterator1, class InputIterator2>  
   bool lexicographical_compare(  
      InputIterator1 _First1,  
      InputIterator1 _Last1,  
      InputIterator2 _First2,  
      InputIterator2 _Last2  
   );  
template<class InputIterator1, class InputIterator2, class BinaryPredicate>  
   bool lexicographical_compare(  
      InputIterator1 _First1,  
      InputIterator1 _Last1,   
      InputIterator2 _First2,   
      InputIterator2 _Last2,  
      BinaryPredicate _Comp  
   );  
```  
  
#### Parameters  
 `_First1`  
 An input iterator addressing the position of the first element in the first range to be compared.  
  
 `_Last1`  
 An input iterator addressing the position one past the final element in the first range to be compared.  
  
 `_First2`  
 An input iterator addressing the position of the first element in the second range to be compared.  
  
 `_Last2`  
 An input iterator addressing the position one past the final element in the second range to be compared.  
  
 `_Comp`  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 **true** if the first range is lexicographically less than the second range; otherwise **false**.  
  
## Remarks  
 A lexicographical comparison between sequences compares them element by element until:  
  
-   It finds two corresponding elements unequal, and the result of their comparison is taken as the result of the comparison between sequences.  
  
-   No inequalities are found, but one sequence has more elements than the other, and the shorter sequence is considered less than the longer sequence.  
  
-   No inequalities are found and the sequences have the same number of elements, and so the sequences are equal and the result of the comparison is false.  
  
## Example  
  
```  
// alg_lex_comp.cpp  
// compile with: /EHsc  
#include <vector>  
#include <list>  
#include <algorithm>  
#include <iostream>  
  
// Return whether second element is twice the first  
bool twice ( int elem1, int elem2 )  
{  
   return 2 * elem1 < elem2;  
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
   int ii;  
   for ( ii = 0 ; ii <= 6 ; ii++ )  
   {  
      L1.push_back( 5 * ii );  
   }  
  
   int iii;  
   for ( iii = 0 ; iii <= 5 ; iii++ )  
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
  
   // Self lexicographical_comparison of v1 under identity  
   bool result1;  
   result1 = lexicographical_compare (v1.begin( ), v1.end( ),  
                  v1.begin( ), v1.end( ) );  
   if ( result1 )  
      cout << "Vector v1 is lexicographically_less than v1." << endl;  
   else  
      cout << "Vector v1 is not lexicographically_less than v1." << endl;  
  
   // lexicographical_comparison of v1 and L2 under identity  
   bool result2;  
   result2 = lexicographical_compare (v1.begin( ), v1.end( ),  
                  L1.begin( ), L1.end( ) );  
   if ( result2 )  
      cout << "Vector v1 is lexicographically_less than L1." << endl;  
   else  
      cout << "Vector v1 is lexicographically_less than L1." << endl;  
  
   bool result3;  
   result3 = lexicographical_compare (v1.begin( ), v1.end( ),  
                  v2.begin( ), v2.end( ), twice );  
   if ( result3 )  
      cout << "Vector v1 is lexicographically_less than v2 "  
           << "under twice." << endl;  
   else  
      cout << "Vector v1 is not lexicographically_less than v2 "  
           << "under twice." << endl;  
}  
```  
  
 **Vector v1 = ( 0 5 10 15 20 25 )**  
**List L1 = ( 0 5 10 15 20 25 30 )**  
**Vector v2 = ( 0 10 20 30 40 50 )**  
**Vector v1 is not lexicographically_less than v1.**  
**Vector v1 is lexicographically_less than L1.**  
**Vector v1 is not lexicographically_less than v2 under twice.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)