---
title: "Compiler Warning (level 1) C4944"
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
  - "C4944"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4944"
ms.assetid: e2905eb1-2e3b-4fab-a48b-c0cae0fd997f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4944
'symbol' : cannot import symbol from 'assembly1': as 'symbol' already exists in the current scope  
  
 A symbol was defined in a source code file and then a #using statement referenced an assembly that also defined the symbol. The symbol in the assembly is ignored.  
  
## Example  
 The following sample creates a component with a type called ClassA.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following samples generate C4944.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>