---
title: "map::swap"
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
  - map.swap
  - map::swap
  - std.map.swap
  - map/std::map::swap
  - std::map::swap
  - swap
dev_langs: 
  - C++
helpviewer_keywords: 
  - swap method
ms.assetid: 0b46d3dd-7516-472a-a3bc-d29347833ef2
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# map::swap
Exchanges the elements of two maps.  
  
## Syntax  
  
```  
void swap(  
   map<Key, Type, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The argument map providing the elements to be swapped with the target map.  
  
## Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two maps whose elements are being exchanged.  
  
## Example  
  
```  
// map_swap.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   map <int, int> m1, m2, m3;  
   map <int, int>::iterator m1_Iter;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 2, 20 ) );  
   m1.insert ( Int_Pair ( 3, 30 ) );  
   m2.insert ( Int_Pair ( 10, 100 ) );  
   m2.insert ( Int_Pair ( 20, 200 ) );  
   m3.insert ( Int_Pair ( 30, 300 ) );  
  
   cout << "The original map m1 is:";  
   for ( m1_Iter = m1.begin( ); m1_Iter != m1.end( ); m1_Iter++ )  
      cout << " " << m1_Iter -> second;  
   cout   << "." << endl;  
  
   // This is the member function version of swap  
   //m2 is said to be the argument map; m1 the target map  
   m1.swap( m2 );  
  
   cout << "After swapping with m2, map m1 is:";  
   for ( m1_Iter = m1.begin( ); m1_Iter != m1.end( ); m1_Iter++ )  
      cout << " " << m1_Iter -> second;  
   cout  << "." << endl;  
  
   // This is the specialized template version of swap  
   swap( m1, m3 );  
  
   cout << "After swapping with m3, map m1 is:";  
   for ( m1_Iter = m1.begin( ); m1_Iter != m1.end( ); m1_Iter++ )  
      cout << " " << m1_Iter -> second;  
   cout   << "." << endl;  
}  
```  
  
 **The original map m1 is: 10 20 30.**  
**After swapping with m2, map m1 is: 100 200.**  
**After swapping with m3, map m1 is: 300.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)