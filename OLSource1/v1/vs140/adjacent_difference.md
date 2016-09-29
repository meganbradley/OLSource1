---
title: "adjacent_difference"
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
  - "std.adjacent_difference"
  - "std::adjacent_difference"
  - "adjacent_difference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "adjacent_difference function"
ms.assetid: f44e205d-d480-4336-b6a6-5af60ced58e3
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# adjacent_difference
Computes the successive differences between each element and its predecessor in an input range and outputs the results to a destination range or computes the result of a generalized procedure where the difference operation is replaced by another, specified binary operation.  
  
## Syntax  
  
```  
  
      template<class InputIterator, class OutIterator>  
   OutputIterator adjacent_difference(  
      InputIterator _First,   
      InputIterator _Last,  
      OutputIterator _Result   
   );  
  
template<class InputIterator, class OutIterator, class BinaryOperation>  
   OutputIterator adjacent_difference(  
      InputIterator _First,   
      InputIterator _Last,  
      OutputIterator _Result,   
      BinaryOperation _Binary_op  
   );  
```  
  
#### Parameters  
 `_First`  
 An input iterator addressing the first element in the input range whose elements are to be differenced with their respective predecessors or where the pair of values is to be operated on by another specified binary operation.  
  
 `_Last`  
 An input iterator addressing the last element in the input range whose elements are to be differenced with their respective predecessors or where the pair of values is to be operated on by another specified binary operation.  
  
 `_Result`  
 An output iterator addressing the first element a destination range where the series of differences or the results of the specified operation is to be stored.  
  
 `_Binary_op`  
 The binary operation that is to be applied in the generalized operation replacing the operation of subtraction in the differencing procedure.  
  
## Return Value  
 An output iterator addressing the end of the destination range: `_Result` + (`_Last` - `_First`).  
  
## Remarks  
 The output iterator _*Result* is allowed to be the same iterator as the input iterator *_First,* so that `adjacent_difference`s may be computed in place.  
  
 For a sequence of values *a*1, *a*2, *a*3, in an input range, the first template function stores successive **partial_difference**s *a*1, *a*2 - *a*1, a3 – *a*2, in the destination range.  
  
 For a sequence of values *a*1, *a*2, *a*3, in an input range, the second template function stores successive **partial_difference**s *a*1, *a*2 `_Binary_op` *a*1, *a*3 `_Binary_op` *a*2, in the destination range.  
  
 The binary operation `_Binary_op` is not required to be either associative or commutative, because the order of operations applies is completely specified.  
  
## Example  
  
```cpp  
// numeric_adj_diff.cpp  
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
   list <int>::iterator LIter1, LIterend, LIterend2;  
  
   int t;  
   for ( t = 1 ; t <= 10 ; t++ )  
   {  
      L1.push_back( t * t );  
   }  
  
   cout << "The input list L1 is:\n ( " ;  
   for ( LIter1 = L1.begin( ) ; LIter1 != L1.end( ) ; LIter1++ )  
      cout << *LIter1 << " ";  
   cout << ")." << endl;  
  
   // The first member function for the adjacent_differences of  
   // elements in a list output to a vector  
   VIterend = adjacent_difference ( L1.begin ( ) , L1.end ( ) ,   
      V1.begin ( ) );  
  
   cout << "Output vector containing adjacent_differences is:\n ( " ;  
   for ( VIter1 = V1.begin( ) ; VIter1 != VIterend ; VIter1++ )  
      cout << *VIter1 << " ";  
   cout << ")." << endl;  
  
   // The second member function used to compute  
   // the adjacent products of the elements in a list  
   VIterend2 = adjacent_difference ( L1.begin ( ) , L1.end ( ) , V2.begin ( ) ,   
      multiplies<int>( ) );  
  
   cout << "The output vector with the adjacent products is:\n ( " ;  
   for ( VIter2 = V2.begin( ) ; VIter2 != VIterend2 ; VIter2++ )  
      cout << *VIter2 << " ";  
   cout << ")." << endl;  
  
   // Computation of adjacent_differences in place  
   LIterend2 = adjacent_difference ( L1.begin ( ) , L1.end ( ) , L1.begin ( ) );  
   cout << "In place output adjacent_differences in list L1 is:\n ( " ;  
   for ( LIter1 = L1.begin( ) ; LIter1 != LIterend2 ; LIter1++ )  
      cout << *LIter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Output  
  
```  
The input list L1 is:  
 ( 1 4 9 16 25 36 49 64 81 100 ).  
Output vector containing adjacent_differences is:  
 ( 1 3 5 7 9 11 13 15 17 19 ).  
The output vector with the adjacent products is:  
 ( 1 4 36 144 400 900 1764 3136 5184 8100 ).  
In place output adjacent_differences in list L1 is:  
 ( 1 3 5 7 9 11 13 15 17 19 ).  
```  
  
## Requirements  
 **Header:** \<numeric>  
  
 **Namespace:** std  
  
## See Also  
 [adjacent_difference and vector::push_back](../vs140/adjacent_difference-and-vector--push_back.md)   
 [Standard Template Library](../vs140/standard-template-library.md)