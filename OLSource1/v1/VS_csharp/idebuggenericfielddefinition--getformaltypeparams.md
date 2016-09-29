---
title: "IDebugGenericFieldDefinition::GetFormalTypeParams"
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
  - "GetFormalTypeParams"
  - "IDebugGenericFieldDefinition::GetFormalTypeParams"
ms.assetid: cadbd6a1-bc7c-4aff-8777-5396b7a23c3e
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugGenericFieldDefinition::GetFormalTypeParams
Retrieves the type parameters given the number of parameters.  
  
## Syntax  
  
```cpp#  
HRESULT GetFormalTypeParams(  
   ULONG32                   cParams,  
   IDebugGenericParamField** ppParams,  
   ULONG32*                  pcParams  
);  
```  
  
```c#  
int GetFormalTypeParams(  
   uint                          cParams,  
   out IDebugGenericParamField[] ppParams,  
   ref uint                      pcParams  
);  
```  
  
#### Parameters  
 `cParams`  
 [in] Number of parameters.  
  
 `ppParams`  
 [out] Array of type parameters.  
  
 `pcParams`  
 [in, out] Number of parameters in the `ppParams` array.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Return the type parameters in order from left to right. For example, Dictionary<K,V> returns IDebugFormalGenericParameters {K,V}.  
  
## See Also  
 [IDebugGenericFieldDefinition](../VS_csharp/idebuggenericfielddefinition.md)