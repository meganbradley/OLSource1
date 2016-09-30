---
title: "basic_istream::readsome"
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
  - "basic_istream.readsome"
  - "basic_istream::readsome"
  - "std::basic_istream::readsome"
  - "std.basic_istream.readsome"
  - "istream/std::basic_istream::readsome"
  - "readsome"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "readsome method"
ms.assetid: 280423b5-9c5d-4133-b558-87b0285c019d
caps.latest.revision: 29
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::readsome
Reads the specified number of character values.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The array in which <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> stores the characters it reads.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The number of characters to read.  
  
## Return Value  
 The number of characters actually read, [gcount](../vs140/basic_istream--gcount.md).  
  
## Remarks  
 This unformatted input function extracts up to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> elements from the input stream and stores them in the array <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 This function does not wait for input. It reads whatever data is available.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)