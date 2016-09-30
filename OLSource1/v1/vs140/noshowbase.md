---
title: "noshowbase"
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
  - "std.noshowbase"
  - "ios/std::noshowbase"
  - "noshowbase"
  - "std::noshowbase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "noshowbase function"
  - "noshowbase"
ms.assetid: 9b0ed399-19bf-4eef-8935-53f3aa2e25a5
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# noshowbase
Turns off indicating the notational base in which a number is displayed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is on by default. Use [showbase](../vs140/showbase.md) to indicate the notational base of numbers.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base--unsetf.md)(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
 See [showbase](../vs140/showbase.md) for an example of how to use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)