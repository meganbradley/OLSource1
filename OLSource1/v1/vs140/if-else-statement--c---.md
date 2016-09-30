---
title: "if-else Statement (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "else_cpp"
  - "else"
  - "if_cpp"
  - "if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "if keyword [C++]"
  - "else keyword [C++]"
  - "if keyword [C++], if-else"
ms.assetid: f8c45cde-6bce-42ae-81db-426b3dbd4caa
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# if-else Statement (C++)
Controls conditional branching.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the value of *expression* is nonzero, *statement1* is executed. If the optional **else** is present, *statement2* is executed if the value of *expression* is zero. *expression* must be of arithmetic or pointer type, or it must be of a class type that defines an unambiguous conversion to an arithmetic or pointer type. (For information about conversions, see [Standard Conversions](../vs140/standard-conversions.md).)  
  
 In both forms of the **if** statement, *expression*, which can have any value except a structure, is evaluated, including all side effects. Control passes from the **if** statement to the next statement in the program unless one of the *statement*s contains a [break](../vs140/break-statement--c---.md), [continue](../vs140/continue-statement--c---.md), or [goto](../vs140/goto-statement--c---.md).  
  
 The **else** clause of an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement is associated with the closest previous **if** statement in the same scope that does not have a corresponding **else** statement.  
  
 For this sample to be unambiguous about <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pairing, uncomment the braces.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **x is 0!**  
**x is not 0!**   
## See Also  
 [Selection Statements](../vs140/selection-statements--c---.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [switch Statement (C++)](../vs140/switch-statement--c---.md)