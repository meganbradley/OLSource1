---
title: "IsSame Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "internal/Microsoft::WRL::Details::IsSame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSame structure"
ms.assetid: 1eddbc3f-3cc5-434f-8495-e4477e1f868e
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IsSame Structure
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
template <  
   typename T1,  
   typename T2  
>  
struct IsSame;  
template <  
   typename T1  
>  
struct IsSame<T1, T1>;  
```  
  
#### Parameters  
 `T1`  
 A type.  
  
 `T2`  
 Another type.  
  
## Remarks  
 Tests whether one specified type is the same as another specified type.  
  
## Members  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[IsSame::value Constant](../vs140/issame--value-constant.md)|Indicates whether one type is the same as another.|  
  
## Inheritance Hierarchy  
 `IsSame`  
  
## Requirements  
 **Header:** internal.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)