---
title: "ComPtrRef::ComPtrRef Constructor"
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
  - client/Microsoft::WRL::Details::ComPtrRef::ComPtrRef
dev_langs: 
  - C++
helpviewer_keywords: 
  - ComPtrRef, constructor
ms.assetid: ce2d2533-fef6-4b2d-b088-6f3db01df5a5
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ComPtrRef::ComPtrRef Constructor
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
ComPtrRef(  
   _In_opt_ T* ptr  
);  
```  
  
#### Parameters  
 `ptr`  
 The underlying value of another ComPtrRef object.  
  
## Remarks  
 Initializes a new instance of the ComPtrRef class from the specified pointer to another ComPtrRef object.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [ComPtrRef Class](../vs140/comptrref-class.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)