---
title: "error_condition::operator bool"
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
  - "system_error/std::error_condition::operator bool"
  - "error_condition.operator=="
  - "error_condition::operator bool"
  - "operator bool"
  - "std::error_condition::operator bool"
  - "std.error_condition.operator bool"
  - "bool"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator bool, errors"
  - "bool operator, with specific standard C++ library objects"
ms.assetid: d8170da9-d26f-4206-814a-984a7694d942
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# error_condition::operator bool
Casts a variable of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The Boolean value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The operator returns a value convertible to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> only if [value](../vs140/error_condition--value.md) is not equal to zero. The return type is convertible only to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, not to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or other known scalar types.  
  
## Requirements  
 **Header:** \<system_error>  
  
 **Namespace:** std  
  
## See Also  
 [error_condition Class](../vs140/error_condition-class.md)