---
title: "HANDLENullTraits::Close Method"
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
  - corewrappers/Microsoft::WRL::Wrappers::HandleTraits::HANDLENullTraits::Close
dev_langs: 
  - C++
helpviewer_keywords: 
  - Close method
ms.assetid: 6fb2fa0d-df20-45dc-856f-f78497f8bdf9
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# HANDLENullTraits::Close Method
Closes the specified handle.  
  
## Syntax  
  
```  
inline static bool Close(  
   _In_ Type h  
);  
```  
  
#### Parameters  
 `h`  
 The handle to close.  
  
## Return Value  
 **true** if handle `h` closed successfully; otherwise, **false**.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers::HandleTraits  
  
## See Also  
 [HANDLENullTraits Structure](../vs140/handlenulltraits-structure.md)