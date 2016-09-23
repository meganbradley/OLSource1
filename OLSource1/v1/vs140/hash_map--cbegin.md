---
title: "hash_map::cbegin"
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
  - hash_map.cbegin
  - std.hash_map.cbegin
  - hash_map::cbegin
  - hash_map/stdext::hash_map::cbegin
  - std::hash_map::cbegin
dev_langs: 
  - C++
helpviewer_keywords: 
  - cbegin method
  - cbegin method, hash_map class
ms.assetid: f01d6307-309f-4188-b9e8-f9aea7dfbd19
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_map::cbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a const iterator addressing the first element in the hash_map.  
  
## Syntax  
  
```  
  
const_iterator cbegin( ) const;  
  
```  
  
## Return Value  
 A const bidirectional iterator addressing the first element in the [hash_map](../vs140/hash_map-class.md) or the location succeeding an empty `hash_map`.  
  
## Remark  
 With the return value of `cbegin`, the `hash_map` object cannot be modified.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_cbegin.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_map <int, int> hm1;  
  
   hash_map <int, int> :: const_iterator hm1_cIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 2, 4 ) );  
  
   hm1_cIter = hm1.cbegin ( );  
   cout << "The first element of hm1 is "   
        << hm1_cIter -> first << "." << endl;  
   }  
```  
  
 **The first element of hm1 is 2.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)