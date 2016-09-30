---
title: "A nullable type cannot be inferred for variable &#39;&lt;variablename&gt;&#39;"
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
  - "bc36628"
  - "vbc36628"
helpviewer_keywords: 
  - "BC36628"
ms.assetid: 3e92ae19-6a19-4b0b-9dd9-fba31cdb85a6
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A nullable type cannot be inferred for variable &#39;&lt;variablename&gt;&#39;
A nullable type cannot be inferred from a reference type, such as an array, a class, or a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. The value from which the data type is inferred must be a value type. The following code illustrates this error.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Error ID:** BC36628  
  
### To correct this error  
  
-   Remove the nullable designation.  
  
## See Also  
 [Nullable Value Types](../vs140/nullable-value-types--visual-basic-.md)