---
title: "Compiler Warning (level 3) CS0282"
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
  - "CS0282"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0282"
ms.assetid: fd4cda5d-81c7-40e3-8424-c938b3447356
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) CS0282
There is no defined ordering between fields in multiple declarations of partial class or struct 'type'. To specify an ordering, all instance fields must be in the same declaration.  
  
 To resolve this error, put all member variables in a single partial class definition.  
  
 A common way to get this error is by having a partial <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> defined in more than one place, with some of the member variables in one definition, and some in another.  
  
 The following code generates CS0282.  
  
## Example  
 This code contains one description of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Compile these two modules together in a single step by means of the command:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This code contains a conflicting description of the same <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>