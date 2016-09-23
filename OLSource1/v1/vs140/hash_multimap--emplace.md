---
title: "hash_multimap::emplace"
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
  - hash_multimap.emplace
  - std.hash_multimap.emplace
  - std::hash_multimap::emplace
  - hash_multimap::emplace
  - emplace
  - hash_map/stdext::hash_multimap::emplace
dev_langs: 
  - C++
helpviewer_keywords: 
  - emplace method, hash_multimap class
  - emplace method
ms.assetid: b34caab9-019b-4fe5-b597-0c4aa1827b4a
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_multimap::emplace
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Inserts an element constructed in place into a hash_multimap.  
  
## Syntax  
  
```  
template<class ValTy>  
    iterator emplace(  
        ValTy&& _Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The value used to move construct an element to be inserted into the [hash_multimap](../vs140/hash_multimap-class.md).|  
  
## Return Value  
 The `emplace` member function returns an iterator that points to the position where the new element was inserted.  
  
## Remarks  
 The [value_type](../vs140/hash_multimap--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 Beginning with Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_emplace.cpp  
// compile with: /EHsc  
#include<hash_multimap>  
#include<iostream>  
#include <string>  
  
int main()  
{  
    using namespace std;  
    using namespace stdext;  
    hash_multimap<int, string> hm1;  
    typedef pair<int, string> is1(1, "a");  
  
    hm1.emplace(move(is1));  
    cout << "After the emplace, hm1 contains:" << endl  
      << " " << hm1.begin()->first  
      << " => " << hm1.begin()->second  
      << endl;  
}  
```  
  
 **After the emplace insertion, hm1 contains:**  
 **1 => a**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)