---
title: "internal (Standard C++ Library)"
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
  - "internal function"
  - "ios/std::internal"
  - "std::internal"
  - "std.internal"
  - "internal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "internal function"
  - "internal"
ms.assetid: 266fcb17-8949-4d35-9796-277c11ab95f1
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# internal (Standard C++ Library)
Causes a number's sign to be left justified and the number to be right justified.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to the object from which <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is derived.  
  
## Remarks  
 [showpos](../vs140/showpos.md) causes the sign to display for positive numbers.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.[setf](../vs140/ios_base--setf.md)([ios_base::internal](../vs140/ios_base--fmtflags.md), [ios_base::adjustfield](../vs140/ios_base--fmtflags.md)), and then returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **..-123.456**  
**-..123.456**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)