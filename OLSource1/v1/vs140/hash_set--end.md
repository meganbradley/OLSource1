---
title: "hash_set::end"
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
  - hash_set.end
  - hash_set::end
  - hash_set/stdext::hash_set::end
  - std::hash_set::end
  - std.hash_set.end
dev_langs: 
  - C++
helpviewer_keywords: 
  - end method
ms.assetid: 3eb8f8cb-30a0-4a46-9c3f-4941a489f61e
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_set::end
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a hash_set.  
  
## Syntax  
  
```  
  
      const_iterator end( ) const;   
iterator end( );  
```  
  
## Return Value  
 A bidirectional iterator that addresses the location succeeding the last element in a hash_set. If the hash_set is empty, then hash_set::end == hash_set::begin.  
  
## Remarks  
 **end** is used to test whether an iterator has reached the end of its hash_set. The value returned by **end** should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_end.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_set <int> hs1;  
   hash_set <int> :: iterator hs1_Iter;  
   hash_set <int> :: const_iterator hs1_cIter;  
  
   hs1.insert( 1 );  
   hs1.insert( 2 );  
   hs1.insert( 3 );  
  
   hs1_Iter = hs1.end( );  
   hs1_Iter--;  
   cout << "The last element of hs1 is " << *hs1_Iter << endl;  
  
   hs1.erase( hs1_Iter );  
  
   // The following 3 lines would err because the iterator is const:  
   // hs1_cIter = hs1.end( );  
   // hs1_cIter--;  
   // hs1.erase( hs1_cIter );  
  
   hs1_cIter = hs1.end( );  
   hs1_cIter--;  
   cout << "The last element of hs1 is now " << *hs1_cIter << endl;  
}  
```  
  
 **The last element of hs1 is 3**  
**The last element of hs1 is now 2**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)