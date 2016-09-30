---
title: "Other One-Argument Output Stream Manipulators"
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
  - "output streams, one-argument manipulators"
ms.assetid: e381dee8-6b16-4cef-805a-4a6a1d2b696b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Other One-Argument Output Stream Manipulators
The following example uses a class <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, which is a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> type. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> manipulator attaches a formatting "picture" string to the class that can be used by the overloaded stream insertion operator of the class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The picture string is stored as a static variable in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class rather than as data member of a stream class, so you do not have to derive a new output stream class.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Custom Manipulators with Arguments](../vs140/custom-manipulators-with-arguments.md)