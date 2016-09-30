---
title: "accelerator_view::wait Method"
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
  - "amprt/Concurrency::accelerator_view::wait"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait method"
ms.assetid: c34ac1b3-e5bf-4a4e-86a3-420d23f0e2e9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator_view::wait Method
Waits for all commands submitted to the  [accelerator_view](../vs140/accelerator_view-class.md) object to finish.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the  [queuing_mode](../vs140/queuing_mode-enumeration.md) is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, this method returns immediately without blocking.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator_view Class](../vs140/accelerator_view-class.md)