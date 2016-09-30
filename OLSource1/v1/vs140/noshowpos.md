---
title: "noshowpos"
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
  - "noshowpos"
  - "std::noshowpos"
  - "ios/std::noshowpos"
  - "std.noshowpos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "noshowpos function"
  - "noshowpos"
ms.assetid: bc1058d3-2eab-41c0-93a8-d7b9dc1d896a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# noshowpos
Causes positive numbers to not be explicitly signed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is on by default.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base--unsetf.md)(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>), then returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
 See [showpos](../vs140/showpos.md) for an example of using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)