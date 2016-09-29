---
title: "ModuleBase Class"
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
  - "implements/Microsoft::WRL::Details::ModuleBase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ModuleBase class"
ms.assetid: edce7591-6893-46f7-94a7-382827775548
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ModuleBase Class
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
class ModuleBase;  
```  
  
## Remarks  
 Represents the base class of the [Module](../VS_csharp/module-class.md) classes.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[ModuleBase::ModuleBase Constructor](../VS_csharp/modulebase--modulebase-constructor.md)|Initializes an instance of the Module class.|  
|[ModuleBase::~ModuleBase Destructor](../VS_csharp/modulebase--~modulebase-destructor.md)|Deinitializes the current instance of the Module class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ModuleBase::DecrementObjectCount Method](../VS_csharp/modulebase--decrementobjectcount-method.md)|When implemented, decrements the number of objects tracked by the module.|  
|[ModuleBase::IncrementObjectCount Method](../VS_csharp/modulebase--incrementobjectcount-method.md)|When implemented, increments the number of objects tracked by the module.|  
  
## Inheritance Hierarchy  
 `ModuleBase`  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL::Details Namespace](../VS_csharp/microsoft--wrl--details-namespace.md)