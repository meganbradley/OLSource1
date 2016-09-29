---
title: "hash_set::empty"
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
  - "hash_set/stdext::hash_set::empty"
  - "hash_set.empty"
  - "empty"
  - "hash_set::empty"
  - "std::hash_set::empty"
  - "std.hash_set.empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method"
ms.assetid: 0145f49a-aebe-4a78-ac2a-900ee13d2d3e
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::empty
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Tests if a hash_set is empty.  
  
## Syntax  
  
```  
  
bool empty( ) const;  
  
```  
  
## Return Value  
 **true** if the hash_set is empty; **false** if the hash_set is nonempty.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_empty.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_set <int> hs1, hs2;  
   hs1.insert ( 1 );  
  
   if ( hs1.empty( ) )  
      cout << "The hash_set hs1 is empty." << endl;  
   else  
      cout << "The hash_set hs1 is not empty." << endl;  
  
   if ( hs2.empty( ) )  
      cout << "The hash_set hs2 is empty." << endl;  
   else  
      cout << "The hash_set hs2 is not empty." << endl;  
}  
```  
  
 **The hash_set hs1 is not empty.**  
**The hash_set hs2 is empty.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)