---
title: "error_condition::assign"
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
  - "assign"
  - "system_error/std::error_condition::assign"
  - "std::error_condition::assign"
  - "std.error_condition.assign"
  - "error_condition::assign"
  - "error_condition.assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign function"
ms.assetid: 447124f9-81ea-463b-9feb-4aff883e97bc
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# error_condition::assign
Assigns an error code value and category to an error condition.  
  
## Syntax  
  
```  
void assign(value_type _Val, const error_category& _Cat);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Val`|The error code value to store in the `error_code`.|  
|`_Cat`|The error category to store in the `error_code`.|  
  
## Remarks  
 The member function stores `_Val` as the error code value and a pointer to `_Cat`.  
  
## Requirements  
 **Header:** <system_error>  
  
 **Namespace:** std  
  
## See Also  
 [error_condition Class](../vs140/error_condition-class.md)