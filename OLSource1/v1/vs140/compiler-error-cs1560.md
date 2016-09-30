---
title: "Compiler Error CS1560"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1560"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1560"
ms.assetid: 772c4543-6c8d-453f-ae3f-d333528eb8b3
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1560
Invalid filename specified for preprocessor directive. Filename is too long or not a valid filename  
  
 The file name that was specified with [#line](../vs140/sharpline--csharp-reference-.md) exceeded _MAX_PATH (256 characters) or the line on which <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> was found exceeded 2000 characters.  
  
## Example  
 The following sample generates CS1560.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>