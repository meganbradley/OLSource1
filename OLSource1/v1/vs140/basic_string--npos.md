---
title: "basic_string::npos"
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
  - "basic_string.npos"
  - "basic_string::npos"
  - "std.basic_string.npos"
  - "npos"
  - "xstring/std::basic_string::npos"
  - "std::basic_string::npos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "npos"
  - "npos method"
ms.assetid: 8c594660-1c76-4342-ab76-4dc0ef7fe0ff
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::npos
An unsigned integral value initialized to –1 that indicates either "not found" or "all remaining characters" when a search function fails.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When the return value is to be checked for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value, it might not work unless the return value is of type [size_type](../vs140/basic_string--size_type.md) and not either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [find](../vs140/basic_string--find.md) for an example of how to declare and use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)