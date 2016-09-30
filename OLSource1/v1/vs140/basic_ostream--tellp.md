---
title: "basic_ostream::tellp"
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
  - "basic_ostream.tellp"
  - "tellp"
  - "ostream/std::basic_ostream::tellp"
  - "std::basic_ostream::tellp"
  - "std.basic_ostream.tellp"
  - "basic_ostream::tellp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tellp method"
ms.assetid: 3e10107e-7ec2-4b98-b271-bfb69cb52a76
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ostream::tellp
Report position in output stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Position in output stream.  
  
## Remarks  
 If [fail](../vs140/basic_ios--fail.md) is **false**, the member function returns [rdbuf](../vs140/basic_ios--rdbuf.md)**->** [pubseekoff](../vs140/basic_streambuf--pubseekoff.md)(0, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, **in**). Otherwise, it returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>(-1).  
  
## Example  
 See [seekp](../vs140/basic_ostream--seekp.md) for an example using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<ostream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ostream Class](../vs140/basic_ostream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)