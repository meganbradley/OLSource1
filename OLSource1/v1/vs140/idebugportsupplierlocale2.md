---
title: "IDebugPortSupplierLocale2"
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
  - "IDebugPortSupplierLocale2 interface"
ms.assetid: 910e7220-da2a-4339-9fff-9fb1bad3c28c
caps.latest.revision: 8
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortSupplierLocale2
Provides locale support for a port supplier.  
  
## Syntax  
  
```  
IDebugPortSupplierLocale2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface to set the locale.  
  
## Methods  
 The following table shows the methods of **IDebugPortSupplierLocale2**.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugPortSupplierLocale2::SetLocale](../vs140/idebugportsupplierlocale2--setlocale.md)|Sets the locale for the port supplier.|  
  
## Requirements  
 Header: Portpriv.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugPortSupplier2](../vs140/idebugportsupplier2.md)   
 [IDebugPortSupplier3](../vs140/idebugportsupplier3.md)