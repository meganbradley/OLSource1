---
title: "IDebugMethodField::EnumAllLocals"
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
  - "IDebugMethodField::EnumAllLocals"
helpviewer_keywords: 
  - "IDebugMethodField::EnumAllLocals method"
ms.assetid: 0bc7cc13-2628-4bd8-8c06-4d2aa6755ea8
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMethodField::EnumAllLocals
Creates an enumerator for all local variables of the method, including those generated internally by a compiler.  
  
## Syntax  
  
```cpp#  
HRESULT EnumAllLocals(   
   IDebugAddress*     pAddress,  
   IEnumDebugFields** ppLocals  
);  
```  
  
```c#  
int EnumAllLocals(  
   IDebugAddress        pAddress,   
   out IEnumDebugFields ppLocals  
);  
```  
  
#### Parameters  
 `pAddress`  
 [in] An [IDebugAddress](../VS_csharp/idebugaddress.md) object representing a debug address within the method, pointing to a particular scope or context.  
  
 `ppLocals`  
 [out] Returns an [IEnumDebugFields](../VS_csharp/ienumdebugfields.md) object representing the list of all locals in the specified scope; otherwise, returns a null value indicating no locals.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no locals. Otherwise, returns an error code.  
  
## Remarks  
 Only the variables defined within the block that contains the given debug address are enumerated. This method includes any compiler-generated locals. If all that is needed are the locals explicitly defined in the source, call the [IDebugMethodField::EnumLocals](../VS_csharp/idebugmethodfield--enumlocals.md) method.  
  
 A method can contain multiple scoping contexts or blocks.  
  
## See Also  
 [IDebugMethodField](../VS_csharp/idebugmethodfield.md)   
 [IDebugAddress](../VS_csharp/idebugaddress.md)   
 [IEnumDebugFields](../VS_csharp/ienumdebugfields.md)   
 [IDebugMethodField::EnumLocals](../VS_csharp/idebugmethodfield--enumlocals.md)