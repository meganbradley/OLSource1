---
title: "hash_multimap::crend"
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
  - "hash_map/stdext::hash_multimap::crend"
  - "std.hash_multimap.crend"
  - "std::hash_multimap::crend"
  - "crend"
  - "hash_multimap.crend"
  - "hash_multimap::crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method, hash_multimap class"
  - "crend method"
ms.assetid: a67c0c09-5903-4d7a-8161-c3035eaa270c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::crend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a reversed hash_multimap.  
  
## Syntax  
  
```  
  
const_reverse_iterator crend( ) const;   
```  
  
## Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [hash_multimap](../vs140/hash_multimap-class.md) (the location that had preceded the first element in the unreversed `hash_multimap`).  
  
## Remarks  
 `crend` is used with a reversed hash_multimap just as [end](../vs140/hash_multimap--end.md) is used with a hash_multimap.  
  
 With the return value of `crend`, the `hash_multimap` object cannot be modified.  
  
 `crend` can be used to test to whether a reverse iterator has reached the end of its hash_multimap.  
  
 The value returned by `crend` should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_crend.cpp  
// compile with: /EHsc  
#include <hash_multimap>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multimap <int, int> hm1;  
  
   hash_multimap <int, int> :: const_reverse_iterator hm1_crIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 3, 30 ) );  
  
   hm1_crIter = hm1.crend( );  
   hm1_crIter--;  
   cout << "The last element of the reversed hash_multimap hm1 is "  
        << hm1_crIter -> first << "." << endl;  
}  
```  
  
 **The last element of the reversed hash_multimap hm1 is 3.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)