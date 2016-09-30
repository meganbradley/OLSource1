---
title: "common_type Class"
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
  - "std.tr1.common_type"
  - "common_type"
  - "std::tr1::common_type"
  - "std.common_type"
  - "std::common_type"
  - "type_traits/std::common_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "common_type class[TR1]"
  - "common_type"
ms.assetid: 02bc4e7b-c63d-49de-9f8a-511d3a5c1e7f
caps.latest.revision: 24
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# common_type Class
Determines the common type of one or more types.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 List of types that are either [complete types](../vs140/incomplete-types.md) or void.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member is the common type to which all types in the parameter list can be converted.  
  
## Example  
 The following program demonstrates some correct usage scenarios and tests for results.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)