---
title: "IDebugReference2::SetReferenceType"
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
  - IDebugReference2::SetReferenceType
helpviewer_keywords: 
  - IDebugReference2::SetReferenceType
ms.assetid: 5854a172-ea82-481c-97d9-c7fc16923d44
caps.latest.revision: 15
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugReference2::SetReferenceType
Sets the reference type. Reserved for future use.  
  
## Syntax  
  
```cpp#  
HRESULT SetReferenceType (   
   REFERENCE_TYPE dwRefType  
);  
```  
  
```c#  
int SetReferenceType (   
   enum_REFERENCE_TYPE dwRefType  
);  
```  
  
#### Parameters  
 `dwRefType`  
 [in] A value from the [REFERENCE_TYPE](../vs140/reference_type.md) enumeration that specifies the reference type.  
  
## Return Value  
 Always returns `E_NOTIMPL`.  
  
## See Also  
 [IDebugReference2](../vs140/idebugreference2.md)   
 [REFERENCE_TYPE](../vs140/reference_type.md)