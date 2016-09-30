---
title: "nouppercase"
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
  - "ios/std::nouppercase"
  - "nouppercase"
  - "std.nouppercase"
  - "std::nouppercase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nouppercase"
  - "nouppercase function"
ms.assetid: 7da102a7-5654-4aee-9965-6b36b271c8af
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nouppercase
Specifies that hexadecimal digits and the exponent in scientific notation appear in lowercase.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 The manipulator effectively calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base--unsetf.md)(<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 See [uppercase](../vs140/uppercase.md) for an example of using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)