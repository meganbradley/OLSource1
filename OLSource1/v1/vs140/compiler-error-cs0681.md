---
title: "Compiler Error CS0681"
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
  - "CS0681"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0681"
ms.assetid: aa51ad94-df0a-481d-aaea-5b4291ebc41c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0681
The modifier 'abstract' is not valid on fields. Try using a property instead  
  
 You cannot make a field abstract. You can, however, have an abstract property that accesses the field.  
  
## Example  
 The following sample generates CS0681:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 Try the following code instead:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>