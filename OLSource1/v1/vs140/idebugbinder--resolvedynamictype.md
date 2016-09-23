---
title: "IDebugBinder::ResolveDynamicType"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IDebugBinder::ResolveDynamicType
helpviewer_keywords: 
  - IDebugBinder::ResolveDynamicType method
ms.assetid: 2c36ef92-5b44-4cfd-988e-54a2e5a6710c
caps.latest.revision: 12
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugBinder::ResolveDynamicType
This method returns the exact type of a variable.  
  
## Syntax  
  
```cpp#  
HRESULT ResolveDynamicType (  
   IDebugDynamicField *pDynamic,  
   IDebugField       **ppResolved  
);  
```  
  
```c#  
int ResolveDynamicType(  
   IDebugDynamicField pDynamic,   
   out IDebugField    ppResolved  
);  
```  
  
#### Parameters  
 `pDynamic`  
 [in] An [IDebugDynamicField](../vs140/idebugdynamicfield.md) representing a type of a variable.  
  
 `ppResolved`  
 [out] Returns an [IDebugField](../vs140/idebugfield.md) giving specific information about the variable's type.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugBinder](../vs140/idebugbinder.md)   
 [IDebugField](../vs140/idebugfield.md)   
 [IDebugDynamicField](../vs140/idebugdynamicfield.md)