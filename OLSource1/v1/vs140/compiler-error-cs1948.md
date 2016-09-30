---
title: "Compiler Error CS1948"
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
  - "CS1948"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1948"
ms.assetid: 3dac3abe-0edd-4ee1-8fb1-bc597ea63e1f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1948
The range variable 'name' cannot have the same name as a method type parameter  
  
 The same declaration space cannot contain two declarations of the same identifier.  
  
### To correct this error  
  
1.  Change the name of the range variable or the type parameter.  
  
## Example  
 The following example generates CS1948 because the identifier <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is used for the range variable and for the type parameter on method <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>