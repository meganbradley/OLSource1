---
title: "IDebugReference2::Compare"
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
  - "IDebugReference2::Compare"
helpviewer_keywords: 
  - "IDebugReference2::Compare"
ms.assetid: 3361c495-2673-4b7c-82e3-dee74e1fa58d
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugReference2::Compare
Compares one reference to another. Reserved for future use.  
  
## Syntax  
  
```cpp#  
HRESULT Compare (   
   REFERENCE_COMPARE dwCompare,  
   IDebugReference2* pReference  
);  
```  
  
```c#  
int Compare (   
   enum_REFERENCE_COMPARE dwCompare,  
   IDebugReference2       pReference  
);  
```  
  
#### Parameters  
 `dwCompare`  
 [in] A value from the [REFERENCE_COMPARE](../VS_csharp/reference_compare.md) enumeration that specifies the comparison operation, for example, equal to, less than, or greater than.  
  
 `pReference`  
 [in] An [IDebugReference2](../VS_csharp/idebugreference2.md) object representing the reference to be compared to.  
  
## Return Value  
 Always returns `E_NOTIMPL`.  
  
## See Also  
 [IDebugReference2](../VS_csharp/idebugreference2.md)   
 [REFERENCE_COMPARE](../VS_csharp/reference_compare.md)