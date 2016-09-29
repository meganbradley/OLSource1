---
title: "is_error_code_enum Structure"
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
  - "future/std::is_error_code_enum"
dev_langs: 
  - "C++"
ms.assetid: 84ae4b99-66d2-41ba-9b50-645fcbe14630
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_error_code_enum Structure
Specialization that indicates that [future_errc](../VS_csharp/-future--enums.md#future_errc_enumeration) is suitable for storing an [error_code](../VS_csharp/error_code-class.md).  
  
## Syntax  
  
```  
template<>  
struct is_error_code_enum<Future_errc> : public true_type;  
```  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../VS_csharp/c---standard-library-header-files.md)   
 [<future\>](../VS_csharp/-future-.md)