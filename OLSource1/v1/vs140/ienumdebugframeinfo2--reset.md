---
title: "IEnumDebugFrameInfo2::Reset"
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
  - "IEnumDebugFrameInfo2::Reset"
helpviewer_keywords: 
  - "IEnumDebugFrameInfo2::Reset"
ms.assetid: e149b559-f072-480b-9552-a452b147f3a8
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugFrameInfo2::Reset
Resets the enumeration to the first element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to the [IEnumDebugFrameInfo2::Next](../vs140/ienumdebugframeinfo2--next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugFrameInfo2](../vs140/ienumdebugframeinfo2.md)