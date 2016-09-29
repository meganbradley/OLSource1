---
title: "hash_set::crend"
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
  - "std::hash_set::crend"
  - "hash_set/stdext::hash_set::crend"
  - "crend"
  - "hash_set::crend"
  - "hash_set.crend"
  - "std.hash_set.crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method, hash_set class"
  - "crend method"
ms.assetid: 926d5d16-0a18-434b-bfcb-4daabd6a8cf0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::crend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a reversed hash_set.  
  
## Syntax  
  
```  
  
const_reverse_iterator crend( ) const;  
  
```  
  
## Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [hash_set](../vs140/hash_set-class.md) (the location that had preceded the first element in the unreversed `hash_set`).  
  
## Remarks  
 `crend` is used with a reversed `hash_set` just as [end](../vs140/hash_set--end.md) is used with a `hash_set`.  
  
 With the return value of `crend`, the `hash_set` object cannot be modified.  
  
 `crend` can be used to test to whether a reverse iterator has reached the end of its `hash_set`.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_crend.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_set <int> hs1;  
   hash_set <int>::const_reverse_iterator hs1_crIter;  
  
   hs1.insert( 10 );  
   hs1.insert( 20 );  
   hs1.insert( 30 );  
  
   hs1_crIter = hs1.crend( );  
   hs1_crIter--;  
   cout << "The last element in the reversed hash_set is "  
        << *hs1_crIter << "." << endl;  
}  
```  
  
 **The last element in the reversed hash_set is 10.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)