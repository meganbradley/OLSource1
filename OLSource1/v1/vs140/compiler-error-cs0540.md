---
title: "Compiler Error CS0540"
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
  - "CS0540"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0540"
ms.assetid: 2da2cd4a-0ff1-45ea-bb72-ea078bc95dea
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0540
'interface member' : containing type does not implement interface 'interface'  
  
 You attempted to implement an interface member in a [class](../vs140/class--csharp-reference-.md) that does not derive from the [interface](../vs140/interface--csharp-reference-.md). You should either delete the implementation of the interface member or add the interface to the base-class list of the class.  
  
## Example  
 The following sample generates CS0540.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates CS0540.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>