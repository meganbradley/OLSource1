---
title: "Compiler Error CS0746"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0746"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0746"
ms.assetid: 36baf7f2-b092-422c-ab53-95154bfceb0a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0746
Invalid anonymous type member declarator. Anonymous type members must be declared with a member assignment, simple name or member access.  
  
 An anonymous type must be declared with a member assignment, simple name, or member access.  
  
### To correct this error  
  
1.  Ensure that your declaration uses only member assignment, simple names, or member access expressions.  
  
## Example  
 The following code generates CS0746 in the declaration of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The following declarations show two of the correct ways to declare an anonymous type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md)