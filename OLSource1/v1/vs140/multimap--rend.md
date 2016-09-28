---
title: "multimap::rend"
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
  - "rend"
  - "multimap::rend"
  - "map/std::multimap::rend"
  - "multimap.rend"
  - "std.multimap.rend"
  - "std::multimap::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 123acd21-9da0-455d-a7c4-d39ac7fa5fd7
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::rend
Returns an iterator that addresses the location succeeding the last element in a reversed multimap.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rend( ) const;   
reverse_iterator rend( );  
```  
  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed multimap (the location that had preceded the first element in the unreversed multimap).  
  
## Remarks  
 `rend` is used with a reversed multimap just as [end](../vs140/map--end.md) is used with a multimap.  
  
 If the return value of `rend` is assigned to a `const_reverse_iterator`, then the multimap object cannot be modified. If the return value of `rend` is assigned to a `reverse_iterator`, then the multimap object can be modified.  
  
 `rend` can be used to test to whether a reverse iterator has reached the end of its multimap.  
  
 The value returned by `rend` should not be dereferenced.  
  
## Example  
  
```  
// multimap_rend.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multimap <int, int> m1;  
  
   multimap <int, int> :: iterator m1_Iter;  
   multimap <int, int> :: reverse_iterator m1_rIter;  
   multimap <int, int> :: const_reverse_iterator m1_crIter;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 2, 20 ) );  
   m1.insert ( Int_Pair ( 3, 30 ) );  
  
   m1_rIter = m1.rend( );  
   m1_rIter--;  
   cout << "The last element of the reversed multimap m1 is "  
        << m1_rIter -> first << "." << endl;  
  
   // begin can be used to start an iteration   
   // throught a multimap in a forward order  
   cout << "The multimap is: ";  
   for ( m1_Iter = m1.begin( ) ; m1_Iter != m1.end( ); m1_Iter++)  
      cout << m1_Iter -> first << " ";  
      cout << "." << endl;  
  
   // rbegin can be used to start an iteration   
   // throught a multimap in a reverse order  
   cout << "The reversed multimap is: ";  
   for ( m1_rIter = m1.rbegin( ) ; m1_rIter != m1.rend( ); m1_rIter++)  
      cout << m1_rIter -> first << " ";  
      cout << "." << endl;  
  
   // A multimap element can be erased by dereferencing to its key   
   m1_rIter = --m1.rend( );  
   m1.erase ( m1_rIter -> first );  
  
   m1_rIter = m1.rend( );  
   m1_rIter--;  
   cout << "After the erasure, the last element "  
        << "in the reversed multimap is "  
        << m1_rIter -> first << "." << endl;  
}  
```  
  
 **The last element of the reversed multimap m1 is 1.**  
**The multimap is: 1 2 3 .**  
**The reversed multimap is: 3 2 1 .**  
**After the erasure, the last element in the reversed multimap is 2.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)