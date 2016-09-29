---
title: "Type &#39;&lt;typeName&gt;&#39; must be a value type or a type argument constrained to &#39;Structure&#39; in order to be used with &#39;Nullable&#39; or nullable modifier &#39;?&#39;"
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
  - "vbc33101"
  - "bc33101"
helpviewer_keywords: 
  - "BC33101"
ms.assetid: b3e0e4e4-87b8-4a38-a450-15233497acaa
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type &#39;&lt;typeName&gt;&#39; must be a value type or a type argument constrained to &#39;Structure&#39; in order to be used with &#39;Nullable&#39; or nullable modifier &#39;?&#39;
Only value types, including structures, can be declared nullable.  
  
```vb#  
' Valid.  
Dim n? As Integer  
Dim m As Integer?  
  
' Not valid.  
' Dim p? As Object  
' Dim q As Nullable(Of Object)  
```  
  
 **Error ID:** BC33101  
  
### To correct this error  
  
-   Remove the '?' or `Nullable`.  
  
-   Use a value data type.  
  
## See Also  
 [Nullable Value Types](../vs140/nullable-value-types--visual-basic-.md)