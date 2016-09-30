---
title: "declare_no_pointers"
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
  - "std.declare_no_pointers"
  - "memory/std::declare_no_pointers"
  - "declare_no_pointers"
  - "std::declare_no_pointers"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "declare_no_pointers function"
  - "declare_no_pointers"
ms.assetid: 46338586-4a35-422e-a77c-9bba0004f3cd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# declare_no_pointers
Informs a garbage collector that the characters in the memory block defined by a base address pointer and block size contains no traceable pointers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Address of first character that no longer contains traceable pointers.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Size of block that starts at <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that contains no traceable pointers.|  
  
## Remarks  
 The function informs any <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that the range of addresses <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> no longer contain traceable pointers. (Any pointers to allocated storage must not be dereferenced unless made <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.)  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [\<memory>](../vs140/-memory-.md)