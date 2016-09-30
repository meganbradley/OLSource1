---
title: "hash_map::emplace_hint"
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
  - "std.hash_map.emplace_hint"
  - "hash_map.emplace_hint"
  - "hash_map/stdext::hash_map::emplace_hint"
  - "std::hash_map::emplace_hint"
  - "hash_map::emplace_hint"
  - "emplace_hint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace_hint method, hash_map class"
  - "emplace_hint method"
ms.assetid: e2118b5e-4dab-43d4-a4bf-634fdd608935
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::emplace_hint
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Inserts an element constructed in place into a hash_map, with a placement hint.  
  
## Syntax  
  
```  
template<class ValTy>  
    iterator emplace_hint(  
        const_iterator _Where,  
        ValTy&& _Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The value used to move construct an element to be inserted into the [hash_map](../vs140/hash_map-class.md) unless the `hash_map` already contains that element (or, more generally, an element whose key is equivalently ordered).|  
|`_Where`|A hint regarding the place to start searching for the correct point of insertion.|  
  
## Return Value  
 The [emplace](../vs140/hash_multimap--emplace.md) member function returns an iterator that points to the position where the new element was inserted into the `hash_map`, or where the existing element with equivalent ordering is located.  
  
## Remarks  
 The [value_type](../vs140/hash_map--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows `_Where`.  
  
 Beginning with Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_emplace_hint.cpp  
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
  
    hm1.emplace(hm1.begin(), move(is1));  
    cout << "After the emplace, hm1 contains:" << endl  
      << " " << hm1.begin()->first  
      << " => " << hm1.begin()->second  
      << endl;  
}  
```  
  
 **After the emplace insertion, hm1 contains:**  
 **1 => a**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)