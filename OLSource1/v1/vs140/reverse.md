---
title: "reverse"
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
  - "std::reverse"
  - "reverse"
  - "std.reverse"
  - "xutility/std::reverse"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse"
  - "reverse function [C++]"
ms.assetid: 824d7107-6cff-40d3-8875-e07a6fc4f16e
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse
Reverses the order of the elements within a range.  
  
## Syntax  
  
```  
  
   template<class BidirectionalIterator>  
void reverse(  
   BidirectionalIterator _First,   
   BidirectionalIterator _Last  
);  
```  
  
#### Parameters  
 `_First`  
 A bidirectional iterator pointing to the position of the first element in the range within which the elements are being permuted.  
  
 `_Last`  
 A bidirectional iterator pointing to the position one past the final element in the range within which the elements are being permuted.  
  
## Remarks  
 The source range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
## Example  
  
```  
// alg_reverse.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
int main( ) {  
   using namespace std;  
   vector <int> v1;  
   vector <int>::iterator Iter1;  
  
   int i;  
   for ( i = 0 ; i <= 9 ; i++ )  
   {  
      v1.push_back( i );  
   }  
  
   cout << "The original vector v1 is:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Reverse the elements in the vector   
   reverse (v1.begin( ), v1.end( ) );  
  
   cout << "The modified vector v1 with values reversed is:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The original vector v1 is:**  
 **( 0 1 2 3 4 5 6 7 8 9 ).**  
**The modified vector v1 with values reversed is:**  
 **( 9 8 7 6 5 4 3 2 1 0 ).**   
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [reverse](../vs140/reverse--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)