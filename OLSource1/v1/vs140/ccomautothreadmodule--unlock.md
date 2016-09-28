---
title: "CComAutoThreadModule::Unlock"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CComAutoThreadModule.Unlock"
  - "CComAutoThreadModule::Unlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unlock method"
ms.assetid: db54be00-c3c4-4739-97c3-8b21cd2779c7
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAutoThreadModule::Unlock
As of ATL 7.0, `CComAutoThreadModule` is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
```  
  
LONG Unlock( );  
  
```  
  
## Return Value  
 A value that may be useful for diagnostics or testing.  
  
## Remarks  
 Performs an atomic decrement on the lock count for the module and for the current thread. `CComAutoThreadModule` uses the module lock count to determine whether any clients are accessing the module. The lock count on the current thread is used for statistical purposes.  
  
 When the module lock count reaches zero, the module can be unloaded.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComAutoThreadModule Class](../vs140/ccomautothreadmodule-class.md)   
 [CComAutoThreadModule::Lock](../vs140/ccomautothreadmodule--lock.md)