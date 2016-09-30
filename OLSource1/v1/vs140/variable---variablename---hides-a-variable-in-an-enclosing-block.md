---
title: "Variable &#39;&lt;variablename&gt;&#39; hides a variable in an enclosing block"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc30616"
  - "bc30616"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30616"
ms.assetid: e7658ebc-da45-451b-a409-a0f8915f0beb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Variable &#39;&lt;variablename&gt;&#39; hides a variable in an enclosing block
A variable enclosed in a block has the same name as another local variable.  
  
 **Error ID:** BC30616  
  
### To correct this error  
  
-   Rename the variable in the enclosed block so that it is not the same as any other local variables. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   A common cause for this error is the use of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> inside an event handler. If this is the case, name the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block variable <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
-   Another common source of this error is an attempt to access a local variable declared within a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block in a separate <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> block. To correct this, declare the variable outside the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure.  
  
## See Also  
 [Try...Catch...Finally Statement](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [Variable Declaration](../vs140/variable-declaration-in-visual-basic.md)