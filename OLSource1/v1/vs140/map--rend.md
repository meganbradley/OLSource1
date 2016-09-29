---
title: "map::rend"
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
  - "std.map.rend"
  - "rend"
  - "map/std::map::rend"
  - "std::map::rend"
  - "map::rend"
  - "map.rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: cd8a635a-157d-4f1b-a04b-340d4a9953f4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::rend
Returns an iterator that addresses the location succeeding the last element in a reversed map.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rend( ) const;   
reverse_iterator rend( );  
```  
  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed map (the location that had preceded the first element in the unreversed map).  
  
## Remarks  
 `rend` is used with a reversed map just as [end](../vs140/map--end.md) is used with a map.  
  
 If the return value of `rend` is assigned to a `const_reverse_iterator`, then the map object cannot be modified. If the return value of `rend` is assigned to a `reverse_iterator`, then the map object can be modified.  
  
 `rend` can be used to test to whether a reverse iterator has reached the end of its map.  
  
 The value returned by `rend` should not be dereferenced.  
  
## Example  
  
```  
// map_rend.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   map <int, int> m1;  
  
   map <int, int> :: iterator m1_Iter;  
   map <int, int> :: reverse_iterator m1_rIter;  
   map <int, int> :: const_reverse_iterator m1_crIter;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 2, 20 ) );  
   m1.insert ( Int_Pair ( 3, 30 ) );  
  
   m1_rIter = m1.rend( );  
   m1_rIter--;  
   cout << "The last element of the reversed map m1 is "  
        << m1_rIter -> first << "." << endl;  
  
   // begin can be used to start an iteration   
   // through a map in a forward order  
   cout << "The map is: ";  
   for ( m1_Iter = m1.begin( ) ; m1_Iter != m1.end( ); m1_Iter++)  
      cout << m1_Iter -> first << " ";  
      cout << "." << endl;  
  
   // rbegin can be used to start an iteration   
   // through a map in a reverse order  
   cout << "The reversed map is: ";  
   for ( m1_rIter = m1.rbegin( ) ; m1_rIter != m1.rend( ); m1_rIter++)  
      cout << m1_rIter -> first << " ";  
      cout << "." << endl;  
  
   // A map element can be erased by dereferencing to its key   
   m1_rIter = --m1.rend( );  
   m1.erase ( m1_rIter -> first );  
  
   m1_rIter = m1.rend( );  
   m1_rIter--;  
   cout << "After the erasure, the last element "  
        << "in the reversed map is "  
        << m1_rIter -> first << "." << endl;  
}  
```  
  
 **The last element of the reversed map m1 is 1.**  
**The map is: 1 2 3 .**  
**The reversed map is: 3 2 1 .**  
**After the erasure, the last element in the reversed map is 2.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)