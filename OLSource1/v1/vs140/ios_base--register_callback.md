---
title: "ios_base::register_callback"
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
  - "std::ios_base::register_callback"
  - "register_callback"
  - "ios_base::register_callback"
  - "ios_base.register_callback"
  - "std.ios_base.register_callback"
  - "xiosbase/std::ios_base::register_callback"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "register_callback"
  - "register_callback method"
ms.assetid: b4b053d7-8c17-4589-b91b-b35fab27f8d5
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::register_callback
Specifies a callback function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the callback function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A user-defined number.  
  
## Remarks  
 The member function pushes the pair <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> onto the stored callback stack [callback stack](../vs140/ios_base-class.md). When a callback event **ev** is reported, the functions are called, in reverse order of registry, by the expression (**\***<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>)(**ev**,<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **in callback1**  
**an imbue event**  
**in callback1**  
**an erase event**  
**in callback2**  
**an copyfmt event**  
**in callback2**  
**an erase event**  
**in callback2**  
**an erase event**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)