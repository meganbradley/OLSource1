---
title: "unique_ptr::get_deleter"
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
  - "unique_ptr.get_deleter"
  - "std::unique_ptr::get_deleter"
  - "get_deleter"
  - "unique_ptr::get_deleter"
  - "std.unique_ptr.get_deleter"
  - "memory/std::unique_ptr::get_deleter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_deleter method"
ms.assetid: e0fcb3c2-fd8e-44f1-be4b-c5310907570e
caps.latest.revision: 12
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unique_ptr::get_deleter
Returns a reference to `stored_deleter`.  
  
## Syntax  
  
```  
Del& get_deleter();  
const Del& get_deleter() const;  
```  
  
## Property Value/Return Value  
 Returns a reference to `stored_deleter`.  
  
## Remarks  
 The member function returns a reference to `stored_deleter`.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [unique_ptr](../vs140/unique_ptr-class.md)   
 [\<memory>](../vs140/-memory-.md)