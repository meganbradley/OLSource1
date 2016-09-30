---
title: "Compiler Error CS1642"
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
  - "CS1642"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1642"
ms.assetid: 2efeedf1-1839-485d-8b8c-9045df1951f0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1642
Fixed size buffer fields may only be members of structs.  
  
 This error occurs if you use a fixed size buffer field in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, instead of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. To resolve this error, change the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or declare the field as an ordinary array.  
  
## Example  
 The following sample generates CS1642.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>