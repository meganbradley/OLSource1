---
title: "ClassFactory::Release Method"
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
  - "module/Microsoft::WRL::ClassFactory::Release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Release method"
ms.assetid: 49da2002-f9d6-4d7f-8a65-48c20b1bf99f
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ClassFactory::Release Method
Decrements the reference count for the current ClassFactory object.  
  
## Syntax  
  
```  
STDMETHOD_(  
   ULONG,  
   Release  
)();  
```  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that describes the failure.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [ClassFactory Class](../vs140/classfactory-class.md)