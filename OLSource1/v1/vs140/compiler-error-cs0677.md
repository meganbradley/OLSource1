---
title: "Compiler Error CS0677"
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
  - "CS0677"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0677"
ms.assetid: 6a4a3703-9b44-4c4f-a564-8b437b1cb6b8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0677
'variable': a volatile field cannot be of the type 'type'  
  
 Fields declared with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword must be one of the following types:  
  
-   Any reference type  
  
-   Any pointer type (in an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> context)  
  
-   The types <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, **byte**, **short**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, **float**, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
-   Enum types based on any of the above types  
  
 The following sample generates CS0677:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>