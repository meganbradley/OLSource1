---
title: "boolalpha"
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
  - "_Iosb::boolalpha"
  - "ios/std::boolalpha"
  - "boolalpha"
  - "std::_Iosb::boolalpha"
  - "_Iosb.boolalpha"
  - "std.boolalpha"
  - "std::boolalpha"
  - "std._Iosb.boolalpha"
  - "xiosbase/std::_Iosb::boolalpha"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "boolalpha"
  - "boolalpha function"
ms.assetid: 61930ce9-e40e-4837-a299-ab23984ca2ac
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# boolalpha
Specifies that variables of type [bool](../vs140/bool--c---.md) appear as **true** or **false** in the stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 By default, variables of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are displayed as 1 or 0.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> effectively calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[setf](../vs140/ios_base--setf.md)(<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 [noboolalpha](../vs140/noboolalpha.md) reverses the effect of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **1**  
**true**  
**1**  
**true**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)