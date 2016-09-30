---
title: "IDebugModuleLoadEvent2::GetModule"
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
  - "IDebugModuleLoadEvent2::GetModule"
helpviewer_keywords: 
  - "IDebugModuleLoadEvent2::GetModule"
ms.assetid: c86482bb-9ce5-4e63-bbe0-969b50169424
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugModuleLoadEvent2::GetModule
Gets the module that is being loaded or unloaded.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugModule2](../vs140/idebugmodule2.md) object that represents the module which is loading or unloading.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in, out] Returns an optional message describing this event. If this parameter is a null value, no message is requested.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] Nonzero (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) if the module is loading and zero (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) if the module is unloading. If this parameter is a null value, no status is requested.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugModuleLoadEvent2](../vs140/idebugmoduleloadevent2.md)   
 [IDebugModule2](../vs140/idebugmodule2.md)