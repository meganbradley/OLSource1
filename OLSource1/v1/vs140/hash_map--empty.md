---
title: "hash_map::empty"
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
  - "hash_map/stdext::hash_map::empty"
  - "hash_map.empty"
  - "std.hash_map.empty"
  - "std::hash_map::empty"
  - "hash_map::empty"
  - "empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method"
ms.assetid: 4a1fde29-9feb-4965-8e23-55ccb03d8641
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::empty
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Tests if a hash_map is empty.  
  
## Syntax  
  
```  
  
bool empty( ) const;  
  
```  
  
## Return Value  
 **true** if the hash_map is empty; **false** if the hash_map is nonempty.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_empty.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_map <int, int> hm1, hm2;  
  
   typedef pair <int, int> Int_Pair;  
   hm1.insert ( Int_Pair ( 1, 1 ) );  
  
   if ( hm1.empty( ) )  
      cout << "The hash_map hm1 is empty." << endl;  
   else  
      cout << "The hash_map hm1 is not empty." << endl;  
  
   if ( hm2.empty( ) )  
      cout << "The hash_map hm2 is empty." << endl;  
   else  
      cout << "The hash_map hm2 is not empty." << endl;  
}  
```  
  
 **The hash_map hm1 is not empty.**  
**The hash_map hm2 is empty.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)