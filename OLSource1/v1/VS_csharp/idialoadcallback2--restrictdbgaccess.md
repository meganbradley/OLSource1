---
title: "IDiaLoadCallback2::RestrictDBGAccess"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaLoadCallback2::RestrictDBGAccess method"
ms.assetid: 63b67a93-2910-4fff-aa70-6b2eaa08e5c8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaLoadCallback2::RestrictDBGAccess
Determines if looking for debug information is allowed from .dbg files.  
  
## Syntax  
  
```cpp#  
HRESULT RestrictDBGAccess();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Any return value other than `S_OK` to prevent looking for debug information from .dbg files.  
  
## See Also  
 [IDiaLoadCallback2](../VS_csharp/idialoadcallback2.md)