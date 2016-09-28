---
title: "hash_set::clear"
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
  - "hash_set::clear"
  - "hash_set/stdext::hash_set::clear"
  - "clear"
  - "std.hash_set.clear"
  - "std::hash_set::clear"
  - "hash_set.clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method"
ms.assetid: 469e13de-3076-42df-8ed1-5cfedff4ad57
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::clear
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Erases all the elements of a hash_set.  
  
## Syntax  
  
```  
  
void clear( );  
  
```  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_clear.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_set <int> hs1;  
  
   hs1.insert( 1 );  
   hs1.insert( 2 );  
  
   cout << "The size of the hash_set is initially " << hs1.size( )  
        << "." << endl;  
  
   hs1.clear( );  
   cout << "The size of the hash_set after clearing is "   
        << hs1.size( ) << "." << endl;  
}  
```  
  
 **The size of the hash_set is initially 2.**  
**The size of the hash_set after clearing is 0.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)