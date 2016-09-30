---
title: "_fmode"
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
  - "fmode"
  - "_fmode"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "file translation [C++], default mode"
  - "fmode function"
  - "_fmode function"
ms.assetid: ac6df9eb-e5cc-4c54-aff3-373c21983118
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fmode
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> variable sets the default file-translation mode for text or binary translation. This global variable has been deprecated for the more secure functional versions [_get_fmode](../vs140/_get_fmode.md) and [_set_fmode](../vs140/_set_fmode.md), which should be used in place of the global variable. It is declared in Stdlib.h as follows.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The default setting of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for text-mode translation. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the setting for binary mode.  
  
 You can change the value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in three ways:  
  
-   Link with Binmode.obj. This changes the initial setting of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, causing all files except <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to be opened in binary mode.  
  
-   Make a call to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to get or set the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> global variable, respectively.  
  
-   Change the value of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> directly by setting it in your program.  
  
## See Also  
 [Global Variables](../vs140/global-variables.md)   
 [_get_fmode](../vs140/_get_fmode.md)   
 [_set_fmode](../vs140/_set_fmode.md)