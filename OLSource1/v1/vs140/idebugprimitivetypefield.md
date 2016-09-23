---
title: "IDebugPrimitiveTypeField"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - IDebugPrimitiveTypeField interface
ms.assetid: 73a428fd-797e-4ceb-8392-ba16f1c5226b
caps.latest.revision: 10
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugPrimitiveTypeField
Represents a primitive type enumeration value from an [IDebugField](../vs140/idebugfield.md) interface.  
  
## Syntax  
  
```  
IDebugPrimitiveTypeField : IDebugField  
```  
  
## Methods  
 In addition to the methods on the [IDebugField](../vs140/idebugfield.md) interface, this interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugPrimitiveTypeField::GetPrimitiveType](../vs140/idebugprimitivetypefield--getprimitivetype.md)|Retrieves the primitive type associated with this field.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll