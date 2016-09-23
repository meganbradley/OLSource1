---
title: "ImplementsHelper::CastToUnknown Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - implements/Microsoft::WRL::Details::ImplementsHelper::CastToUnknown
dev_langs: 
  - C++
helpviewer_keywords: 
  - CastToUnknown method
ms.assetid: 5bcfcbaf-c75f-4d43-87b3-0d6838c838d9
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ImplementsHelper::CastToUnknown Method
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
IUnknown* CastToUnknown();  
```  
  
## Return Value  
 Pointer to the underlying IUnknown interface.  
  
## Remarks  
 Gets a pointer to the underlying IUnknown interface for the current Implements structure.  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [ImplementsHelper Structure](../vs140/implementshelper-structure.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)