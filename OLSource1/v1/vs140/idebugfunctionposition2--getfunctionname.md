---
title: "IDebugFunctionPosition2::GetFunctionName"
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
  - "IDebugFunctionPosition2::GetFunctionName"
helpviewer_keywords: 
  - "IDebugFunctionPosition2::GetFunctionName"
ms.assetid: eb7a348e-a7f5-4f25-be68-80482d5482a8
caps.latest.revision: 17
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugFunctionPosition2::GetFunctionName
Gets the name of the function to which this position points.  
  
## Syntax  
  
```cpp#  
HRESULT GetFunctionName(   
   BSTR* pbstrFunctionName  
);  
```  
  
```c#  
int GetFunctionName(  
   out string pbstrFunctionName  
);  
```  
  
#### Parameters  
 `pbstrFunctionName`  
 [out] Returns the name of the function.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugFunctionPosition2](../vs140/idebugfunctionposition2.md)