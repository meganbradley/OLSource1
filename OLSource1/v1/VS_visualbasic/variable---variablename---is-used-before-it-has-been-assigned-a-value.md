---
title: "Variable &#39;&lt;variablename&gt;&#39; is used before it has been assigned a value"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 10
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Variable &#39;&lt;variablename&gt;&#39; is used before it has been assigned a value
Variable '\<variablename>' is used before it has been assigned a value. A null reference exception could result at run time.  
  
 An application has at least one possible path through its code that reads a variable before any value is assigned to it.  
  
 If a variable has never been assigned a value, it holds the default value for its data type. For a reference data type, that default value is [Nothing](../VS_visualbasic/nothing--visual-basic-.md). Reading a reference variable that has a value of `Nothing` can cause a \<xref:System.NullReferenceException> in some circumstances.  
  
 By default, this message is a warning. For more information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../Topic/Configuring%20Warnings%20in%20Visual%20Basic.md).  
  
 **Error ID:** BC42104  
  
### To correct this error  
  
-   Check your control flow logic and make sure the variable has a valid value before control passes to any statement that reads it.  
  
-   One way to guarantee that the variable always has a valid value is to initialize it as part of its declaration. See "Initialization" in [Dim Statement](../VS_visualbasic/dim-statement--visual-basic-.md).  
  
## See Also  
 [Dim Statement](../VS_visualbasic/dim-statement--visual-basic-.md)   
 [Variable Declaration](../VS_visualbasic/variable-declaration-in-visual-basic.md)   
 [Troubleshooting Variables](../VS_visualbasic/troubleshooting-variables-in-visual-basic.md)