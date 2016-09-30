---
title: "hash_set::operator="
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
  - "stdext::hash_set::operator="
  - "="
  - "operator="
  - "hash_set::operator="
  - "hash_set/stdext::hash_set::operator="
  - "hash_set.operator="
  - "std.hash_set.operator="
  - "stdext.hash_set.operator="
  - "std::hash_set::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific standard C++ objects"
  - "operator =, hash_set objects"
  - "operator=, hash_set objects"
ms.assetid: e1bfe53e-37f4-499f-8dce-cd16ff537504
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::operator=
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Replaces the elements of the hash_set with a copy of another hash_set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The [hash_set](../vs140/hash_set-class.md) being copied into the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
  
## Remarks  
 After erasing any existing elements in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> either copies or moves the contents of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** std  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)