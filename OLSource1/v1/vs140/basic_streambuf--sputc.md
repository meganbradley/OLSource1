---
title: "basic_streambuf::sputc"
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
  - "streambuf/std::basic_streambuf::sputc"
  - "basic_streambuf::sputc"
  - "sputc"
  - "std::basic_streambuf::sputc"
  - "basic_streambuf.sputc"
  - "std.basic_streambuf.sputc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sputc method"
ms.assetid: f134b0d5-f8eb-4838-8094-e5628eb603f4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::sputc
Puts a character into the stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The character.  
  
## Return Value  
 Returns the character, if successful.  
  
## Remarks  
 If a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is available, the member function stores <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the write position, increments the next pointer for the output buffer, and returns **traits_type::**[to_int_type](../vs140/char_traits--to_int_type.md)(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>). Otherwise, it returns [overflow](../vs140/basic_streambuf--overflow.md)(<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **a**  
**a**   
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)