---
title: "IDebugArrayField::GetNumberOfElements"
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
  - "IDebugArrayField::GetNumberOfElements"
helpviewer_keywords: 
  - "IDebugArrayField::GetNumberOfElements method"
ms.assetid: a1961ef3-d69d-4022-b8c9-b9cfb9811345
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugArrayField::GetNumberOfElements
Gets the number of elements in the array.  
  
## Syntax  
  
```cpp#  
HRESULT GetNumberOfElements(   
   DWORD* pdwNumElements  
);  
```  
  
```c#  
int GetNumberOfElements(  
   out uint pdwNumElements  
);  
```  
  
#### Parameters  
 `pdwNumElements`  
 [out] Returns the number of elements in the array.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 The value returned is the total number of elements in the array, regardless of the number of dimensions.  
  
## See Also  
 [IDebugArrayField](../vs140/idebugarrayfield.md)