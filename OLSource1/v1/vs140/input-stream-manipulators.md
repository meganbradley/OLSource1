---
title: "Input Stream Manipulators"
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
  - "input streams, manipulators"
  - "input stream objects"
ms.assetid: 0addcacb-7b7b-4d70-9775-a59abc400fb3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Input Stream Manipulators
Many manipulators, such as [setprecision](../vs140/setprecision.md), are defined for the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class and thus apply to input streams. Few manipulators, however, actually affect input stream objects. Of those that do, the most important are the radix manipulators, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which determine the conversion base used with numbers from the input stream.  
  
 On extraction, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> manipulator enables processing of various input formats. For example, c, C, 0xc, 0xC, 0Xc, and 0XC are all interpreted as the decimal integer 12. Any character other than 0 through 9, A through F, a through f, x, and X terminates the numeric conversion. Thus the sequence <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is converted to the number 124 with the [basic_ios::fail](../vs140/basic_ios--fail.md) bit set.  
  
## See Also  
 [Input Streams](../vs140/input-streams.md)