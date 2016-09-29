---
title: "numpunct::string_type"
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
  - "string_type"
  - "numpunct.string_type"
  - "xlocnum/std::numpunct::string_type"
  - "std::numpunct::string_type"
  - "std.numpunct.string_type"
  - "numpunct::string_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "string_type typedef"
ms.assetid: 21711339-c0af-4a47-8b62-3603f7c4f0a2
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numpunct::string_type
A type that describes a string containing characters of type **CharType**.  
  
## Syntax  
  
```  
typedef basic_string<CharType, Traits, Allocator> string_type;  
```  
  
## Remarks  
 The type describes a specialization of template class [basic_string](../vs140/basic_string-class.md) whose objects can store copies of the punctuation sequences.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [numpunct Class](../vs140/numpunct-class.md)