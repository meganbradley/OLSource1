---
title: "IDebugFunctionObject2::CreateStringObjectWithLength"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "CreateStringObjectWithLength"
  - "IDebugFunctionObject2::CreateStringObjectWithLength"
ms.assetid: 1f43ec66-1615-4a4c-8b9d-e933f549f96d
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugFunctionObject2::CreateStringObjectWithLength
Creates a string object that has the specified length.  
  
## Syntax  
  
```cpp#  
HRESULT CreateStringObjectWithLength (  
   LPCOLESTR      pcstrString,  
   UINT           uiLength,  
   IDebugObject** ppObject  
);  
```  
  
```c#  
int CreateStringObjectWithLength (  
   string           pcstrString,  
   uint             uiLength,  
   out IDebugObject ppObject  
);  
```  
  
#### Parameters  
 `pcstrString`  
 [in] The string value for the string object.  
  
 `uiLength`  
 [in] The length of the string in bytes.  
  
 `ppObject`  
 [out] Returns an [IDebugObject](../vs140/idebugobject.md) object that represents the newly created string object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugFunctionObject2](../vs140/idebugfunctionobject2.md)