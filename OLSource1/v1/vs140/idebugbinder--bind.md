---
title: "IDebugBinder::Bind"
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
  - "IDebugBinder::Bind"
helpviewer_keywords: 
  - "IDebugBinder::Bind method"
ms.assetid: 15a11ad7-0fcc-4e80-ae34-8a7dd7bae3c3
caps.latest.revision: 16
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder::Bind
This method gets the memory context or object that contains the symbol's current value.  
  
## Syntax  
  
```cpp#  
HRESULT Bind(   
   IDebugObject*  pContainer,  
   IDebugField*   pField,  
   IDebugObject** ppObject  
);  
```  
  
```c#  
int Bind(  
   IDebugObject     pContainer,  
   IDebugField      pField,  
   out IDebugObject ppObject  
);  
```  
  
#### Parameters  
 `pContainer`  
 [in] The [IDebugObject](../vs140/idebugobject.md) that contains the child referenced by `pField`.  
  
 `pField`  
 [in] The [IDebugField](../vs140/idebugfield.md) that represents the symbol.  
  
 `ppObject`  
 [out] Returns the `IDebugObject` that represents the instance of the symbol.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugBinder](../vs140/idebugbinder.md)   
 [IDebugObject](../vs140/idebugobject.md)   
 [IDebugField](../vs140/idebugfield.md)