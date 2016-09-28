---
title: "map::crend"
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
  - "map::crend"
  - "std.map.crend"
  - "map/std::map::crend"
  - "std::map::crend"
  - "map.crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method"
ms.assetid: 199b68fb-33e9-4adc-9ebe-c00aa93d3ed8
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::crend
Returns a const iterator that addresses the location succeeding the last element in a reversed map.  
  
## Syntax  
  
```  
  
const_reverse_iterator crend( ) const;  
  
```  
  
## Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [map](../vs140/map-class.md) (the location that had preceded the first element in the unreversed `map`).  
  
## Remarks  
 `crend` is used with a reversed map just as [end](../vs140/map--end.md) is used with a `map`.  
  
 With the return value of `crend`, the `map` object cannot be modified.  
  
 `crend` can be used to test to whether a reverse iterator has reached the end of its `map`.  
  
 The value returned by `crend` should not be dereferenced.  
  
## Example  
  
```  
// map_crend.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   map <int, int> m1;  
  
   map <int, int> :: const_reverse_iterator m1_crIter;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 2, 20 ) );  
   m1.insert ( Int_Pair ( 3, 30 ) );  
  
   m1_crIter = m1.crend( );  
   m1_crIter--;  
   cout << "The last element of the reversed map m1 is "  
        << m1_crIter -> first << "." << endl;  
}  
```  
  
 **The last element of the reversed map m1 is 1.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)