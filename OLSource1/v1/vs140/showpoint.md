---
title: "showpoint"
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
  - "std::_Iosb::showpoint"
  - "showpoint"
  - "std._Iosb.showpoint"
  - "xiosbase/std::_Iosb::showpoint"
  - "_Iosb.showpoint"
  - "std.showpoint"
  - "std::showpoint"
  - "_Iosb::showpoint"
  - "ios/std::showpoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "showpoint"
  - "showpoint function"
ms.assetid: 1a5f8235-2bb2-4b3c-b9b8-d76e75046953
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# showpoint
Displays the whole-number part of a floating-point number and digits to the right of the decimal point even when the fractional part is zero.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 By default, [noshowpoint](../vs140/noshowpoint.md) is in effect.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[setf](../vs140/ios_base--setf.md)(<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 See [noshowpoint](../vs140/noshowpoint.md) for an example of using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)