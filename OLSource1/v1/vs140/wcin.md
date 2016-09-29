---
title: "wcin"
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
  - "std.wcin"
  - "wcin"
  - "std::wcin"
  - "iostream/std::wcin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "console, reading formatted text from"
  - "wcin function"
  - "console, reading from"
  - "text input"
ms.assetid: 01923863-4f82-40f3-950c-4a62c69ca1ce
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wcin
Specifies the `wcin` global stream.  
  
## Syntax  
  
```  
extern wistream wcin;  
```  
  
## Return Value  
 A [wistream](../vs140/wistream.md) object.  
  
## Remarks  
 The object controls extractions from the standard input as a wide stream. Once the object is constructed, the call `wcin.`[tie](../vs140/basic_ios--tie.md) returns `&`[wcout](../vs140/wcout.md).  
  
## Example  
 See [cerr](../vs140/cerr.md) for an example of using `wcin`.  
  
## Requirements  
 **Header:** \<iostream>  
  
 **Namespace:** std  
  
## See Also  
 [wistream](../vs140/wistream.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)