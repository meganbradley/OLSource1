---
title: "IDebugExceptionEvent2::GetExceptionDescription"
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
  - "IDebugExceptionEvent2::GetExceptionDescription"
helpviewer_keywords: 
  - "IDebugExceptionEvent2::GetExceptionDescription"
ms.assetid: d07d458f-5729-47e4-9b77-1bd59c61a75a
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExceptionEvent2::GetExceptionDescription
Gets a displayable description of the exception.  
  
## Syntax  
  
```cpp#  
HRESULT GetExceptionDescription(   
   BSTR* pbstrDescription  
);  
```  
  
```c#  
int GetExceptionDescription(   
   out string pbstrDescription  
);  
```  
  
#### Parameters  
 `pbstrDescription`  
 [out] Returns a displayable description of the exception.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The string returned from this method is typically the name of the exception and is shown in the **Output** window when the exception occurs.  
  
## See Also  
 [IDebugExceptionEvent2](../vs140/idebugexceptionevent2.md)