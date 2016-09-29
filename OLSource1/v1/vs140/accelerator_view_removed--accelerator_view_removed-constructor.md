---
title: "accelerator_view_removed::accelerator_view_removed Constructor"
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
  - "amprt/Concurrency::accelerator_view_removed::accelerator_view_removed"
dev_langs: 
  - "C++"
ms.assetid: 1f4d541e-da9c-4fbd-be32-758b91ef0648
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator_view_removed::accelerator_view_removed Constructor
Initializes a new instance of the [accelerator_view_removed](../vs140/accelerator_view_removed-class.md) class.  
  
## Syntax  
  
```  
explicit accelerator_view_removed(  
   const char * _Message,  
   HRESULT _View_removed_reason  
) throw();  
  
explicit accelerator_view_removed(  
   HRESULT _View_removed_reason  
) throw();  
```  
  
#### Parameters  
 `_Message`  
 A description of the error.  
  
 `_View_removed_reason`  
 An HRESULT error code indicating the cause of removal of the `accelerator_view` object.  
  
## Return Value  
 A new instance of the [accelerator_view_removed](../vs140/accelerator_view_removed-class.md) class.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator_view_removed Class](../vs140/accelerator_view_removed-class.md)