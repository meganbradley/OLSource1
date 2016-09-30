---
title: "hash_set::crbegin"
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
  - "hash_set/stdext::hash_set::crbegin"
  - "std::hash_set::crbegin"
  - "hash_set.crbegin"
  - "std.hash_set.crbegin"
  - "crbegin"
  - "hash_set::crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method, hash_set class"
  - "crbegin method"
ms.assetid: 4beb4d89-c434-4f98-83af-70563b5694d5
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::crbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns a const iterator addressing the first element in a reversed hash_set.  
  
## Syntax  
  
```  
  
const_reverse_iterator crbegin( ) const;  
  
```  
  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [hash_set](../vs140/hash_set-class.md) or addressing what had been the last element in the unreversed `hash_set`.  
  
## Remarks  
 `crbegin` is used with a reversed hash_set just as [begin](../vs140/hash_set--begin.md) is used with a hash_set.  
  
 With the return value of `crbegin`, the `hash_set` object cannot be modified.  
  
 `crbegin` can be used to iterate through a `hash_set` backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_crbegin.cpp  
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
  
   hs1_crIter = hs1.crbegin( );  
   cout << "The first element in the reversed hash_set is "  
        << *hs1_crIter << "." << endl;  
}  
```  
  
 **The first element in the reversed hash_set is 30.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)