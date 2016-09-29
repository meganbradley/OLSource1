---
title: "multimap::crbegin"
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
  - "multimap::crbegin"
  - "std.multimap.crbegin"
  - "map/std::multimap::crbegin"
  - "multimap.crbegin"
  - "std::multimap::crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method"
ms.assetid: b455d409-8653-4f51-a53b-c34265344420
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::crbegin
Returns a const iterator addressing the first element in a reversed multimap.  
  
## Syntax  
  
```  
  
const_reverse_iterator crbegin( ) const;  
  
```  
  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [multimap](../vs140/multimap-class.md) or addressing what had been the last element in the unreversed `multimap`.  
  
## Remarks  
 `crbegin` is used with a reversed `multimap` just as [begin](../vs140/multimap--begin.md) is used with a `multimap`.  
  
 With the return value of `crbegin`, the `multimap` object cannot be modified.  
  
 `crbegin` can be used to iterate through a `multimap` backwards.  
  
## Example  
  
```  
// multimap_crbegin.cpp  
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
  
   m1_crIter = m1.crbegin( );  
   cout << "The first element of the reversed multimap m1 is "  
        << m1_crIter -> first << "." << endl;  
}  
```  
  
 **The first element of the reversed multimap m1 is 3.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)