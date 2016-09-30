---
title: "noshowpoint"
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
  - "noshowpoint"
  - "ios/std::noshowpoint"
  - "std.noshowpoint"
  - "std::noshowpoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "noshowpoint"
  - "noshowpoint function"
ms.assetid: 2b8e0e1f-08d6-4371-a993-d1a4cdb29f23
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# noshowpoint
Displays only the whole-number part of floating-point numbers whose fractional part is zero.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is on by default; use [showpoint](../vs140/showpoint.md) and [precision](../vs140/ios_base--precision.md) to display zeros after the decimal point.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base--unsetf.md)(<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **5**  
**5.000**  
**5**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)