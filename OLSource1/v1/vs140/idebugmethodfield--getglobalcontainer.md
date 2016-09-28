---
title: "IDebugMethodField::GetGlobalContainer"
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
  - "IDebugMethodField::GetGlobalContainer"
helpviewer_keywords: 
  - "IDebugMethodField::GetGlobalContainer method"
ms.assetid: 041ac5aa-0b80-4310-b9ae-b88f8e7e0e5f
caps.latest.revision: 13
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMethodField::GetGlobalContainer
Gets the global container of the method.  
  
## Syntax  
  
```cpp#  
HRESULT GetGlobalContainer(  
   IDebugClassField** ppClass  
);  
```  
  
```c#  
int GetGlobalContainer(  
   out IDebugClassField ppClass  
);  
```  
  
#### Parameters  
 `ppClass`  
 [out] Returns an [IDebugClassField](../vs140/idebugclassfield.md) representing the module in which this method is defined.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 The returned [IDebugClassField](../vs140/idebugclassfield.md) object represents the entire module and is an artificial object, that is, the module itself does not have an actual class but it can be represented by an `IDebugClassField` object, allowing the various elements of the module to be enumerated and discovered.  
  
## See Also  
 [IDebugMethodField](../vs140/idebugmethodfield.md)   
 [IDebugClassField](../vs140/idebugclassfield.md)