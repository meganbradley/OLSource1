---
title: "Compiler Error CS0507"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0507"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0507"
ms.assetid: ddbdb94c-38c3-4022-8d1c-68971d398b87
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0507
'function1' : cannot change access modifiers when overriding 'access' inherited member 'function2'  
  
 An attempt was made to change the access specification in a method override.  
  
## Example  
 The following sample generates CS0507.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 CS0507 can also occur if a class attempts to override a method marked as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> defined in referenced metadata. In this situation, the overriding method should be marked as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample generates CS0507.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>