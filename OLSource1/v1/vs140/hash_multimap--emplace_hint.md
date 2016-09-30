---
title: "hash_multimap::emplace_hint"
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
  - "std::hash_multimap::emplace_hint"
  - "hash_multimap::emplace_hint"
  - "std.hash_multimap.emplace_hint"
  - "hash_map/stdext::hash_multimap::emplace_hint"
  - "emplace_hint"
  - "hash_multimap.emplace_hint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace_hint method, hash_multimap class"
  - "emplace_hint method"
ms.assetid: f7ddae9e-b7db-430a-884e-c39acc2b4f4b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::emplace_hint
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Inserts an element constructed in place into a hash_multimap, with a placement hint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The value used to move construct an element to be inserted into the [hash_multimap](../vs140/hash_multimap-class.md) unless the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> already contains that element (or, more generally, an element whose key is equivalently ordered).|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|A hint regarding the place to start searching for the correct point of insertion.|  
  
## Return Value  
 The [emplace](../vs140/hash_multimap--emplace.md) member function returns an iterator that points to the position where the new element was inserted into the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The [value_type](../vs140/hash_multimap--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 Beginning with Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **After the emplace insertion, hm1 contains:**  
 **1 => a**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)