---
title: "hash_multiset::emplace"
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
  - "hash_multiset::emplace"
  - "hash_multiset.emplace"
  - "hash_set/stdext::hash_multiset::emplace"
  - "stdext::hash_multiset::emplace"
  - "stdext.hash_multiset.emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
ms.assetid: 6cb3b0bb-ebd7-461a-9e43-cd0cebf3dcd1
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::emplace
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Inserts an element constructed in place into a hash_multiset.  
  
## Syntax  
  
```  
template<class ValTy>  
    iterator insert(  
        ValTy&& _Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The value of an element to be inserted into the [hash_multiset](../vs140/hash_multiset-class.md) unless the `hash_multiset` already contains that element or, more generally, an element whose key is equivalently ordered.|  
  
## Return Value  
 The `emplace` member function returns an iterator that points to the position where the new element was inserted.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_emplace.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
#include <string>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset<string> hms3;  
   string str1("a");  
  
   hms3.emplace(move(str1));  
   cout << "After the emplace insertion, hms3 contains "  
      << *hms3.begin() << "." << endl;  
}  
```  
  
 **After the emplace insertion, hms3 contains a.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)