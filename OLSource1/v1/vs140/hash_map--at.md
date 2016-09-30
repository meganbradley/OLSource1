---
title: "hash_map::at"
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
  - "stdext.hash_map.at"
  - "at"
  - "hash_map/stdext::hash_map::at"
  - "stdext::hash_map::at"
  - "std::hash_map::at"
  - "hash_map.at"
  - "std.hash_map.at"
  - "hash_map::at"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "at method"
  - "at method, hash_map class"
ms.assetid: 56881eba-3936-4072-80a7-3f03c734c376
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::at
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Finds an element in a hash_map with a specified key value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The key value of the element that is to be found.|  
  
## Return Value  
 A reference to the data value of the element found.  
  
## Remarks  
 If the argument key value is not found, then the function throws an object of class [out_of_range](../vs140/out_of_range-class.md).  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)