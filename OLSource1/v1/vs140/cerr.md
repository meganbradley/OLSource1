---
title: "cerr"
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
  - "std.cerr"
  - "iostream/std::cerr"
  - "std::cerr"
  - "cerr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "console, text"
  - "text output"
  - "console, writing to"
  - "text, formatting"
  - "printing [C++], printing to console"
  - "console, writing formatted text to"
  - "cerr function"
ms.assetid: 3e9f0d43-c801-41c0-b17b-4d8b62f31178
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cerr
The object <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> controls output to a stream buffer associated with the object <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, declared in \<cstdio>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An [ostream](../vs140/ostream.md) object.  
  
## Remarks  
 The object controls unbuffered insertions to the standard error output as a byte stream. Once the object is constructed, the expression <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[flags](../vs140/ios_base--flags.md) <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> [unitbuf](../vs140/unitbuf.md) is nonzero, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<iostream>  
  
 **Namespace:** std  
  
## See Also  
 [ostream](../vs140/ostream.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)