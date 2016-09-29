---
title: "hash_multimap::empty"
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
  - "std::hash_multimap::empty"
  - "hash_map/stdext::hash_multimap::empty"
  - "hash_multimap::empty"
  - "std.hash_multimap.empty"
  - "hash_multimap.empty"
  - "Empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method"
ms.assetid: d57af8a9-5cb5-48aa-bad0-92b0236f9a5d
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::empty
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Tests if a hash_multimap is empty.  
  
## Syntax  
  
```  
  
bool empty( ) const;  
  
```  
  
## Return Value  
 **true** if the hash_multimap is empty; **false** if the hash_multimap is nonempty.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_empty.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multimap <int, int> hm1, hm2;  
  
   typedef pair <int, int> Int_Pair;  
   hm1.insert ( Int_Pair ( 1, 1 ) );  
  
   if ( hm1.empty( ) )  
      cout << "The hash_multimap hm1 is empty." << endl;  
   else  
      cout << "The hash_multimap hm1 is not empty." << endl;  
  
   if ( hm2.empty( ) )  
      cout << "The hash_multimap hm2 is empty." << endl;  
   else  
      cout << "The hash_multimap hm2 is not empty." << endl;  
}  
```  
  
 **The hash_multimap hm1 is not empty.**  
**The hash_multimap hm2 is empty.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)