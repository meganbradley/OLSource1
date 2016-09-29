---
title: "Variable &#39;&lt;variablename&gt;&#39; is used before it has been assigned a value"
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
  - "vbc42104"
  - "BC42104"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC42104"
ms.assetid: 6909aa0b-b4a1-46f5-a18c-ba3e565c1dd8
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Variable &#39;&lt;variablename&gt;&#39; is used before it has been assigned a value
Variable '<variablename\>' is used before it has been assigned a value. A null reference exception could result at run time.  
  
 An application has at least one possible path through its code that reads a variable before any value is assigned to it.  
  
 If a variable has never been assigned a value, it holds the default value for its data type. For a reference data type, that default value is [Nothing (Visual Basic)](../vs140/nothing--visual-basic-.md). Reading a reference variable that has a value of `Nothing` can cause a <xref:System.NullReferenceException*> in some circumstances.  
  
 By default, this message is a warning. For more information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42104  
  
### To correct this error  
  
-   Check your control flow logic and make sure the variable has a valid value before control passes to any statement that reads it.  
  
-   One way to guarantee that the variable always has a valid value is to initialize it as part of its declaration. See "Initialization" in [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md).  
  
## See Also  
 [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md)   
 [Variable Declaration in Visual Basic](../vs140/variable-declaration-in-visual-basic.md)   
 [Troubleshooting Variables in Visual Basic](../vs140/troubleshooting-variables-in-visual-basic.md)