---
title: "basic_istream::tellg"
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
  - "std.basic_istream.tellg"
  - "basic_istream::tellg"
  - "basic_istream.tellg"
  - "std::basic_istream::tellg"
  - "istream/std::basic_istream::tellg"
  - "tellg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tellg method"
ms.assetid: b99be17d-e0d1-4177-ac4a-06d8ebd4110b
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::tellg
Reports the current read position in the stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The current position in the stream.  
  
## Remarks  
 If [fail](../vs140/basic_ios--fail.md) is false, the member function returns [rdbuf](../vs140/basic_ios--rdbuf.md) -> [pubseekoff](../vs140/basic_streambuf--pubseekoff.md)(0, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, **in**). Otherwise, it returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>(-1).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: basic_istream_tellg.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Program Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)