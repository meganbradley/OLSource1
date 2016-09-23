---
title: "IDebugTypeFieldBuilder2::CreateArrayOfType"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - IDebugTypeFieldBuilder2::CreateArrayOfType
  - CreateArrayOfType
ms.assetid: 85166ac9-0bff-49a0-b2fd-ca7f7a8eae4b
caps.latest.revision: 12
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugTypeFieldBuilder2::CreateArrayOfType
Creates an array of the specified type and size.  
  
## Syntax  
  
```cpp#  
HRESULT CreateArrayOfType (  
   IDebugField*  pTypeField,  
   DWORD         rank,  
   IDebugField** pArrayOfTypeField  
);  
```  
  
```c#  
int CreateArrayOfType (  
   IDebugField     pTypeField,  
   uint            rank,  
   out IDebugField pArrayOfTypeField  
);  
```  
  
#### Parameters  
 `pTypeField`  
 [in] Type of elements the array will hold.  
  
 `rank`  
 [in] Number of elements in the array.  
  
 `pArrayOfTypeField`  
 [out] Returns the [IDebugField](../vs140/idebugfield.md) objects that represent the new array.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugTypeFieldBuilder2](../vs140/idebugtypefieldbuilder2.md)