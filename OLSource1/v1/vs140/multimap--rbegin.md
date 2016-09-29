---
title: "multimap::rbegin"
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
  - "std.multimap.rbegin"
  - "std::multimap::rbegin"
  - "multimap.rbegin"
  - "rbegin"
  - "map/std::multimap::rbegin"
  - "multimap::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: 2d08ac88-d8c6-4d9f-9247-0ad8d2796a78
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::rbegin
Returns an iterator addressing the first element in a reversed multimap.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rbegin( ) const;   
reverse_iterator rbegin( );  
```  
  
## Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed multimap or addressing what had been the last element in the unreversed multimap.  
  
## Remarks  
 `rbegin` is used with a reversed multimap just as [begin](../vs140/multimap--begin.md) is used with a multimap.  
  
 If the return value of `rbegin` is assigned to a `const_reverse_iterator`, then the multimap object cannot be modified. If the return value of `rbegin` is assigned to a `reverse_iterator`, then the multimap object can be modified.  
  
 `rbegin` can be used to iterate through a multimap backwards.  
  
## Example  
  
```  
// multimap_rbegin.cpp  
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
  
   m1_rIter = m1.rbegin( );  
   cout << "The first element of the reversed multimap m1 is "  
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
  
   // A multimap element can be erased by dereferencing its key   
   m1_rIter = m1.rbegin( );  
   m1.erase ( m1_rIter -> first );  
  
   m1_rIter = m1.rbegin( );  
   cout << "After the erasure, the first element "  
        << "in the reversed multimap is "  
        << m1_rIter -> first << "." << endl;  
}  
```  
  
 **The first element of the reversed multimap m1 is 3.**  
**The multimap is: 1 2 3 .**  
**The reversed multimap is: 3 2 1 .**  
**After the erasure, the first element in the reversed multimap is 2.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)