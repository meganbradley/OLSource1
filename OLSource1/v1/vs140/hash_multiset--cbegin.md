---
title: "hash_multiset::cbegin"
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
  - "stdext.hash_multiset.cbegin"
  - "hash_multiset.cbegin"
  - "hash_set/stdext::hash_multiset::cbegin"
  - "hash_multiset::cbegin"
  - "stdext::hash_multiset::cbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cbegin method"
ms.assetid: 2d602f3a-a763-47cd-9486-acff0ce5eeab
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::cbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a const iterator that addresses the first element in the hash_multiset.  
  
## Syntax  
  
```  
  
const_iterator cbegin( ) const;  
  
```  
  
## Return Value  
 A const bidirectional iterator addressing the first element in the [hash_multiset](../vs140/hash_multiset-class.md) or the location succeeding an empty `hash_multiset`.  
  
## Remarks  
 With the return value of `cbegin`, the elements in the `hash_multiset` object cannot be modified.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_cbegin.cpp  
// compile with: /EHsc  
#include <hash_multiset>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset <int> hs1;  
   hash_multiset <int>::const_iterator hs1_cIter;  
  
   hs1.insert( 1 );  
   hs1.insert( 2 );  
   hs1.insert( 3 );  
  
   hs1_cIter = hs1.cbegin( );  
   cout << "The first element of hs1 is " << *hs1_cIter << endl;  
}  
```  
  
 **The first element of hs1 is 1**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)