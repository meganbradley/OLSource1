---
title: "dec"
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
  - "std::dec"
  - "_Iosb.dec"
  - "std._Iosb.dec"
  - "std::_Iosb::dec"
  - "_Iosb::dec"
  - "std.dec"
  - "dec"
  - "xiosbase/std::_Iosb::dec"
  - "ios/std::dec"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dec function"
  - "dec"
ms.assetid: c8045c76-e259-4ce1-96c0-f7b8c0b57c0d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# dec
Specifies that integer variables appear in base 10 notation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 By default, integer variables are displayed in base 10.  
  
 **dec** effectively calls <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[setf](../vs140/ios_base--setf.md)(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>**, ios_base::basefield**), and then returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **100**  
**64**  
**100**  
**144**  
**100**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)