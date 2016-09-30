---
title: "endl"
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
  - "std::endl"
  - "ostream/std::endl"
  - "std.endl"
  - "endl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "endl function"
  - "endl"
ms.assetid: 489ac9ac-d37e-4162-a9b7-c5700324bc93
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# endl
Terminates a line and flushes the buffer.  
  
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
 The manipulator calls <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>**.**[put](../vs140/basic_ostream--put.md)(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>**.** [widen](../vs140/basic_ios--widen.md)(**'\n'**)), and then calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>**.**[flush](../vs140/basic_ostream--flush.md). It returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **testing**   
## Requirements  
 **Header:** \<ostream>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)