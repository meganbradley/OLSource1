---
title: "hash_map::emplace"
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
  - "std::hash_map::emplace"
  - "hash_map::emplace"
  - "hash_map.emplace"
  - "std.hash_map.emplace"
  - "hash_map/stdext::hash_map::emplace"
  - "emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method, hash_map class"
  - "emplace method"
ms.assetid: 423d3b35-3bd8-4b84-b031-a671ae5eda00
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::emplace
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Inserts an element constructed in place into a hash_map.  
  
## Syntax  
  
```  
template<class ValTy>  
    pair <iterator, bool> emplace(  
        ValTy&& _Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The value used to move construct an element to be inserted into the [hash_map](../vs140/hash_map-class.md) unless the `hash_map` already contains that element (or, more generally, an element whose key is equivalently ordered).|  
  
## Return Value  
 The `emplace` member function returns a pair whose bool component returns true if an insertion was made and false if the `hash_map` already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
 To access the iterator component of a pair `pr` returned by this member function, use `pr.first`, and to dereference it, use `*(pr.first)`. To access the `bool` component of a pair `pr` returned by this member function, use `pr.second`, and to dereference it, use `*(pr.second)`.  
  
## Remarks  
 The [value_type](../vs140/hash_map--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 Beginning with Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_emplace.cpp  
// compile with: /EHsc  
#include<hash_map>  
#include<iostream>  
#include <string>  
  
int main()  
{  
    using namespace std;  
    using namespace stdext;  
    hash_map<int, string> hm1;  
    typedef pair<int, string> is1(1, "a");  
  
    hm1.emplace(move(is1));  
    cout << "After the emplace insertion, hm1 contains:" << endl  
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
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)