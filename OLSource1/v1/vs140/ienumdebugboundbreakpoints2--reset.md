---
title: "IEnumDebugBoundBreakpoints2::Reset"
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
  - "IEnumDebugBoundBreakpoints2::Reset"
helpviewer_keywords: 
  - "IEnumDebugBoundBreakpoints2::Reset"
ms.assetid: 0f0522a5-6a97-4c4e-859b-cc4476e6c527
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugBoundBreakpoints2::Reset
Resets the enumeration to the first element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to the [IEnumDebugBoundBreakpoints2::Next](../vs140/ienumdebugboundbreakpoints2--next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugBoundBreakpoints2](../vs140/ienumdebugboundbreakpoints2.md)