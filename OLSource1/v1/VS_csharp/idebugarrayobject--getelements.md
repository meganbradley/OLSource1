---
title: "IDebugArrayObject::GetElements"
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
  - "IDebugArrayObject::GetElements"
helpviewer_keywords: 
  - "IDebugArrayObject::GetElements method"
ms.assetid: f6a6262f-5183-46ce-8a45-33ef46088b98
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugArrayObject::GetElements
Gets an enumerator of all elements of the array.  
  
## Syntax  
  
```cpp#  
HRESULT GetElements(   
   IEnumDebugObjects** ppEnum  
);  
```  
  
```c#  
int GetElements(  
   out IEnumDebugObjects ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns an [IEnumDebugObjects](../VS_csharp/ienumdebugobjects.md) object that allows enumerating over all elements.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 As an alternative, use the [IDebugArrayObject::GetCount](../VS_csharp/idebugarrayobject--getcount.md) and [IDebugArrayObject::GetElement](../VS_csharp/idebugarrayobject--getelement.md) methods to iterate through the elements.  
  
## See Also  
 [IDebugArrayObject](../VS_csharp/idebugarrayobject.md)