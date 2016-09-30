---
title: "IDebugProgram2::EnumModules"
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
  - "IDebugProgram2::EnumModules"
helpviewer_keywords: 
  - "IDebugProgram2::EnumModules"
ms.assetid: 876ac9da-3b7c-4156-b79a-8f340e9fcea6
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgram2::EnumModules
Retrieves a list of the modules that this program has loaded and is executing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugModules2](../vs140/ienumdebugmodules2.md) object that contains a list of the modules.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 A module is a DLL or assembly and is typically listed in the **Modules** debug window.  
  
## See Also  
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IEnumDebugModules2](../vs140/ienumdebugmodules2.md)