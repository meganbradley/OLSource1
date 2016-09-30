---
title: "hash_map::operator="
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
  - "="
  - "operator="
  - "hash_map.operator="
  - "std::hash_map::operator="
  - "hash_map::operator="
  - "std.hash_map.operator="
  - "stdext.hash_map.operator="
  - "hash_map/stdext::hash_map::operator="
  - "stdext::hash_map::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator =, hash_map objects"
  - "= operator, with specific standard C++ objects"
  - "operator=, hash_map objects"
ms.assetid: 942381f6-f801-49d0-ba82-0ef35a956ab2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::operator=
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Replaces the elements of the hash_map with a copy of another hash_map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The [hash_map Class](../vs140/hash_map-class.md) being copied into the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
  
## Remarks  
 After erasing any existing elements in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> either copies or moves the contents of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** std  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)