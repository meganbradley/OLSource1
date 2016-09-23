---
title: "RuntimeClass::Release Method"
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
  - implements/Microsoft::WRL::RuntimeClass::Release
dev_langs: 
  - C++
helpviewer_keywords: 
  - Release method
ms.assetid: 0bd6f9e2-ad90-4de6-adef-a6286f458cb6
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# RuntimeClass::Release Method
Performs a COM Release operation on the current RuntimeClass object.  
  
## Syntax  
  
```  
STDMETHOD_(  
   ULONG,  
   Release  
)();  
```  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that indicates the error.  
  
## Remarks  
 If the reference count becomes zero, the RuntimeClass object is deleted.  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [RuntimeClass Class](../vs140/runtimeclass-class.md)