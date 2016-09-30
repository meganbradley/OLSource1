---
title: "Types of String Manipulation Methods in Visual Basic"
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
  - "strings [Visual Basic], manipulating [Visual Basic]"
  - "string manipulation"
ms.assetid: 905055cd-7f50-48fb-9eed-b0995af1dc1f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Types of String Manipulation Methods in Visual Basic
There are several different ways to analyze and manipulate your strings. Some of the methods are a part of the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] language, and others are inherent in the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class.  
  
## Visual Basic Language and the .NET Framework  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] methods are used as inherent functions of the language. They may be used without qualification in your code. The following example shows typical use of a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] string-manipulation command:  
  
 [!code[VbVbalrStrings#44](../vs140/codesnippet/VisualBasic/types-of-string-manipulation-methods-in-visual-basic_1.vb)]  
  
 In this example, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function performs a direct operation on <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and assigns the value to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 For a list of Visual Basic string manipulation methods, see [String Manipulation Summary](../vs140/string-manipulation-summary--visual-basic-.md).  
  
### Shared Methods and Instance Methods  
 You can also manipulate strings with the methods of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class. There are two types of methods in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>: *shared* methods and *instance* methods.  
  
#### Shared Methods  
 A shared method is a method that stems from the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class itself and does not require an instance of that class to work. These methods can be qualified with the name of the class (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) rather than with an instance of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class. For example:  
  
 [!code[VbVbalrStrings#45](../vs140/codesnippet/VisualBasic/types-of-string-manipulation-methods-in-visual-basic_2.vb)]  
  
 In the preceding example, the \<xref:System.String.Copy*?displayProperty=fullName> method is a static method, which acts upon an expression it is given and assigns the resulting value to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
#### Instance Methods  
 Instance methods, by contrast, stem from a particular instance of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and must be qualified with the instance name. For example:  
  
 [!code[VbVbalrStrings#46](../vs140/codesnippet/VisualBasic/types-of-string-manipulation-methods-in-visual-basic_3.vb)]  
  
 In this example, the \<xref:System.String.Substring*?displayProperty=fullName> method is a method of the instance of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (that is, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>). It performs an operation on <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and assigns that value to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 For more information, see the documentation for the \<xref:System.String*> class.  
  
## See Also  
 [Introduction to Strings in Visual Basic](../vs140/introduction-to-strings-in-visual-basic.md)