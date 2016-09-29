---
title: "IDebugModOpt"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugModOpt interface"
ms.assetid: ebd525e3-d140-4071-9d8c-41871de4125e
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugModOpt
Represents a debug optional modifier.  
  
## Syntax  
  
```  
IDebugModOpt : IUnknown  
```  
  
## Notes for Callers  
 Obtained from an [IDebugField](../vs140/idebugfield.md) object that represents a class or method.  
  
## Methods  
 This interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugModOpt::GetModOpts](../vs140/idebugmodopt--getmodopts.md)|Retrieves a list of optional modifiers.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll