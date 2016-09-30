---
title: "cin"
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
  - "cin"
  - "std.cin"
  - "iostream/std::cin"
  - "std::cin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "console, reading formatted text from"
  - "console, reading from"
  - "cin function"
  - "text input"
ms.assetid: 0a830ffb-db8b-4cfc-a303-6ae4200ab760
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cin
Specifies the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> global stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An [istream](../vs140/istream.md) object.  
  
## Remarks  
 The object controls extractions from the standard input as a byte stream. Once the object is constructed, the call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[tie](../vs140/basic_ios--tie.md) returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[cout](../vs140/cout.md).  
  
## Example  
 In this example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> sets the fail bit on the stream when it encounters non-numeric characters. The program clears the fail bit and strips the invalid character from the stream to proceed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>**    
## Requirements  
 **Header:** \<iostream>  
  
 **Namespace:** std  
  
## See Also  
 [istream](../vs140/istream.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)