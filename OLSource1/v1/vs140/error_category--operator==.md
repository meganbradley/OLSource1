---
title: "error_category::operator=="
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
  - "system_error/std::error_category::operator=="
  - "std.error_category.operator=="
  - "std::error_category::operator=="
  - "error_category.operator=="
  - "operator=="
  - "=="
  - "error_category::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator==, errors"
  - "== operator, with specific standard C++ library objects"
  - "operator ==, errors"
ms.assetid: db62bb1c-3f85-427a-8257-10f5d38452f7
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# error_category::operator==
Tests for equality between `error_category` objects.  
  
## Syntax  
  
```  
bool operator==(const error_category& _Right) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Right`|The object to be tested for equality.|  
  
## Return Value  
 **true** if the objects are equal; **false** if the objects are not equal.  
  
## Remarks  
 This member operator returns `this == &_Right`.  
  
## Requirements  
 **Header:** \<system_error>  
  
 **Namespace:** std  
  
## See Also  
 [error_category Class](../vs140/error_category-class.md)