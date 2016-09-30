---
title: "IEnumDebugFields::Reset"
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
  - "IEnumDebugFields::Reset"
helpviewer_keywords: 
  - "IEnumDebugFields::Reset method"
ms.assetid: 38ff61e4-0120-42e8-971a-16be6050b425
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugFields::Reset
This method resets the enumeration to the first element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 None  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to [IEnumDebugFields::Next](../vs140/ienumdebugfields--next.md) returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugFields](../vs140/ienumdebugfields.md)   
 [IEnumDebugFields::Next](../vs140/ienumdebugfields--next.md)