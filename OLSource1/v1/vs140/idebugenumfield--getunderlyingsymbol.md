---
title: "IDebugEnumField::GetUnderlyingSymbol"
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
  - "IDebugEnumField::GetUnderlyingSymbol"
helpviewer_keywords: 
  - "IDebugEnumField::GetUnderlyingSymbol method"
ms.assetid: c3b8a117-6708-4cfd-8ffc-5f007d706bc5
caps.latest.revision: 11
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEnumField::GetUnderlyingSymbol
This method returns an [IDebugField](../vs140/idebugfield.md) that represents the name of the enumeration.  
  
## Syntax  
  
```cpp#  
HRESULT GetUnderlyingSymbol(  
   IDebugField** ppField  
);  
```  
  
```c#  
int GetUnderlyingSymbol(  
   out IDebugField ppField  
);  
```  
  
#### Parameters  
 `ppField`  
 [out] Returns the [IDebugField](../vs140/idebugfield.md) describing the name of this enumeration.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The name of the enumeration also contains the type of the enumeration, which is bound to a memory location by using [IDebugBinder::Bind](../vs140/idebugbinder--bind.md).  
  
## See Also  
 [IDebugEnumField](../vs140/idebugenumfield.md)   
 [IDebugField](../vs140/idebugfield.md)   
 [IDebugBinder::Bind](../vs140/idebugbinder--bind.md)