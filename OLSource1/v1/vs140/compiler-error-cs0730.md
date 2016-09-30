---
title: "Compiler Error CS0730"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0730"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0730"
ms.assetid: bf291285-dc1e-4c8d-a449-119004adc088
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0730
Cannot forward type 'type' because it is a nested type of 'type'  
  
 This error is generated when you try to forward a nested class.  
  
## Example  
 The following sample generates CS0730. It consists of two source files. First, compile the library file <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and the compile the file <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> referencing the library file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>