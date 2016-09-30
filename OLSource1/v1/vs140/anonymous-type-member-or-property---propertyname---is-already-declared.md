---
title: "Anonymous type member or property &#39;&lt;propertyname&gt;&#39; is already declared"
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
  - "bc36547"
  - "vbc36547"
helpviewer_keywords: 
  - "BC36547"
ms.assetid: 4c60d24a-62d7-404a-bc35-d1a1d9c9f851
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Anonymous type member or property &#39;&lt;propertyname&gt;&#39; is already declared
A property name can be established only once in the declaration of an anonymous type. For example, the following declarations are not valid:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Error ID:** BC36547  
  
### To correct this error  
  
-   Choose a different name for one of the properties.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   Provide new names for the variables or property names from which you are inferring names and values.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)   
 [How to: Infer Property Names and Types in Anonymous Type Declarations](../vs140/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-.md)