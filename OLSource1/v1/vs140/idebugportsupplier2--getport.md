---
title: "IDebugPortSupplier2::GetPort"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugPortSupplier2::GetPort"
helpviewer_keywords: 
  - "IDebugPortSupplier2::GetPort"
ms.assetid: d55d5055-7386-4037-bf22-4c3e434a99ca
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortSupplier2::GetPort
Gets a port from a port supplier.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Globally unique identifier (GUID) of the port.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugPort2](../vs140/idebugport2.md) object that represents the port.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if no port exists with the given identifier.  
  
## See Also  
 [IDebugPortSupplier2](../vs140/idebugportsupplier2.md)   
 [IDebugPort2](../vs140/idebugport2.md)