---
title: "Output Stream Manipulators with One Argument (int or long)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "output streams, int or long argument manipulators"
ms.assetid: 338f3164-b5e2-4c5a-a605-7d9dc3629ca1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Output Stream Manipulators with One Argument (int or long)
The iostream class library provides a set of macros for creating parameterized manipulators. Manipulators with a single <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> argument are a special case. To create an output stream manipulator that accepts a single <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument (like <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>), you must use the _Smanip macro, which is defined in \<iomanip>. This example defines a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> manipulator that inserts a specified number of blanks into the stream:  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Custom Manipulators with Arguments](../vs140/custom-manipulators-with-arguments.md)