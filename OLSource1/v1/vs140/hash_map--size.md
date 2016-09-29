---
title: "hash_map::size"
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
  - "std::hash_map::size"
  - "size"
  - "hash_map.size"
  - "hash_map::size"
  - "hash_map/stdext::hash_map::size"
  - "std.hash_map.size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method"
ms.assetid: b347f846-e182-4a57-a91e-2d00956f964c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::size
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns the number of elements in the hash_map.  
  
## Syntax  
  
```  
  
size_type size( ) const;  
  
```  
  
## Return Value  
 The current length of the hash_map.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 The following example demonstrates the use of the hash_map::size member function.  
  
```  
// hash_map_size.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
    using namespace std;  
    using namespace stdext;  
    hash_map<int, int> hm1, hm2;  
    hash_map<int, int>::size_type i;  
    typedef pair<int, int> Int_Pair;  
  
    hm1.insert(Int_Pair(1, 1));  
    i = hm1.size();  
    cout << "The hash_map length is " << i << "." << endl;  
  
    hm1.insert(Int_Pair(2, 4));  
    i = hm1.size();  
    cout << "The hash_map length is now " << i << "." << endl;  
}  
```  
  
 **The hash_map length is 1.**  
**The hash_map length is now 2.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)