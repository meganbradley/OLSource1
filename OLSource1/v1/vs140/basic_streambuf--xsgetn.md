---
title: "basic_streambuf::xsgetn"
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
  - "basic_streambuf.xsgetn"
  - "xsgetn"
  - "basic_streambuf::xsgetn"
  - "std::basic_streambuf::xsgetn"
  - "std.basic_streambuf.xsgetn"
  - "streambuf/std::basic_streambuf::xsgetn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "xsgetn method"
ms.assetid: 39d26568-eb2e-485f-b7f5-a83738dfcef6
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::xsgetn
Protected, virtual function to extract elements from the input stream.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The buffer to contain the extracted characters.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of elements to extract.  
  
## Return Value  
 The number of elements extracted.  
  
## Remarks  
 The protected virtual member function extracts up to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> elements from the input stream, as if by repeated calls to [sbumpc](../vs140/basic_streambuf--sbumpc.md), and stores them in the array beginning at <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. It returns the number of elements actually extracted.  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)