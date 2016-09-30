---
title: "Name of field or property being initialized must start with &#39;.&#39;"
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
  - "vbc30985"
  - "bc30985"
helpviewer_keywords: 
  - "BC30985"
ms.assetid: 4cb543e1-477c-429c-82df-541ebff08543
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Name of field or property being initialized must start with &#39;.&#39;
Each member initializer in an object initializer list specifies the name of a field or property and its initial value. The name of the field or property must be preceded by a period. For example, the following declaration assigns "Microsoft" as the initial value for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> property of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Error ID:** BC30985  
  
### To correct this error  
  
-   Prefix each member name with a period.  
  
## See Also  
 [Object Initializer](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [NOT IN BUILD: Property Procedures vs. Fields](assetId:///da1c05c1-87c7-40fa-b92c-e9c7e4d170f7)