---
title: "IEnumDebugPrograms2::Reset"
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
  - "IEnumDebugPrograms2::Reset"
helpviewer_keywords: 
  - "IEnumDebugPrograms2::Reset"
ms.assetid: b289242b-24ea-4df3-a811-20b0c8a903d6
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugPrograms2::Reset
Resets the enumeration to the first element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to the [IEnumDebugPrograms2::Next](../vs140/ienumdebugprograms2--next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugPrograms2](../vs140/ienumdebugprograms2.md)