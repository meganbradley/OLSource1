---
title: "EventTargetArray::Begin Method"
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
  - event/Microsoft::WRL::Details::EventTargetArray::Begin
dev_langs: 
  - C++
helpviewer_keywords: 
  - Begin method
ms.assetid: 1cc7fdfd-a2c4-4b28-93cf-1c82842294ba
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# EventTargetArray::Begin Method
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
ComPtr<IUnknown>* Begin();  
```  
  
## Return Value  
 The address of the first element in the internal array of event handlers.  
  
## Remarks  
 Gets the address of the first element in the internal array of event handlers.  
  
## Requirements  
 **Header:** event.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [EventTargetArray Class](../vs140/eventtargetarray-class.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)