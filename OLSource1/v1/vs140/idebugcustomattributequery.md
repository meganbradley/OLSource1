---
title: "IDebugCustomAttributeQuery"
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
  - "IDebugCustomAttributeQuery interface"
ms.assetid: b804b619-70eb-4c38-80d9-c8b32b65ed3e
caps.latest.revision: 11
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCustomAttributeQuery
Represents a query for custom attributes on a method or type.  
  
## Syntax  
  
```  
IDebugCustomAttributeQuery : IUnknown  
```  
  
## Methods  
 This interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugCustomAttributeQuery::GetCustomAttributeByName](../vs140/idebugcustomattributequery--getcustomattributebyname.md)|Retrieves a custom attribute given its name.|  
|[IDebugCustomAttributeQuery::IsCustomAttributeDefined](../vs140/idebugcustomattributequery--iscustomattributedefined.md)|Determines in the specified custom attribute is defined.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll