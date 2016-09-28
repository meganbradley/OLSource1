---
title: "IsBaseOfStrict::value Constant"
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
  - "internal/Microsoft::WRL::Details::IsBaseOfStrict::value"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value constant"
ms.assetid: 4a0cdab0-ba03-482b-babf-eeec519ba687
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IsBaseOfStrict::value Constant
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
static const bool value = __is_base_of(Base, Derived);  
```  
  
## Remarks  
 Indicates whether one type is the base of another.  
  
 `value` is `true` if type `Base` is a base class of the type `Derived`, otherwise it is `false`.  
  
## Requirements  
 **Header:** internal.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [IsBaseOfStrict Structure](../vs140/isbaseofstrict-structure.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)