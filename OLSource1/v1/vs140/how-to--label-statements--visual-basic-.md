---
title: "How to: Label Statements (Visual Basic)"
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
  - "colons (:)"
  - "statements [Visual Basic], labels"
  - ": separator character"
  - "Visual Basic code, labeling statements"
ms.assetid: 38f1ff43-2054-42cb-963b-1998e60c6ed4
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Label Statements (Visual Basic)
Statement blocks are made up of lines of code delimited by colons. Lines of code preceded by an identifying string or integer are said to be *labeled*. Statement labels are used to mark a line of code to identify it for use with statements such as `On Error Goto`.  
  
 Labels may be either valid Visual Basic identifiers—such as those that identify programming elements—or integer literals. A label must appear at the beginning of a line of source code and must be followed by a colon, regardless of whether it is followed by a statement on the same line.  
  
 The compiler identifies labels by checking whether the beginning of the line matches any already-defined identifier. If it does not, the compiler assumes it is a label.  
  
 Labels have their own declaration space and do not interfere with other identifiers. A label's scope is the body of the method. Label declaration takes precedence in any ambiguous situation.  
  
> [!NOTE]
>  Labels can be used only on executable statements inside methods.  
  
### To label a line of code  
  
-   Place an identifier, followed by a colon, at the beginning of the line of source code.  
  
     For example, the following lines of code are labeled with `Jump` and `120`, respectively:  
  
     [!code[VbVbalrStatements#708](../vs140/codesnippet/VisualBasic/how-to--label-statements--visual-basic-_1.vb)]  
  
## See Also  
 [Statements in Visual Basic](../vs140/statements-in-visual-basic.md)   
 [Declared Element Names](../vs140/declared-element-names--visual-basic-.md)   
 [Program Structure and Code Conventions](../vs140/program-structure-and-code-conventions--visual-basic-.md)