---
title: "Compiler Error CS0592"
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
  - "CS0592"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0592"
ms.assetid: 805c8cf0-eca2-4040-badd-a9c09ab5c747
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0592
Attribute 'attribute' is not valid on this declaration type. It is valid on 'type' declarations only.  
  
 When you define an attribute, you define what constructs it can be applied to by specifying an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value. In the following example, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute can be applied to interfaces only, because the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute specifies <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The error is generated because the attribute is applied to a class (class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
## Example  
 The following sample generates CS0592:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Attributes (C# Programming Guide)](../vs140/attributes--csharp-and-visual-basic-.md)