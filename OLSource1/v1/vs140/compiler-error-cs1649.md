---
title: "Compiler Error CS1649"
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
  - "CS1649"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1649"
ms.assetid: 6355c7f2-157c-441d-8925-500062988636
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1649
Members of readonly field 'identifier' cannot be passed ref or out (except in a constructor)  
  
 This error occurs if you pass a variable to a function that is a member of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> field as a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> argument. Since <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameters may be modified by the function, this is not allowed. To resolve this error, remove the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword on the field, or do not pass the members of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field to the function. For example, you might try creating a temporary variable which can be modifed and passing the temporary as a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument, as shown in the following example.  
  
## Example  
 The following sample generates CS1649:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>