---
title: "auto_gcroot Class"
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
  - "msclr::auto_gcroot"
  - "msclr.auto_gcroot"
  - "auto_gcroot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_gcroot"
ms.assetid: b5790912-265d-463e-a486-47302e91042a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_gcroot Class
Automatic resource management (like [std::auto_ptr](../vs140/auto_ptr-class.md)) which can be used to embed a virtual handle into a native type.  
  
## Syntax  
  
```  
template<typename _element_type>  
class auto_gcroot;  
```  
  
#### Parameters  
 `_element_type`  
 The managed type to be embedded.  
  
## Requirements  
 **Header file** <msclr\auto_gcroot.h>  
  
 **Namespace** msclr  
  
## See Also  
 [<msclr\auto_gcroot.h> Header](../vs140/auto_gcroot.md)   
 [auto_gcroot Members](../vs140/auto_gcroot-members.md)   
 [Handles in Native Types](../vs140/how-to--declare-handles-in-native-types.md)   
 [auto_handle Class](../vs140/auto_handle-class.md)