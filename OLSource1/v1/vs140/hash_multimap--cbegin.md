---
title: "hash_multimap::cbegin"
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
  - "hash_multimap::cbegin"
  - "std::hash_multimap::cbegin"
  - "std.hash_multimap.cbegin"
  - "hash_map/stdext::hash_multimap::cbegin"
  - "hash_multimap.cbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cbegin method, hash_multimap class"
  - "cbegin method"
ms.assetid: aab2f134-8e88-4d76-ac13-8a9bf6abb0e5
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::cbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a const iterator addressing the first element in the hash_multimap.  
  
## Syntax  
  
```  
  
const_iterator cbegin( ) const;  
  
```  
  
## Return Value  
 A const bidirectional iterator addressing the first element in the [hash_multimap](../vs140/hash_multimap-class.md) or the location succeeding an empty `hash_multimap`.  
  
## Remark  
 With the return value of `cbegin`, the `hash_multimap` object cannot be modified.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_cbegin.cpp  
// compile with: /EHsc  
#include <hash_multimap>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multimap <int, int> hm1;  
  
   hash_multimap <int, int> :: const_iterator hm1_cIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 2, 4 ) );  
  
   hm1_cIter = hm1.cbegin ( );  
   cout << "The first element of hm1 is "   
        << hm1_cIter -> first << "." << endl;  
   }  
```  
  
 **The first element of hm1 is 2.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)