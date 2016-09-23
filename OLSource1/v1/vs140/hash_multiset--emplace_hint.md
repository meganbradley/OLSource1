---
title: "hash_multiset::emplace_hint"
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
  - stdext::hash_multiset::emplace_hint
  - hash_set/stdext::hash_multiset::emplace_hint
  - hash_multiset.emplace_hint
  - stdext.hash_multiset.emplace_hint
  - hash_multiset::emplace_hint
dev_langs: 
  - C++
helpviewer_keywords: 
  - emplace_hint method
ms.assetid: a07453d6-f318-49bc-9696-12ee825717f9
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_multiset::emplace_hint
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Inserts an element constructed in place into a hash_multiset, with a placement hint.  
  
## Syntax  
  
```  
template<class ValTy>  
    iterator insert(  
        const_iterator _Where,  
        ValTy&& _Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The value of an element to be inserted into the [hash_multiset](../vs140/hash_multiset-class.md) unless the `hash_multiset` already contains that element or, more generally, an element whose key is equivalently ordered.|  
|`_Where`|The place to start searching for the correct point of insertion. (Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows `_Where`.)|  
  
## Return Value  
 The [emplace](../vs140/hash_multiset--emplace.md) member function returns an iterator that points to the position where the new element was inserted into the `hash_multiset`.  
  
## Remarks  
 Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows `_Where`.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_emplace_hint.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
#include <string>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset<string> hms1;  
   string str1("a");  
  
   hms1.insert(hms1.begin(), move(str1));  
   cout << "After the emplace insertion, hms1 contains "  
      << *hms1.begin() << "." << endl;  
}  
```  
  
 **After the emplace insertion, hms1 contains a.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)