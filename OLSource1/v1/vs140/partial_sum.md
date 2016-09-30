---
title: "partial_sum"
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
  - "partial_sum"
  - "std.partial_sum"
  - "std::partial_sum"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "partial_sum function"
ms.assetid: 65f8180d-5f85-4b6a-bbb5-99bbe776f691
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partial_sum
Computes a series of sums in an input range from the first element through the *i*th element and stores the result of each such sum in the *i*th element of a destination range or computes the result of a generalized procedure where the sum operation is replaced by another specified binary operation.  
  
## Syntax  
  
```  
  
      template<class InputIterator, class OutIt>  
   OutputIterator partial_sum(  
      InputIterator _First,   
      InputIterator _Last,  
      OutputIterator _Result  
   );  
  
template<class InputIterator, class OutIt, class Fn2>  
   OutputIterator partial_sum(  
      InputIterator _First,   
      InputIterator _Last,  
      OutputIterator _Result,   
      BinaryOperation _Binary_op  
   );  
```  
  
#### Parameters  
 `_First`  
 An input iterator addressing the first element in the range to be partially summed or combined according to a specified binary operation.  
  
 `_Last`  
 An input iterator addressing the last element in the range to be partially summed or combined according to a specified binary operation that is one position beyond the final element actually included in the iterated accumulation.  
  
 `_Result`  
 An output iterator addressing the first element a destination range where the series of partial sums or the results of the specified operation is to be stored.  
  
 `_Binary_op`  
 The binary operation that is to be applied in the generalized operation replacing the operation of sum in the partial sum procedure.  
  
## Return Value  
 An output iterator addressing the end of the destination range: `_Result` + (`_Last` - `_First`),  
  
## Remarks  
 The output iterator `_Result` is allowed to be the same iterator as the input iterator `_First`, so that partial sums may be computed in place.  
  
 For a sequence of values *a*1, *a*2, *a*3,  in an input range, the first template function stores successive partial sums in the destination range, where the *i*th element is given by (  ( (*a*1 + *a*2) + *a*3)  *a*i).  
  
 For a sequence of values *a*1, *a*2, *a*3,  in an input range, the second template function stores successive partial sums in the destination range, where the ith element is given by (  ( ( *a*1 `_Binary_op` *a*2 ) `_Binary_op` *a*3 )  *a*i).  
  
 The binary operation `_Binary_op` is not required to be either associative or commutative, because the order of operations applies is completely specified.  
  
## Example  
  
```cpp  
// numeric_partial_sum.cpp  
// compile with: /EHsc  
#include <vector>  
#include <list>  
#include <numeric>  
#include <functional>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;     
   vector<int> V1( 10 ), V2( 10 );  
   vector<int>::iterator VIter1, VIter2, VIterend, VIterend2;  
  
   list <int> L1;  
   list <int>::iterator LIter1, LIterend;  
  
   int t;  
   for ( t = 1 ; t <= 10 ; t++ )  
   {  
      L1.push_back( t );  
   }  
  
   cout << "The input list L1 is:\n ( " ;  
   for ( LIter1 = L1.begin( ) ; LIter1 != L1.end( ) ; LIter1++ )  
      cout << *LIter1 << " ";  
   cout << ")." << endl;  
  
   // The first member function for the partial sums of  
   // elements in a list output to a vector  
   VIterend = partial_sum ( L1.begin ( ) , L1.end ( ) ,   
      V1.begin ( ) );  
  
   cout << "The output vector containing the partial sums is:\n ( " ;  
   for ( VIter1 = V1.begin( ) ; VIter1 != VIterend ; VIter1++ )  
      cout << *VIter1 << " ";  
   cout << ")." << endl;  
  
   // The second member function used to compute  
   // the partial product of the elements in a list  
   VIterend2 = partial_sum ( L1.begin ( ) , L1.end ( ) , V2.begin ( ) ,   
      multiplies<int>( ) );  
  
   cout << "The output vector with the partial products is:\n ( " ;  
   for ( VIter2 = V2.begin( ) ; VIter2 != VIterend2 ; VIter2++ )  
      cout << *VIter2 << " ";  
   cout << ")." << endl;  
  
   // Computation of partial sums in place  
   LIterend = partial_sum ( L1.begin ( ) , L1.end ( ) , L1.begin ( ) );  
   cout << "The in place output partial_sum list L1 is:\n ( " ;  
   for ( LIter1 = L1.begin( ) ; LIter1 != LIterend ; LIter1++ )  
      cout << *LIter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Output  
  
```  
The input list L1 is:  
 ( 1 2 3 4 5 6 7 8 9 10 ).  
The output vector containing the partial sums is:  
 ( 1 3 6 10 15 21 28 36 45 55 ).  
The output vector with the partial products is:  
 ( 1 2 6 24 120 720 5040 40320 362880 3628800 ).  
The in place output partial_sum list L1 is:  
 ( 1 3 6 10 15 21 28 36 45 55 ).  
```  
  
## Requirements  
 **Header:** \<numeric>  
  
 **Namespace:** std  
  
## See Also  
 [partial_sum](../vs140/partial_sum--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)