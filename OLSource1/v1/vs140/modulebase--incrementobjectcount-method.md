---
title: "ModuleBase::IncrementObjectCount Method"
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
  - implements/Microsoft::WRL::Details::ModuleBase::IncrementObjectCount
dev_langs: 
  - C++
helpviewer_keywords: 
  - IncrementObjectCount method
ms.assetid: 2d70b472-684c-4bb7-8bab-09505cfcaf28
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ModuleBase::IncrementObjectCount Method
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
virtual long IncrementObjectCount() = 0;  
```  
  
## Return Value  
 The count before the increment operation.  
  
## Remarks  
 When implemented, increments the number of objects tracked by the module.  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [ModuleBase Class](../vs140/modulebase-class.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)