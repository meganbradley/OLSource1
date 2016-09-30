---
title: "IEnumDebugBoundBreakpoints2::Clone"
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
  - "IEnumDebugBoundBreakpoints2::Clone"
helpviewer_keywords: 
  - "IEnumDebugBoundBreakpoints2::Clone"
ms.assetid: c6ce01a2-7da3-46ec-9837-855042fa7244
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugBoundBreakpoints2::Clone
Returns a copy of the current enumeration as a separate object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns a copy of this enumeration as a separate object.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The copy of the enumeration has the same state as the original at the time this method is called. However, the copy's and the original's states are separate and can be changed individually.  
  
## See Also  
 [IEnumDebugBoundBreakpoints2](../vs140/ienumdebugboundbreakpoints2.md)