---
title: "hash_multiset::crbegin"
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
  - "hash_multiset::crbegin"
  - "hash_set/stdext::hash_multiset.crbegin"
  - "stdext.hash_multiset.crbegin"
  - "hash_multiset.crbegin"
  - "stdext::hash_multiset::crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method"
ms.assetid: 160aa028-8b22-43b0-8905-25cb37f64600
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::crbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a const iterator addressing the first element in a reversed hash_multiset.  
  
## Syntax  
  
```  
  
const_reverse_iterator crbegin( ) const;  
  
```  
  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [hash_multiset](../vs140/hash_multiset-class.md) or addressing what had been the last element in the unreversed `hash_multiset`.  
  
## Remarks  
 `crbegin` is used with a reversed `hash_multiset` just as [begin](../vs140/hash_multiset--begin.md) is used with a `hash_multiset`.  
  
 With the return value of `crbegin`, the `hash_multiset` object cannot be modified.  
  
 `crbegin` can be used to iterate through a `hash_multiset` backwards.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_crbegin.cpp  
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
  
   hs1_crIter = hs1.crbegin( );  
   cout << "The first element in the reversed hash_multiset is "  
        << *hs1_crIter << "." << endl;  
}  
```  
  
 **The first element in the reversed hash_multiset is 30.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)