---
title: "IDebugDynamicFieldCOMPlus"
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
  - "IDebugDynamicFieldCOMPlus interface"
ms.assetid: c3a25f27-327a-4bdb-b026-27d436ddcd0c
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDynamicFieldCOMPlus
Represents a dynamic field for an [IDebugBinder](../vs140/idebugbinder.md) object.  
  
## Syntax  
  
```  
IDebugDynamicFieldCOMPlus : IDebugDynamicField  
```  
  
## Methods  
 In addition to the methods on the [IDebugDynamicField](../vs140/idebugdynamicfield.md) interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugDynamicFieldCOMPlus::GetTypeFromPrimitive](../vs140/idebugdynamicfieldcomplus--gettypefromprimitive.md)|Retrieves a type given its primitive type.|  
|[IDebugDynamicFieldCOMPlus::GetTypeFromTypeDef](../vs140/idebugdynamicfieldcomplus--gettypefromtypedef.md)|Retrieves a type given its token.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll