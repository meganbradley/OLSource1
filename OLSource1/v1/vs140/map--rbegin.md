---
title: "map::rbegin"
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
  - map/std::map::rbegin
  - std::map::rbegin
  - map::rbegin
  - rbegin
  - map.rbegin
  - std.map.rbegin
dev_langs: 
  - C++
helpviewer_keywords: 
  - rbegin method
ms.assetid: 92ad1d35-f269-4578-a98a-42f6763a1f46
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# map::rbegin
Returns an iterator addressing the first element in a reversed map.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rbegin( ) const;   
reverse_iterator rbegin( );  
```  
  
## Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed map or addressing what had been the last element in the unreversed map.  
  
## Remarks  
 `rbegin` is used with a reversed map just as [begin](../vs140/map--begin.md) is used with a map.  
  
 If the return value of `rbegin` is assigned to a `const_reverse_iterator`, then the map object cannot be modified. If the return value of `rbegin` is assigned to a `reverse_iterator`, then the map object can be modified.  
  
 `rbegin` can be used to iterate through a map backwards.  
  
## Example  
  
```  
// map_rbegin.cpp  
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
  
   m1_rIter = m1.rbegin( );  
   cout << "The first element of the reversed map m1 is "  
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
   m1_rIter = m1.rbegin( );  
   m1.erase ( m1_rIter -> first );  
  
   m1_rIter = m1.rbegin( );  
   cout << "After the erasure, the first element "  
        << "in the reversed map is "  
        << m1_rIter -> first << "." << endl;  
}  
```  
  
 **The first element of the reversed map m1 is 3.**  
**The map is: 1 2 3 .**  
**The reversed map is: 3 2 1 .**  
**After the erasure, the first element in the reversed map is 2.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)