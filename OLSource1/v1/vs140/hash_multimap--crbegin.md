---
title: "hash_multimap::crbegin"
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
  - "std.hash_multimap.crbegin"
  - "hash_multimap.crbegin"
  - "hash_multimap::crbegin"
  - "std::hash_multimap::crbegin"
  - "hash_map/stdext::hash_multimap::crbegin"
  - "crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method, hash_multimap class"
  - "crbegin method"
ms.assetid: a9ab949a-00f2-4259-ba98-11a963375a98
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::crbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a const iterator addressing the first element in a reversed hash_multimap.  
  
## Syntax  
  
```  
  
const_reverse_iterator crbegin( ) const;  
  
```  
  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [hash_multimap](../vs140/hash_multimap-class.md) or addressing what had been the last element in the unreversed `hash_multimap`.  
  
## Remarks  
 `crbegin` is used with a reversed hash_multimap just as [begin](../vs140/hash_multimap--begin.md) is used with a `hash_multimap`.  
  
 With the return value of `crbegin`, the `hash_multimap` object cannot be modified.  
  
 `crbegin` can be used to iterate through a `hash_multimap` backwards.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_crbegin.cpp  
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
  
   hm1_crIter = hm1.crbegin( );  
   cout << "The first element of the reversed hash_multimap hm1 is "  
        << hm1_crIter -> first << "." << endl;  
}  
```  
  
 **The first element of the reversed hash_multimap hm1 is 3.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)