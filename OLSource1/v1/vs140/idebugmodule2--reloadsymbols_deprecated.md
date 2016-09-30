---
title: "IDebugModule2::ReloadSymbols_Deprecated"
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
  - "IDebugModule2::ReloadSymbols"
helpviewer_keywords: 
  - "IDebugModule2::ReloadSymbols method"
ms.assetid: 0f9f0133-7d58-4cd9-a6ca-1141e095749d
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugModule2::ReloadSymbols_Deprecated
OBSOLETE. DO NOT USE. Reloads the symbols for this module.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The path to the symbol store.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an informational message, such as a status or error message, that is displayed to the right of the module name in the Modules window.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code. A debug engine should always return <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method is no longer supported. Implement the [IDebugModule3::LoadSymbols](../vs140/idebugmodule3--loadsymbols.md) method instead.  
  
## See Also  
 [IDebugModule2](../vs140/idebugmodule2.md)   
 [IDebugModule3::LoadSymbols](../vs140/idebugmodule3--loadsymbols.md)