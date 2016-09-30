---
title: "float_denorm_style"
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
  - "float_denorm_style"
  - "std::float_denorm_style"
  - "std.float_denorm_style"
  - "limits/std::float_denorm_style"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "float_denorm_style typedef"
  - "float_denorm_style function"
ms.assetid: b44f44e1-fbd0-4b7f-b086-3327cef90627
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# float_denorm_style
The enumeration describes the various methods that an implementation can choose for representing a denormalized floating-point value — one too small to represent as a normalized value:  
  
## Syntax  
  
```  
  
   enum float_denorm_style {  
denorm_indeterminate = -1,  
denorm_absent = 0,  
denorm_present = 1  
};  
```  
  
## Return Value  
 The enumeration returns:  
  
-   **denorm_indeterminate** if the presence or absence of denormalized forms cannot be determined at translation time.  
  
-   **denorm_absent** if denormalized forms are absent.  
  
-   **denorm_present** if denormalized forms are present.  
  
## Example  
 See [numeric_limits::has_denorm](../vs140/numeric_limits--has_denorm.md) for an example in which the values of this enumeration may be accessed.  
  
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std