---
title: "multimap::crend"
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
  - multimap::crend
  - multimap.crend
  - std.multimap.crend
  - map/std::multimap::crend
  - std::multimap::crend
dev_langs: 
  - C++
helpviewer_keywords: 
  - crend method
ms.assetid: b034e66f-8c2c-4e7f-987f-9a8434734217
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multimap::crend
Returns a const iterator that addresses the location succeeding the last element in a reversed multimap.  
  
## Syntax  
  
```  
  
const_reverse_iterator crend( ) const;  
  
```  
  
## Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [multimap](../vs140/multimap-class.md) (the location that had preceded the first element in the unreversed `multimap`).  
  
## Remarks  
 `crend` is used with a reversed `multimap` just as [end](../vs140/multimap--end.md) is used with a `multimap`.  
  
 With the return value of `crend`, the `multimap` object cannot be modified.  
  
 `crend` can be used to test to whether a reverse iterator has reached the end of its `multimap`.  
  
 The value returned by `crend` should not be dereferenced.  
  
## Example  
  
```  
// multimap_crend.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multimap <int, int> m1;  
  
   multimap <int, int> :: const_reverse_iterator m1_crIter;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 2, 20 ) );  
   m1.insert ( Int_Pair ( 3, 30 ) );  
  
   m1_crIter = m1.crend( );  
   m1_crIter--;  
   cout << "The last element of the reversed multimap m1 is "  
        << m1_crIter -> first << "." << endl;  
}  
```  
  
 **The last element of the reversed multimap m1 is 1.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)