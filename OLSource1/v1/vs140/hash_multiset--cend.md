---
title: "hash_multiset::cend"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - hash_multiset.cend
  - stdext::hash_multiset::cend
  - hash_set/stdext::multiset::cend
  - hash_multiset::cend
  - stdext.hash_multiset.cend
dev_langs: 
  - C++
helpviewer_keywords: 
  - cend method
ms.assetid: a26c275f-f194-4ff1-b21e-f1f3e9a0c1cb
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_multiset::cend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a hash_multiset.  
  
## Syntax  
  
```  
  
const_iterator cend( ) const;  
  
```  
  
## Return Value  
 A const bidirectional iterator that addresses the location succeeding the last element in a [hash_multiset](../vs140/hash_multiset-class.md). If the `hash_multiset` is empty, then `hash_multiset::cend == hash_multiset::begin`.  
  
## Remarks  
 `cend` is used to test whether an iterator has reached the end of its `hash_multiset`. The value returned by `cend` should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_cend.cpp  
// compile with: /EHsc  
#include <hash_multiset>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset <int> hs1;  
   hash_multiset <int> :: const_iterator hs1_cIter;  
  
   hs1.insert( 1 );  
   hs1.insert( 2 );  
   hs1.insert( 3 );  
  
   hs1_cIter = hs1.cend( );  
   hs1_cIter--;  
   cout << "The last element of hs1 is " << *hs1_cIter << endl;  
}  
```  
  
 **The last element of hs1 is 3**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)