---
title: "basic_istream::seekg"
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
  - "std.basic_istream.seekg"
  - "istream/std::basic_istream::seekg"
  - "std::basic_istream::seekg"
  - "seekg"
  - "basic_istream.seekg"
  - "basic_istream::seekg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seekg method"
ms.assetid: 0fd8591f-d0c0-4f25-8999-467d95ba2429
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::seekg
Moves the read position in a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The absolute position in which to move the read pointer.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An offset to move the read pointer relative to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 One of the [ios_base::seekdir](../vs140/ios_base--seekdir.md) enumerations.  
  
## Return Value  
 The stream (**\*this**).  
  
## Remarks  
 The first member function performs an absolute seek, the second member function performs a relative seek.  
  
> [!NOTE]
>  Do not use the second member function with text files, because Standard C++ does not support relative seeks in text files.  
  
 If [fail](../vs140/basic_ios--fail.md) is false, the first member function calls **newpos** = [rdbuf](../vs140/basic_ios--rdbuf.md) -> [pubseekpos](../vs140/basic_streambuf--pubseekpos.md)(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>), for some **pos_type** temporary object **newpos**. If **fail** is false, the second function calls **newpos** = **rdbuf** -> [pubseekoff](../vs140/basic_streambuf--pubseekoff.md)(<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>). In either case, if (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>)**newpos** == (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>)(-1) (the positioning operation fails), the function calls **istr**.[setstate](../vs140/basic_ios--setstate.md)(**failbit**). Both functions return **\*this**.  
  
 If [fail](../vs140/basic_ios--fail.md) is true, the member functions do nothing.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: basic_istream_seekg.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)