---
title: "InvokeHelper::callback_ Data Member"
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
  - "event/Microsoft::WRL::Details::InvokeHelper::callback_"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "callback_ data member"
ms.assetid: 6f0cbf6d-0448-46f8-ba71-bd6fd8702e3a
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# InvokeHelper::callback_ Data Member
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
TCallback callback_;  
```  
  
## Remarks  
 Represents the event handler to call when an event occurs.  
  
 The `TCallback` template parameter specifies the type of the event handler.  
  
## Requirements  
 **Header:** event.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [InvokeHelper Structure](../vs140/invokehelper-structure.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)