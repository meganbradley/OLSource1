---
title: "basic_string::begin"
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
  - "std.basic_string.begin"
  - "std::basic_string::begin"
  - "basic_string.begin"
  - "begin"
  - "xstring/std::basic_string::begin"
  - "basic_string::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method, with specific classes"
ms.assetid: 60d2a15c-e299-4335-ac2c-299d9c51e7fe
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_string::begin
Returns an iterator addressing the first element in the string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A random-access iterator that addresses the first element of the sequence or just beyond the end of an empty sequence.  
  
## Remark  
 If the return value of **begin** is assigned to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the string object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the string object can be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)