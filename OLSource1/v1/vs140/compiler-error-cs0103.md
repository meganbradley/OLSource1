---
title: "Compiler Error CS0103"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0103"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0103"
ms.assetid: fd1f2104-a945-4dba-8137-8ef869826062
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0103
The name 'identifier' does not exist in the current context  
  
 An attempt was made to use a name that does not exist in the class, [namespace](../vs140/namespace--csharp-reference-.md), or scope. Check the spelling of the name and check your using directives and assembly references to make sure that the name that you are trying to use is available.  
  
 This error frequently occurs if you declare a variable in a loop or a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block and then attempt to access it from an enclosing code block or a separate code block, as shown in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following example resolves the error.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>