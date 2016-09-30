---
title: "basic_istream::peek"
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
  - "std::basic_istream::peek"
  - "std.basic_istream.peek"
  - "basic_istream.peek"
  - "basic_istream::peek"
  - "peek"
  - "istream/std::basic_istream::peek"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "peek method"
ms.assetid: 46bbcc99-bfc1-483c-a9fa-683ffdcc42b8
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::peek
Returns the next character to be read.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The next character that will be read.  
  
## Remarks  
 The unformatted input function extracts an element, if possible, as if by returning <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> ->[sgetc](../vs140/basic_streambuf--sgetc.md). Otherwise, it returns **traits_type::**[eof](../vs140/char_traits--eof.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>Type 'abcde': abcde**  
**a abcde**   
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)