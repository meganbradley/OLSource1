---
title: "ends (Standard C++ Library)"
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
  - "ostream/std::ends"
  - "std.ends"
  - "ENDS"
  - "std::ends"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ends function"
ms.assetid: 98f6faf9-813f-474e-8ef7-3e0d613f2024
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ends (Standard C++ Library)
Terminates a string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The element type.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Character traits.  
  
## Return Value  
 An object of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The manipulator calls <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>**.**[put](../vs140/basic_ostream--put.md)(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>(**'\0'**)). It returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **ab c**   
## Requirements  
 **Header:** \<ostream>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)