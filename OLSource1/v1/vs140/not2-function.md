---
title: "not2 Function"
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
  - "xfunctional/std::not2"
  - "std::not2"
  - "not2"
  - "std.not2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "not2 function"
  - "not2"
ms.assetid: 78ed2ed6-67a8-4892-9222-94039fc36763
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# not2 Function
Returns the complement of a binary predicate.  
  
## Syntax  
  
```  
  
   template<class BinaryPredicate>  
binary_negate<BinaryPredicate> not2(  
   const BinaryPredicate& _Func  
);  
```  
  
#### Parameters  
 `_Func`  
 The binary predicate to be negated.  
  
## Return Value  
 A binary predicate that is the negation of the binary predicate modified.  
  
## Remarks  
 If a `binary_negate` is constructed from a binary predicate **BinPred**(*x*, *y*), then it returns ! **BinPred**(*x*, *y*).  
  
## Example  
  
```  
// functional_not2.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>  
#include <cstdlib>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   vector <int> v1;  
   vector <int>::iterator Iter1;  
  
   int i;  
   v1.push_back( 6262 );  
   v1.push_back( 6262 );  
   for ( i = 0 ; i < 5 ; i++ )  
   {  
      v1.push_back( rand( ) );  
   }  
  
   cout << "Original vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // To sort in ascending order,  
   // use default binary predicate less<int>( )  
   sort( v1.begin( ), v1.end( ) );  
   cout << "Sorted vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // To sort in descending order,   
   // use the binary_negate helper function not2  
   sort( v1.begin( ), v1.end( ), not2(less<int>( ) ) );  
   cout << "Resorted vector v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
}  
```  
  
 **Original vector v1 = ( 6262 6262 41 18467 6334 26500 19169 )**  
**Sorted vector v1 = ( 41 6262 6262 6334 18467 19169 26500 )**  
**Resorted vector v1 = ( 26500 19169 18467 6334 6262 6262 41 )**   
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)