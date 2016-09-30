---
title: "Labeled Statements"
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
  - "goto"
  - "case"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "labeled statement"
  - "statements, labeled"
ms.assetid: 456a26d5-0fcc-4d1a-b71f-fa9ff3d73b91
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Labeled Statements
Labels are used to transfer program control directly to the specified statement.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The scope of a label is the entire function in which it is declared.  
  
## Remarks  
 There are three types of labeled statements. All use a colon to separate some type of label from the statement. The case and default labels are specific to case statements.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The goto statement**  
  
 The appearance of an *identifier* label in the source program declares a label. Only a [goto](../vs140/goto-statement--c---.md) statement can transfer control to an *identifier* label. The following code fragment illustrates use of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement and an *identifier* label:  
  
 A label cannot appear by itself but must always be attached to a statement. If a label is needed by itself, place a null statement after the label.  
  
 The label has function scope and cannot be redeclared within the function. However, the same name can be used as a label in different functions.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **The case statement**  
  
 Labels that appear after the **case** keyword cannot also appear outside a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement. (This restriction also applies to the **default** keyword.) The following code fragment shows the correct use of **case** labels:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Labels in the case statement  
 Labels that appear after the **case** keyword cannot also appear outside a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement. (This restriction also applies to the **default** keyword.) The following code fragment shows the correct use of **case** labels:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Labels in the goto statement  
 The appearance of an *identifier* label in the source program declares a label. Only a [goto](../vs140/goto-statement--c---.md) statement can transfer control to an *identifier* label. The following code fragment illustrates use of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement and an *identifier* label:  
  
 A label cannot appear by itself but must always be attached to a statement. If a label is needed by itself, place a null statement after the label.  
  
 The label has function scope and cannot be redeclared within the function. However, the same name can be used as a label in different functions.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Overview of C++ Statements](../vs140/overview-of-c---statements.md)   
 [switch Statement (C++)](../vs140/switch-statement--c---.md)