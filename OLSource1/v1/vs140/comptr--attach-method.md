---
title: "ComPtr::Attach Method"
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
  - client/Microsoft::WRL::ComPtr::Attach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Attach method
ms.assetid: 5b911f2d-9830-4dc7-b9e3-527abd55d2c8
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ComPtr::Attach Method
Associates this ComPtr with the interface type specified by the current template type parameter.  
  
## Syntax  
  
```  
void Attach(  
   _In_opt_ InterfaceType* other  
);  
```  
  
#### Parameters  
 `other`  
 An interface type.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [ComPtr Class](../vs140/comptr-class.md)