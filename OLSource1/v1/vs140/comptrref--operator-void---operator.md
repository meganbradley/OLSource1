---
title: "ComPtrRef::operator void** Operator"
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
  - "client/Microsoft::WRL::Details::ComPtrRef::operator void**"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator void** operator"
ms.assetid: f020045c-9de4-4392-8783-73f0fc0761c6
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComPtrRef::operator void** Operator
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
operator void**() const;  
```  
  
## Remarks  
 Deletes the current ComPtrRef object, casts the pointer to the interface that was represented by the ComPtrRef object as a pointer-to-pointer-to `void`, and then returns the cast pointer.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [ComPtrRef Class](../vs140/comptrref-class.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)