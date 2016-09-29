---
title: "accelerator::is_emulated Data Member"
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
  - "amprt/Concurrency::accelerator::is_emulated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_emulated data member"
ms.assetid: cc3d7621-6b74-4e23-aabc-60d71811aa77
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator::is_emulated Data Member
Gets a Boolean value that indicates whether the [accelerator](../VS_csharp/accelerator-class.md) is emulated.  
  
## Syntax  
  
```  
__declspec(property(get=get_is_emulated)) bool is_emulated;  
```  
  
## Remarks  
 The Direct3D reference and WARP accelerators, for example, are emulated.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator Class](../VS_csharp/accelerator-class.md)