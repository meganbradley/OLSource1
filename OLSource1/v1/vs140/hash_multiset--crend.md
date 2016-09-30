---
title: "hash_multiset::crend"
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
  - "hash_set/stdext::hash_multiset::crend"
  - "stdext::hash_multiset::crend"
  - "stdext.hash_multiset.crend"
  - "hash_multiset::crend"
  - "hash_multiset.crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method"
ms.assetid: 1161683a-94bd-43a2-91a5-68b7f5752020
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::crend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a reversed hash_multiset.  
  
## Syntax  
  
```  
  
const_reverse_iterator crend( ) const;  
  
```  
  
## Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [hash_multiset](../vs140/hash_multiset-class.md) (the location that had preceded the first element in the unreversed `hash_multiset`).  
  
## Remarks  
 `crend` is used with a reversed `hash_multiset` just as [end](../vs140/hash_multiset--end.md) is used with a `hash_multiset`.  
  
 With the return value of `crend`, the `hash_multiset` object cannot be modified.  
  
 `crend` can be used to test to whether a reverse iterator has reached the end of its hash_multiset.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_crend.cpp  
// compile with: /EHsc  
#include <hash_multiset>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset <int> hs1;  
   hash_multiset <int>::const_reverse_iterator hs1_crIter;  
  
   hs1.insert( 10 );  
   hs1.insert( 20 );  
   hs1.insert( 30 );  
  
   hs1_crIter = hs1.crend( );  
   hs1_crIter--;  
   cout << "The last element in the reversed hash_multiset is "  
        << *hs1_crIter << "." << endl;  
}  
```  
  
 **The last element in the reversed hash_multiset is 10.**   
## Requirements  
 **Header:** <hash_multiset>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)