---
title: "IEnumDebugErrorBreakpoints2::Reset"
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
  - "IEnumDebugErrorBreakpoints2::Reset"
helpviewer_keywords: 
  - "IEnumDebugErrorBreakpoints2::Reset"
ms.assetid: d5b04bba-a8b9-4141-94fb-250c77f0534c
caps.latest.revision: 13
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugErrorBreakpoints2::Reset
Resets the enumeration to the first element.  
  
## Syntax  
  
```cpp#  
HRESULT Reset(  
   void  
);  
```  
  
```c#  
int Reset();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to the [IEnumDebugErrorBreakpoints2::Next](../vs140/ienumdebugerrorbreakpoints2--next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugErrorBreakpoints2](../vs140/ienumdebugerrorbreakpoints2.md)