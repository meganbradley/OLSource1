---
title: "Compiler Error CS1614"
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
  - "CS1614"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1614"
ms.assetid: 787eef18-74a6-49d9-9f34-f0881aca8dff
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1614
'name' is ambiguous; between 'attribute1' and 'attribute2'. use either '@attribute' or 'attributeAttribute'  
  
 The compiler has encountered an ambiguous attribute specification.  
  
 For convenience, the C# compiler allows you to specify **ExampleAttribute** as just <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. However, ambiguity arises if an attribute class named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> exists along with **ExampleAttribute**, because the compiler cannot tell if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> refers to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute or the **ExampleAttribute** attribute. To clarify, use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for **ExampleAttribute**.  
  
 The following sample generates CS1614:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>