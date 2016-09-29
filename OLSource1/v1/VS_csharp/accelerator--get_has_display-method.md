---
title: "accelerator::get_has_display Method"
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
  - "amprt/Concurrency::accelerator::get_has_display"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_has_display method"
ms.assetid: 4e634e82-5459-4c6d-b34a-69fbe6ab101c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator::get_has_display Method
Returns a Boolean value that indicates whether the [accelerator](../VS_csharp/accelerator-class.md) can output to a display.  
  
## Syntax  
  
```  
bool get_has_display() const;  
```  
  
## Return Value  
 `true` if the `accelerator` can output to a display; otherwise, `false`.  
  
## Remarks  
 The return value of `get_has_display` indicates whether the accelerator can output to a display, but it does not necessarily indicate that a display is physically attached to the accelerator. For more information, see [has_display](../VS_csharp/accelerator--has_display-data-member.md).  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator::has_display Data Member](../VS_csharp/accelerator--has_display-data-member.md)   
 [accelerator Class](../VS_csharp/accelerator-class.md)