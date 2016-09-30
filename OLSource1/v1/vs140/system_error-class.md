---
title: "system_error Class"
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
  - "system_error/std::system_error"
  - "std.system_error"
  - "std::system_error"
  - "system_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "system_error class"
ms.assetid: 2eeaacbb-8a4a-4ad7-943a-997901a77f32
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# system_error Class
Represents the base class for all exceptions thrown to report a low-level system error.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The value returned by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in the class [exception](../vs140/exception-class.md) is constructed from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and the stored object of type [error_code](../vs140/error_code-class.md) (either <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
 The member function <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the stored [error_code](../vs140/error_code-class.md) object.  
  
## Requirements  
 **Header:** \<system_error>  
  
 **Namespace:** std  
  
## See Also  
 [\<system_error>](../vs140/-system_error-.md)