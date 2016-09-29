---
title: "multimap::empty"
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
  - "std.multimap.empty"
  - "multimap.empty"
  - "multimap::empty"
  - "std::multimap::empty"
  - "map/std::multimap::empty"
  - "empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method"
ms.assetid: f8b69547-10b8-48a5-a5bb-75f1ff605ec7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::empty
Tests if a multimap is empty.  
  
## Syntax  
  
```  
  
bool empty( ) const;  
  
```  
  
## Return Value  
 **true** if the multimap is empty; **false** if the multimap is nonempty.  
  
## Example  
  
```  
// multimap_empty.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multimap <int, int> m1, m2;  
  
   typedef pair <int, int> Int_Pair;  
   m1.insert ( Int_Pair ( 1, 1 ) );  
  
   if ( m1.empty( ) )  
      cout << "The multimap m1 is empty." << endl;  
   else  
      cout << "The multimap m1 is not empty." << endl;  
  
   if ( m2.empty( ) )  
      cout << "The multimap m2 is empty." << endl;  
   else  
      cout << "The multimap m2 is not empty." << endl;  
}  
```  
  
 **The multimap m1 is not empty.**  
**The multimap m2 is empty.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)