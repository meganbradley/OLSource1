---
title: "next_permutation"
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
  - std.next_permutation
  - algorithm/std::next_permutation
  - next_permutation
  - std::next_permutation
dev_langs: 
  - C++
helpviewer_keywords: 
  - next_permutation function
  - next_permutation
ms.assetid: d412620b-73f7-4bdd-9ee6-e581504e9859
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# next_permutation
Reorders the elements in a range so that the original ordering is replaced by the lexicographically next greater permutation if it exists, where the sense of next may be specified with a binary predicate.  
  
## Syntax  
  
```  
  
      template<class BidirectionalIterator>  
   bool next_permutation(  
      BidirectionalIterator _First,   
      BidirectionalIterator _Last  
   );  
template<class BidirectionalIterator, class BinaryPredicate>  
   bool next_permutation(  
      BidirectionalIterator _First,   
      BidirectionalIterator _Last,  
      BinaryPredicate _Comp  
   );  
```  
  
#### Parameters  
 `_First`  
 A bidirectional iterator pointing to the position of the first element in the range to be permuted.  
  
 `_Last`  
 A bidirectional iterator pointing to the position one past the final element in the range to be permuted.  
  
 `_Comp`  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 **true** if the lexicographically next permutation exists and has replaced the original ordering of the range; otherwise **false**, in which case the ordering is transformed into the lexicographically smallest permutation.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The default binary predicate is less than and the elements in the range must be less than comparable to insure that the next permutation is well defined.  
  
 The complexity is linear with at most (*_Last – _First*)/2 swaps.  
  
## Example  
  
```  
// alg_next_perm.cpp  
// compile with: /EHsc  
#include <vector>  
#include <deque>  
#include <algorithm>  
#include <iostream>  
#include <ostream>  
  
using namespace std;  
class CInt;  
ostream& operator<<( ostream& osIn, const CInt& rhs );  
  
class CInt  
{  
public:  
   CInt( int n = 0 ) : m_nVal( n ){}  
   CInt( const CInt& rhs ) : m_nVal( rhs.m_nVal ){}  
   CInt&   operator=( const CInt& rhs ) {m_nVal =  
   rhs.m_nVal; return *this;}  
   bool operator<( const CInt& rhs ) const  
      { return ( m_nVal < rhs.m_nVal );}  
   friend   ostream& operator<<( ostream& osIn, const CInt& rhs );  
  
private:  
   int m_nVal;  
};  
  
inline ostream& operator<<( ostream& osIn, const CInt& rhs )  
{  
   osIn << "CInt( " << rhs.m_nVal << " )";  
   return osIn;  
}  
  
// Return whether modulus of elem1 is less than modulus of elem2  
bool mod_lesser ( int elem1, int elem2 )  
{  
   if ( elem1 < 0 )  
      elem1 = - elem1;  
   if ( elem2 < 0 )  
      elem2 = - elem2;  
   return elem1 < elem2;  
};  
  
int main( )  
{  
   // Reordering the elements of type CInt in a deque  
   // using the prev_permutation algorithm  
   CInt c1 = 5, c2 = 1, c3 = 10;  
   bool deq1Result;  
   deque<CInt> deq1, deq2, deq3;  
   deque<CInt>::iterator d1_Iter;  
  
   deq1.push_back ( c1 );  
   deq1.push_back ( c2 );  
   deq1.push_back ( c3 );  
  
   cout << "The original deque of CInts is deq1 = (";  
   for ( d1_Iter = deq1.begin( ); d1_Iter != --deq1.end( ); d1_Iter++ )  
      cout << " " << *d1_Iter << ",";  
   d1_Iter = --deq1.end( );  
   cout << " " << *d1_Iter << " )." << endl;  
  
   deq1Result = next_permutation ( deq1.begin ( ) , deq1.end ( ) );  
  
   if ( deq1Result )  
      cout << "The lexicographically next permutation "  
           << "exists and has\nreplaced the original "  
           << "ordering of the sequence in deq1." << endl;  
   else  
      cout << "The lexicographically next permutation doesn't "  
           << "exist\n and the lexicographically "  
           << "smallest permutation\n has replaced the "  
           << "original ordering of the sequence in deq1." << endl;  
  
   cout << "After one application of next_permutation,\n deq1 = (";  
   for ( d1_Iter = deq1.begin( ); d1_Iter != --deq1.end( ); d1_Iter++ )  
      cout << " " << *d1_Iter << ",";  
   d1_Iter = --deq1.end( );  
   cout << " " << *d1_Iter << " )." << endl << endl;  
  
   // Permuting vector elements with binary function mod_lesser  
   vector <int> v1;  
   vector <int>::iterator Iter1;  
  
   int i;  
   for ( i = -3 ; i <= 3 ; i++ )  
   {  
      v1.push_back( i );  
   }  
  
   cout << "Vector v1 is ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   next_permutation ( v1.begin ( ) , v1.end ( ) , mod_lesser );  
  
   cout << "After the first next_permutation, vector v1 is:\n v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   int iii = 1;  
   while ( iii <= 5 ) {  
      next_permutation ( v1.begin ( ) , v1.end ( ) , mod_lesser );  
      cout << "After another next_permutation of vector v1,\n v1 =   ( " ;  
      for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ;Iter1 ++ )  
         cout << *Iter1  << " ";  
      cout << ")." << endl;  
      iii++;  
   }  
}  
```  
  
 **The original deque of CInts is deq1 = ( CInt( 5 ), CInt( 1 ), CInt( 10 ) ).**  
**The lexicographically next permutation exists and has**  
**replaced the original ordering of the sequence in deq1.**  
**After one application of next_permutation,**  
 **deq1 = ( CInt( 5 ), CInt( 10 ), CInt( 1 ) ).**  
**Vector v1 is ( -3 -2 -1 0 1 2 3 ).**  
**After the first next_permutation, vector v1 is:**  
 **v1 = ( -3 -2 -1 0 1 3 2 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 0 2 1 3 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 0 2 3 1 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 0 3 1 2 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 0 3 2 1 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 1 0 2 3 ).**   
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [next_permutation](../vs140/next_permutation--stl-samples-.md)   
 [Predicate Version of next_permutation](../vs140/predicate-version-of-next_permutation.md)   
 [Standard Template Library](../vs140/standard-template-library.md)