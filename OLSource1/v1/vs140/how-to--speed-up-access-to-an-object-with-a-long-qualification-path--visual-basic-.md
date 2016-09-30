---
title: "How to: Speed Up Access to an Object with a Long Qualification Path (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "variables [Visual Basic], accessing"
  - "variables [Visual Basic], object"
  - "With statement"
  - "With block"
  - "object variables, accessing"
ms.assetid: 3eb7657f-c9fe-4e05-8bc3-4bb14d5ae585
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Speed Up Access to an Object with a Long Qualification Path (Visual Basic)
If you frequently access an object that requires a qualification path of several methods and properties, you can speed up your code by not repeating the qualification path.  
  
 There are two ways you can avoid repeating the qualification path. You can assign the object to a variable, or you can use it in a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block.  
  
### To speed up access to a heavily qualified object by assigning it to a variable  
  
1.  Declare a variable of the type of the object that you are accessing frequently. Specify the qualification path in the initialization part of the declaration.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Use the variable to access the object's members.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### To speed up access to a heavily qualified object by using a With...End With block  
  
1.  Put the qualification path in a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
2.  Access the object's members inside the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block, before the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Object Variables in Visual Basic](../vs140/object-variables-in-visual-basic.md)   
 [With...End With Statement](../vs140/with...end-with-statement--visual-basic-.md)