---
title: "IDebugField::GetType"
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
  - "IDebugField::GetType"
helpviewer_keywords: 
  - "IDebugField::GetType method"
ms.assetid: b3cdec9f-ef7b-44d0-a775-d17ef7eae968
caps.latest.revision: 15
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugField::GetType
This method gets the type of field.  
  
## Syntax  
  
```cpp#  
HRESULT GetType(   
   IDebugField** ppType  
);  
```  
  
```c#  
int GetType(  
   out IDebugField ppType  
);  
```  
  
#### Parameters  
 `ppType`  
 [out] Returns the field type as another [IDebugField](../vs140/idebugfield.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugField](../vs140/idebugfield.md)