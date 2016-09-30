---
title: "wcerr"
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
  - "std.wcerr"
  - "std::wcerr"
  - "wcerr"
  - "iostream/std::wcerr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wcerr function"
  - "console, text"
  - "text output"
  - "console, writing to"
  - "text, formatting"
  - "printing [C++], printing to console"
  - "console, writing formatted text to"
ms.assetid: 8b4ca0b7-99a5-45c2-a221-b4e1545b8d32
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wcerr
Specifies the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> global stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A [wostream](../vs140/wostream.md) object.  
  
## Remarks  
 The object controls unbuffered insertions to the standard error output as a wide stream. Once the object is constructed, the expression <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[flags](../vs140/ios_base--flags.md) <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [unitbuf](../vs140/unitbuf.md) is nonzero.  
  
## Example  
 See [cerr](../vs140/cerr.md) for an example of using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<iostream>  
  
 **Namespace:** std  
  
## See Also  
 [wostream](../vs140/wostream.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)