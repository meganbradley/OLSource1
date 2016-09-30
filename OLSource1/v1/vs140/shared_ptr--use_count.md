---
title: "shared_ptr::use_count"
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
  - "use_count"
  - "memory/std::tr1::shared_ptr::use_count"
  - "std.tr1.shared_ptr.use_count"
  - "shared_ptr.use_count"
  - "shared_ptr::use_count"
  - "std::tr1::shared_ptr::use_count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "use_count method [TR1]"
ms.assetid: 5250d0a0-de32-4b0c-a5fc-49a13500d4c8
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::use_count
Counts numbers of resource owners.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the number of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects that own the resource that is owned by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **sp1.use_count() == 1**  
**sp1.use_count() == 2**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)