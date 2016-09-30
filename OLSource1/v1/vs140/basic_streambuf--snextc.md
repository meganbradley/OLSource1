---
title: "basic_streambuf::snextc"
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
  - "streambuf/std::basic_streambuf::snextc"
  - "basic_streambuf::snextc"
  - "std::basic_streambuf::snextc"
  - "snextc"
  - "basic_streambuf.snextc"
  - "std.basic_streambuf.snextc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "snextc method"
ms.assetid: e78d04f2-1296-4a7b-b7f6-676de87ba289
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::snextc
Reads the current element and returns the following element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The next element in the stream.  
  
## Remarks  
 The member function calls [sbumpc](../vs140/basic_streambuf--sbumpc.md) and, if that function returns **traits_type::**[eof](../vs140/char_traits--eof.md), returns **traits_type::eof**. Otherwise, it returns [sgetc](../vs140/basic_streambuf--sgetc.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>97**   
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)