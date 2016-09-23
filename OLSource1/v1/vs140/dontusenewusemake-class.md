---
title: "DontUseNewUseMake Class"
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
  - implements/Microsoft::WRL::Details::DontUseNewUseMake
dev_langs: 
  - C++
helpviewer_keywords: 
  - DontUseNewUseMake class
ms.assetid: 8b38d07b-fc14-4cea-afb9-4c1a7dde0093
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DontUseNewUseMake Class
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
class DontUseNewUseMake;  
```  
  
## Remarks  
 Prevents using operator `new` in RuntimeClass. Consequently, you must use the [Make function](../vs140/make-function.md) instead.  
  
## Members  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[DontUseNewUseMake::operator new Operator](../vs140/dontusenewusemake--operator-new-operator.md)|Overloads operator `new` and prevents it from being used in RuntimeClass.|  
  
## Inheritance Hierarchy  
 `DontUseNewUseMake`  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)   
 [Make Function](../vs140/make-function.md)