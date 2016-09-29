---
title: "hash_set::emplace"
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
  - "std::hash_set::emplace"
  - "hash_set::emplace"
  - "hash_set.emplace"
  - "hash_set/stdext::hash_set::emplace"
  - "std.hash_set.emplace"
  - "emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
  - "emplace method, hash_set class"
ms.assetid: 4b4d059b-622d-481c-9b1a-991201f8e01b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::emplace
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Inserts an element constructed in place into a hash_set.  
  
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
|`_Val`|The value of an element to be inserted into the [hash_set](../vs140/hash_set-class.md) unless the `hash_set` already contains that element or, more generally, an element whose key is equivalently ordered.|  
  
## Return Value  
 The `emplace` member function returns a pair whose `bool` component returns `true` if an insertion was make and `false` if the `hash_set` already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_emplace.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
#include <string>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_set<string> hs3;  
   string str1("a");  
  
   hs3.emplace(move(str1));  
   cout << "After the emplace insertion, hs3 contains "  
      << *hs3.begin() << "." << endl;  
}  
```  
  
 **After the emplace insertion, hs3 contains a.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)