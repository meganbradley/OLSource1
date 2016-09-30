---
title: "shared_ptr::~shared_ptr"
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
  - "std::tr1::shared_ptr::~shared_ptr"
  - "tr1::shared_ptr::~shared_ptr"
  - "std.tr1.shared_ptr.~shared_ptr"
  - "~shared_ptr"
  - "tr1.shared_ptr.~shared_ptr"
  - "shared_ptr::~shared_ptr"
  - "memory/std::tr1::shared_ptr::~shared_ptr"
  - "shared_ptr.~shared_ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~shared_ptr method"
  - "shared_ptr destructor [TR1]"
ms.assetid: 9ef35950-1b32-427d-b234-7e1f99fb6b59
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::~shared_ptr
Destroys a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The destructor decrements the reference count for the resource currently owned by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If the reference count falls to zero, the resource is released.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\*sp1 == 5**  
**use count == 1**  
**\*sp2 == 5**  
**use count == 2**  
**use count == 1**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)