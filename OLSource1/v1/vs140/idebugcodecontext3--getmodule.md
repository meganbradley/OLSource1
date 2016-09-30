---
title: "IDebugCodeContext3::GetModule"
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
  - "IDebugCodeContext3::GetModule"
ms.assetid: 8e4317b8-8255-486c-a896-a68ed94f8aa1
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCodeContext3::GetModule
Retrieves a reference to the interface of the debug module.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Reference to the debug module interface.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugCodeContext** object that exposes the [IDebugBeforeSymbolSearchEvent2](../vs140/idebugbeforesymbolsearchevent2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugCodeContext3](../vs140/idebugcodecontext3.md)