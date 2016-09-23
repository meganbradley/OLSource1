---
title: "hash_set::cend"
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
  - hash_set/stdext::hash_set::cend
  - std.hash_set.cend
  - std::hash_set::cend
  - hash_set::cend
  - hash_set.cend
dev_langs: 
  - C++
helpviewer_keywords: 
  - cend method
  - cend method, hash_set class
ms.assetid: 1f72a57f-c921-4bee-8d3a-4d75dc00972d
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_set::cend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a hash_set.  
  
## Syntax  
  
```  
  
const_iterator cend( ) const;  
  
```  
  
## Return Value  
 A const bidirectional iterator that addresses the location succeeding the last element in a [hash_set](../vs140/hash_set-class.md). If the `hash_set` is empty, then `hash_set::cend == hash_set::begin`.  
  
## Remarks  
 `cend` is used to test whether an iterator has reached the end of its `hash_set`. The value returned by `cend` should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_cend.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_set <int> hs1;  
   hash_set <int> :: const_iterator hs1_cIter;  
  
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
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)