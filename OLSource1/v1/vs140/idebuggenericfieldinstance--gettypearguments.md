---
title: "IDebugGenericFieldInstance::GetTypeArguments"
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
  - "GetTypeArguments"
  - "IDebugGenericFieldInstance::GetTypeArguments"
ms.assetid: 6e7e0f95-181a-4805-adb3-c2407de0ab93
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugGenericFieldInstance::GetTypeArguments
Retrieves the type parameter arguments for this instance.  
  
## Syntax  
  
```cpp#  
HRESULT GetTypeArguments(  
   ULONG32       cArgs,  
   IDebugField** ppArgs,  
   ULONG32*      pcArgs  
);  
```  
  
```c#  
int GetTypeArguments(  
   uint              cArgs,  
   out IDebugField[] ppArgs,  
   ref uint          pcArgs  
);  
```  
  
#### Parameters  
 `cArgs`  
 [in] Number of type parameters.  
  
 `ppArgs`  
 [out] Returns an array of type parameters.  
  
 `pcArgs`  
 [in, out] Number of members in the `ppArgs` array.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugGenericFieldInstance](../vs140/idebuggenericfieldinstance.md)