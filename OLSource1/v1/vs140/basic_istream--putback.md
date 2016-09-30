---
title: "basic_istream::putback"
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
  - "std::basic_istream::putback"
  - "istream/std::basic_istream::putback"
  - "basic_istream.putback"
  - "putback"
  - "std.basic_istream.putback"
  - "basic_istream::putback"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "putback method"
ms.assetid: 27776f44-9a5e-46be-b2a1-02229117e9fb
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::putback
Puts a specified character into the stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A character to put back into the stream.  
  
## Return Value  
 The stream (**\*this**).  
  
## Remarks  
 The [unformatted input function](../vs140/basic_istream-class.md) puts back <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, if possible, as if by calling [rdbuf](../vs140/basic_ios--rdbuf.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[sputbackc](../vs140/basic_streambuf--sputbackc.md). If rdbuf is a null pointer, or if the call to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns **traits_type::**[eof](../vs140/char_traits--eof.md), the function calls [setstate](../vs140/basic_ios--setstate.md)(**badbit**). In any case, it returns **\*this**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>q**   
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)