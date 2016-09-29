---
title: "IDebugAlias::GetICorDebugValue"
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
  - "IDebugAlias::GetICorDebugValue"
helpviewer_keywords: 
  - "IDebugAlias::GetICorDebugValue method"
ms.assetid: b9eb39ee-84af-4ace-9cfe-236b3d48aff5
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugAlias::GetICorDebugValue
Retrieves a managed code interface that represents the value associated with this alias.  
  
## Syntax  
  
```cpp  
HRESULT GetICorDebugValue(  
   IUnknown** ppUnk  
);  
```  
  
```c#  
int GetICorDebugValue(  
   out object ppUnk  
);  
```  
  
#### Parameters  
 `ppUnk`  
 [out] `IUnknown` interface that represents the value associated with this alias. This interface can be queried for the `ICorDebugValue` interface.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 This method applies only to managed values (the `ICorDebugValue` is an interface available in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] and is defined in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] SDK in the cordebug.idl file).  
  
## See Also  
 [IDebugAlias](../vs140/idebugalias.md)