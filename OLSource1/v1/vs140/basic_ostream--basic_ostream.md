---
title: "basic_ostream::basic_ostream"
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
  - "ostream/std::basic_ostream::basic_ostream"
  - "basic_ostream::basic_ostream"
  - "std::basic_ostream::basic_ostream"
  - "std.basic_ostream.basic_ostream"
  - "basic_ostream.basic_ostream"
  - "basic_ostream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_ostream class, constructor"
  - "basic_ostream method"
ms.assetid: aa09e4d4-26a0-4a06-9392-3bcd6865d457
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ostream::basic_ostream
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type [basic_streambuf](../vs140/basic_streambuf-class.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if this is a standard stream; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An rvalue reference to an object of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first constructor initializes the base class by calling [init](../vs140/basic_ios--init.md)(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>). The second constructor initializes the base class by calling [move](../vs140/basic_ios--move.md)<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [basic_ofstream::basic_ofstream](../vs140/basic_ofstream--basic_ofstream.md) to learn more about output streams.  
  
## Requirements  
 **Header:** \<ostream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ostream Class](../vs140/basic_ostream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)