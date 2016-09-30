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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The value used to move construct an element to be inserted into the [hash_map](../vs140/hash_map-class.md) unless the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> already contains that element (or, more generally, an element whose key is equivalently ordered).|  
  
## Return Value  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function returns a pair whose bool component returns true if an insertion was made and false if the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
 To access the iterator component of a pair <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and to dereference it, use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. To access the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> component of a pair <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and to dereference it, use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 The [value_type](../vs140/hash_map--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 Beginning with Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **After the emplace insertion, hm1 contains:**  
 **1 => a**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)