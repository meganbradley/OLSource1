---
title: "direct3d_abort Function"
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
  - "amp/Concurrency::direct3d_abort"
dev_langs: 
  - "C++"
ms.assetid: efd40102-a2e8-4b84-b532-8dde5115e64b
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# direct3d_abort Function
Aborts the execution of a function with the `restrict(amp)` restriction clause. When the AMP runtime detects the call, it raises a [runtime_exception](../vs140/runtime_exception-class.md) exception with the error message "Reference Rasterizer: Shader abort instruction hit".  
  
## Syntax  
  
```  
void direct3d_abort() restrict(amp);  
```  
  
## Remarks  
 This function has the following restrictions:  
  
1.  The Debug configuration in Visual Studio is selected, i.e. the code is compiled with the _DEBUG preprocessor definition.  
  
2.  The [accelerator_view](assetId:///accelerator_view?qualifyHint=False&autoUpgrade=True) on which the kernel is invoked must be on an accelerator which supports the printf, errorf, and abort intrinsics. These are supported by the REF accelerator. For more information, see [Using accelerator and accelerator_view Objects](../vs140/using-accelerator-and-accelerator_view-objects.md).  
  
3.  The maximum number of parameters allowed is seven.  
  
4.  There is no automatic widening or narrowing type conversion.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ AMP)](../vs140/concurrency-namespace--c---amp-.md)