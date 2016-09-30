---
title: "left"
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
  - "std::_Iosb::left"
  - "Left"
  - "left"
  - "ios/std::left"
  - "std::left"
  - "std._Iosb.left"
  - "_Iosb::left"
  - "xiosbase/std::_Iosb::left"
  - "std.left"
  - "_Iosb.left"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "left"
  - "left function"
ms.assetid: b6ee767c-f452-4bde-95f8-be9542347b60
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# left
Causes text that is not as wide as the output width to appear in the stream flush with the left margin.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 The manipulator effectively calls <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[setf](../vs140/ios_base--setf.md)(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, **ios_base::adjustfield**), and then returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **5**  
**5**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)