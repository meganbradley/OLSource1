---
title: "addressof"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 6243ddc8-486a-4961-8b0c-33e9dc2e0648
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# addressof
Gets the true address of an object.  
  
## Syntax  
  
```vb  
template<class T> T* addressof(  
    T& Val  
);  
```  
  
#### Parameters  
 `Val`  
 The object or function for which to obtain the true address.  
  
## Return Value  
 The actual address of the object or function referenced by `Val`, even if an overloaded `operator&()` exists.  
  
## Remarks  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [<memory\>](../vs140/-memory-.md)