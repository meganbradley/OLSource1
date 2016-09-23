---
title: "CreatorMap::activationId Data Member"
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
  - module/Microsoft::WRL::Details::CreatorMap::activationId
dev_langs: 
  - C++
helpviewer_keywords: 
  - activationId data member
ms.assetid: 77518b76-6e6a-4b48-8e2e-a4c7c67769e0
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CreatorMap::activationId Data Member
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
union {   
   const IID* clsid;  
   const wchar_t* (*getRuntimeName)();  
} activationId;  
```  
  
## Parameters  
 `clsid`  
 An interface ID.  
  
 `getRuntimeName`  
 A function that retrieves the Windows runtime name of an object.  
  
## Remarks  
 Represents an object ID that is identified either by a classic COM class ID or a Windows runtime name.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [CreatorMap Structure](../vs140/creatormap-structure.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)