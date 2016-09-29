---
title: "deque::difference_type"
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
  - "deque::difference_type"
  - "std.deque.difference_type"
  - "difference_type"
  - "std::deque::difference_type"
  - "deque/std::deque::difference_type"
  - "deque.difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: f69c5618-96fa-494d-95aa-1b32c0450328
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::difference_type
A type that provides the difference between two iterators that refer to elements within the same deque.  
  
## Syntax  
  
```  
typedef typename Allocator::difference_type difference_type;  
```  
  
## Remarks  
 A `difference_type` can also be described as the number of elements between two pointers.  
  
## Example  
  
```  
// deque_diff_type.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <deque>  
#include <algorithm>  
  
int main( )   
{  
   using namespace std;  
  
   deque <int> c1;  
   deque <int>::iterator c1_Iter, c2_Iter;  
  
   c1.push_back( 30 );  
   c1.push_back( 20 );  
   c1.push_back( 30 );  
   c1.push_back( 10 );  
   c1.push_back( 30 );  
   c1.push_back( 20 );  
  
   c1_Iter = c1.begin( );  
   c2_Iter = c1.end( );  
  
   deque <int>::difference_type df_typ1, df_typ2, df_typ3;  
  
   df_typ1 = count( c1_Iter, c2_Iter, 10 );  
   df_typ2 = count( c1_Iter, c2_Iter, 20 );  
   df_typ3 = count( c1_Iter, c2_Iter, 30 );  
   cout << "The number '10' is in c1 collection " << df_typ1 << " times.\n";  
   cout << "The number '20' is in c1 collection " << df_typ2 << " times.\n";  
   cout << "The number '30' is in c1 collection " << df_typ3 << " times.\n";  
}  
```  
  
 **The number '10' is in c1 collection 1 times.**  
**The number '20' is in c1 collection 2 times.**  
**The number '30' is in c1 collection 3 times.**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)