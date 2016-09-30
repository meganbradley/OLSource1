---
title: "noskipws"
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
  - "std.noskipws"
  - "ios/std::noskipws"
  - "std::noskipws"
  - "noskipws"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "noskipws function"
  - "noskipws"
ms.assetid: 56aac0c2-5044-478e-be0d-c57035d8e449
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# noskipws
Cause spaces to be read by the input stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 By default, [skipws](../vs140/skipws.md) is in effect. When a space is read in the input stream, it signals the end of the buffer.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base--unsetf.md)(<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)