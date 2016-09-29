---
title: "iter_swap"
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
  - "std::iter_swap"
  - "std.iter_swap"
  - "xutility/std::iter_swap"
  - "iter_swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iter_swap"
  - "iter_swap function"
ms.assetid: c29e658c-0e99-4f11-ad60-d09301a15e1d
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# iter_swap
Exchanges two values referred to by a pair of specified iterators.  
  
## Syntax  
  
```  
  
   template<class ForwardIterator1, class ForwardIterator2>  
void iter_swap(  
   ForwardIterator1 _Left,  
   ForwardIterator2 _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 One of the forward iterators whose value is to be exchanged.  
  
 `_Right`  
 The second of the forward iterators whose value is to be exchanged.  
  
## Remarks  
 `swap` should be used in preference to i**ter_swap**, which was included in the C++ Standard for backward compatibility. If `Fit1` and `Fit2` are forward iterators, then `iter_swap` ( `Fit1`, `Fit2` ), is equivalent to `swap` ( *`Fit1`, \*`Fit2` ).  
  
 The value types of the input forward iterators must have the same value.  
  
## Example  
  
```  
// alg_iter_swap.cpp  
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
   CInt&   operator=( const CInt& rhs ) { m_nVal =  
   rhs.m_nVal; return *this; }  
   bool operator<( const CInt& rhs ) const  
      { return ( m_nVal < rhs.m_nVal );}  
   friend ostream& operator<<( ostream& osIn, const CInt& rhs );  
  
private:  
   int m_nVal;  
};  
  
inline ostream& operator<<( ostream& osIn, const CInt& rhs )  
{  
   osIn << "CInt(" << rhs.m_nVal << ")";  
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
   CInt c1 = 5, c2 = 1, c3 = 10;  
   deque<CInt> deq1;  
   deque<CInt>::iterator d1_Iter;  
  
   deq1.push_back ( c1 );  
   deq1.push_back ( c2 );  
   deq1.push_back ( c3 );  
  
   cout << "The original deque of CInts is deq1 = (";  
   for ( d1_Iter = deq1.begin( ); d1_Iter != --deq1.end( ); d1_Iter++ )  
      cout << " " << *d1_Iter << ",";  
   d1_Iter = --deq1.end( );  
   cout << " " << *d1_Iter << " )." << endl;  
  
   // Exchanging first and last elements with iter_swap  
   iter_swap ( deq1.begin ( ) , --deq1.end ( ) );  
  
   cout << "The deque of CInts with first & last elements swapped is:\n deq1 = (";  
   for ( d1_Iter = deq1.begin( ); d1_Iter != --deq1.end( ); d1_Iter++ )  
      cout << " " << *d1_Iter << ",";  
   d1_Iter = --deq1.end( );  
   cout << " " << *d1_Iter << " )." << endl;  
  
   // Swapping back first and last elements with swap  
   swap ( *deq1.begin ( ) , *(deq1.end ( ) -1 ) );  
  
   cout << "The deque of CInts with first & last elements swapped back is:\n deq1 = (";  
   for ( d1_Iter = deq1.begin( ); d1_Iter != --deq1.end( ); d1_Iter++ )  
      cout << " " << *d1_Iter << ",";  
   d1_Iter = --deq1.end( );  
   cout << " " << *d1_Iter << " )." << endl;  
  
   // Swapping a vector element with a deque element  
   vector <int> v1;  
   vector <int>::iterator Iter1;  
   deque <int> deq2;  
   deque <int>::iterator d2_Iter;  
  
   int i;  
   for ( i = 0 ; i <= 3 ; i++ )  
   {  
      v1.push_back( i );  
   }  
  
   int ii;  
   for ( ii = 4 ; ii <= 5 ; ii++ )  
   {  
      deq2.push_back( ii );  
   }  
  
   cout << "Vector v1 is ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   cout << "Deque deq2 is ( " ;  
   for ( d2_Iter = deq2.begin( ) ; d2_Iter != deq2.end( ) ; d2_Iter++ )  
      cout << *d2_Iter << " ";  
   cout << ")." << endl;  
  
   iter_swap ( v1.begin ( ) , deq2.begin ( ) );  
  
   cout << "After exchanging first elements,\n vector v1 is: v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl << " & deque deq2 is: deq2 = ( ";  
   for ( d2_Iter = deq2.begin( ) ; d2_Iter != deq2.end( ) ; d2_Iter++ )  
      cout << *d2_Iter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The original deque of CInts is deq1 = ( CInt(5), CInt(1), CInt(10) ).**  
**The deque of CInts with first & last elements swapped is:**  
 **deq1 = ( CInt(10), CInt(1), CInt(5) ).**  
**The deque of CInts with first & last elements swapped back is:**  
 **deq1 = ( CInt(5), CInt(1), CInt(10) ).**  
**Vector v1 is ( 0 1 2 3 ).**  
**Deque deq2 is ( 4 5 ).**  
**After exchanging first elements,**  
 **vector v1 is: v1 = ( 4 1 2 3 ).**  
 **& deque deq2 is: deq2 = ( 0 5 ).**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [iter_swap](../vs140/iter_swap--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)