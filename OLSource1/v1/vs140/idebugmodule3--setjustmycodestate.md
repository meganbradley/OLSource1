---
title: "IDebugModule3::SetJustMyCodeState"
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
  - "IDebugModule3::SetJustMyCodeState"
helpviewer_keywords: 
  - "IDebugModule3::SetJustMyCodeState"
ms.assetid: 68f8166d-ef64-49ae-ad5e-79604f43bbd4
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugModule3::SetJustMyCodeState
Marks the module as being user code or not.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Nonzero (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) if the module should be considered user code, zero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) if it should not.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns error code.  
  
## See Also  
 [IDebugModule3](../vs140/idebugmodule3.md)