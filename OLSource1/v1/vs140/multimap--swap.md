---
title: "multimap::swap"
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
  - "map/std::multimap::swap"
  - "std::multimap::swap"
  - "multimap::swap"
  - "std.multimap.swap"
  - "swap"
  - "multimap.swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 38751864-0738-4381-a3fb-e18b0956dd37
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::swap
Exchanges the elements of two multimaps.  
  
## Syntax  
  
```  
void swap(  
   multimap<Key, Type, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The multimap providing the elements to be swapped, or the multimap whose elements are to be exchanged with those of the multimap `_Left`.  
  
## Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two multimaps whose elements are being exchanged.  
  
## Example  
  
```  
// multimap_swap.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multimap <int, int> m1, m2, m3;  
   multimap <int, int>::iterator m1_Iter;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 2, 20 ) );  
   m1.insert ( Int_Pair ( 3, 30 ) );  
   m2.insert ( Int_Pair ( 10, 100 ) );  
   m2.insert ( Int_Pair ( 20, 200 ) );  
   m3.insert ( Int_Pair ( 30, 300 ) );  
  
   cout << "The original multimap m1 is:";  
   for ( m1_Iter = m1.begin( ); m1_Iter != m1.end( ); m1_Iter++ )  
      cout << " " << m1_Iter -> second;  
   cout   << "." << endl;  
  
   // This is the member function version of swap  
   m1.swap( m2 );  
  
   cout << "After swapping with m2, multimap m1 is:";  
   for ( m1_Iter = m1.begin( ); m1_Iter != m1.end( ); m1_Iter++ )  
      cout << " " << m1_Iter -> second;  
   cout  << "." << endl;  
  
   // This is the specialized template version of swap  
   swap( m1, m3 );  
  
   cout << "After swapping with m3, multimap m1 is:";  
   for ( m1_Iter = m1.begin( ); m1_Iter != m1.end( ); m1_Iter++ )  
      cout << " " << m1_Iter -> second;  
   cout   << "." << endl;  
}  
```  
  
 **The original multimap m1 is: 10 20 30.**  
**After swapping with m2, multimap m1 is: 100 200.**  
**After swapping with m3, multimap m1 is: 300.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)