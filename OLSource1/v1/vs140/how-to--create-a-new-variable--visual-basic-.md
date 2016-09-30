---
title: "How to: Create a New Variable (Visual Basic)"
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
  - "Dim statement"
  - "variables [Visual Basic], creating"
ms.assetid: 35300be3-77b0-4bef-a156-034d3cdedde0
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a New Variable (Visual Basic)
You create a variable with a [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md).  
  
### To create a new variable  
  
1.  Declare the variable in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Include specifications for the variable's characteristics, such as [Private (Visual Basic)](../vs140/private--visual-basic-.md), [Static (Visual Basic)](../vs140/static--visual-basic-.md), [Shadows](../vs140/shadows--visual-basic-.md), or [WithEvents](../vs140/withevents--visual-basic-.md). For more information, see [Declared Element Characteristics](../vs140/declared-element-characteristics--visual-basic-.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     You do not need the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword if you use other keywords in the declaration.  
  
3.  Follow the specifications with the variable's name, which must follow [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] rules and conventions. For more information, see [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  Follow the name with the [As](../vs140/as-clause--visual-basic-.md) clause to specify the variable's data type.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     If you do not specify the data type, it uses the default: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
5.  Follow the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause with an equal sign (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) and follow the equal sign with the variable's initial value.  
  
     [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] assigns the specified value to the variable every time it runs the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement. If you do not specify an initial value, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] assigns the default initial value for the variable's data type when it first enters the code that contains the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement.  
  
     If the variable is a reference type, you can create an instance of its class by including the [New (Visual Basic)](../vs140/new-operator--visual-basic-.md) keyword in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> clause. If you do not use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the initial value of the variable is [Nothing (Visual Basic)](../vs140/nothing--visual-basic-.md).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Variables in Visual Basic](../vs140/variables-in-visual-basic.md)   
 [Variable Declaration in Visual Basic](../vs140/variable-declaration-in-visual-basic.md)   
 [Declared Element Names](../vs140/declared-element-names--visual-basic-.md)   
 [Declared Element Characteristics](../vs140/declared-element-characteristics--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)   
 [Statements (Visual Basic)](../vs140/statements--visual-basic-.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Option Infer Statement](../vs140/option-infer-statement.md)