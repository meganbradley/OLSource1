---
title: "showpos"
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
  - "xiosbase/std::_Iosb::showpos"
  - "_Iosb::showpos"
  - "std.showpos"
  - "ios/std::showpos"
  - "std::showpos"
  - "std::_Iosb::showpos"
  - "std._Iosb.showpos"
  - "_Iosb.showpos"
  - "showpos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "showpos"
  - "showpos function"
ms.assetid: 828c110d-01e9-4deb-8853-c8ea0ba6f0a0
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# showpos
Causes positive numbers to be explicitly signed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 [noshowpos](../vs140/noshowpos.md) is the default.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[setf](../vs140/ios_base--setf.md)(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **1**  
**+1**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)