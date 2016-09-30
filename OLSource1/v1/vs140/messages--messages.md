---
title: "messages::messages"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "messages"
  - "messages::messages"
  - "std::messages::messages"
  - "messages.messages"
  - "std.messages.messages"
  - "xlocmes/std::messages::messages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "messages class, constructor"
  - "messages method"
ms.assetid: 10ea80a7-86d7-42e9-9272-93126dfc46d4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# messages::messages
The message facet constructor function.  
  
## Syntax  
  
```  
explicit messages(  
    size_t _Refs = 0  
);  
protected: messages(  
    const char *_Locname,  
    size_t _Refs = 0  
);  
```  
  
#### Parameters  
 `_Refs`  
 Integer value used to specify the type of memory management for the object.  
  
 `_Locname`  
 The name of the locale.  
  
## Remarks  
 The possible values for the `_Refs` parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/facet-class.md)(`_Refs`).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [messages Class](../vs140/messages-class.md)