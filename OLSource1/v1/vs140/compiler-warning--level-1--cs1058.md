---
title: "Compiler Warning (level 1) CS1058"
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
  - "CS1058"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1058"
ms.assetid: ed50590c-f130-47c3-976d-322a6c8f996d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1058
A previous catch clause already catches all exceptions. All exceptions thrown will be wrapped in a System.Runtime.CompilerServices.RuntimeWrappedException  
  
 This attribute causes CS1058 if a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block has no specified exception type after a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block. The warning advises that the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block will not catch any exceptions.  
  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block after a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block can catch non-CLS exceptions if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to false in the AssemblyInfo.cs file: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If this attribute is not set explicitly to false, all thrown non-CLS exceptions are wrapped as Exceptions and the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block catches them. For more information, see [How To: Catch a non-CLS Exception](../vs140/how-to--catch-a-non-cls-exception.md).  
  
## Example  
 The following example generates CS1058.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>