---
title: "rotate"
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
  - "std::rotate"
  - "std.rotate"
  - "rotate"
  - "xutility/std::rotate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rotate function"
  - "rotate"
ms.assetid: dacfa67d-4139-45a5-8265-2e2187231392
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rotate
Exchanges the elements in two adjacent ranges.  
  
## Syntax  
  
```  
  
   template<class ForwardIterator>  
void rotate(  
   ForwardIterator _First,   
   ForwardIterator _Middle,   
   ForwardIterator _Last  
);  
```  
  
#### Parameters  
 `_First`  
 A forward iterator addressing the position of the first element in the range to be rotated.  
  
 `_Middle`  
 A forward iterator defining the boundary within the range that addresses the position of the first element in the second part of the range whose elements are to be exchanged with those in the first part of the range.  
  
 _ `Last`  
 A forward iterator addressing the position one past the final element in the range to be rotated.  
  
## Remarks  
 The ranges referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The complexity is linear with at most (`_Last` – `_First`) swaps.  
  
## Example  
  
```  
// alg_rotate.cpp  
// compile with: /EHsc  
#include <vector>  
#include <deque>  
#include <algorithm>  
#include <iostream>  
  
int main( ) {  
   using namespace std;  
   vector <int> v1;  
   deque <int> d1;  
   vector <int>::iterator v1Iter1;  
   deque<int>::iterator d1Iter1;  
  
   int i;  
   for ( i = -3 ; i <= 5 ; i++ )  
   {  
      v1.push_back( i );  
   }  
  
   int ii;  
   for ( ii =0 ; ii <= 5 ; ii++ )  
   {  
      d1.push_back( ii );  
   }  
  
   cout << "Vector v1 is ( " ;  
   for ( v1Iter1 = v1.begin( ) ; v1Iter1 != v1.end( ) ;v1Iter1 ++ )  
      cout << *v1Iter1  << " ";  
   cout << ")." << endl;  
  
   rotate ( v1.begin ( ) , v1.begin ( ) + 3 , v1.end ( ) );  
   cout << "After rotating, vector v1 is ( " ;  
   for ( v1Iter1 = v1.begin( ) ; v1Iter1 != v1.end( ) ;v1Iter1 ++ )  
      cout << *v1Iter1  << " ";  
   cout << ")." << endl;  
  
   cout << "The original deque d1 is ( " ;  
   for ( d1Iter1 = d1.begin( ) ; d1Iter1 != d1.end( ) ;d1Iter1 ++ )  
      cout << *d1Iter1  << " ";  
   cout << ")." << endl;  
  
   int iii = 1;  
   while ( iii <= d1.end ( ) - d1.begin ( ) ) {  
      rotate ( d1.begin ( ) , d1.begin ( ) + 1 , d1.end ( ) );  
      cout << "After the rotation of a single deque element to the back,\n d1 is   ( " ;  
      for ( d1Iter1 = d1.begin( ) ; d1Iter1 != d1.end( ) ;d1Iter1 ++ )  
         cout << *d1Iter1  << " ";  
      cout << ")." << endl;  
      iii++;  
   }  
}  
```  
  
 **Vector v1 is ( -3 -2 -1 0 1 2 3 4 5 ).**  
**After rotating, vector v1 is ( 0 1 2 3 4 5 -3 -2 -1 ).**  
**The original deque d1 is ( 0 1 2 3 4 5 ).**  
**After the rotation of a single deque element to the back,**  
 **d1 is   ( 1 2 3 4 5 0 ).**  
**After the rotation of a single deque element to the back,**  
 **d1 is   ( 2 3 4 5 0 1 ).**  
**After the rotation of a single deque element to the back,**  
 **d1 is   ( 3 4 5 0 1 2 ).**  
**After the rotation of a single deque element to the back,**  
 **d1 is   ( 4 5 0 1 2 3 ).**  
**After the rotation of a single deque element to the back,**  
 **d1 is   ( 5 0 1 2 3 4 ).**  
**After the rotation of a single deque element to the back,**  
 **d1 is   ( 0 1 2 3 4 5 ).**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [rotate](../vs140/rotate--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)