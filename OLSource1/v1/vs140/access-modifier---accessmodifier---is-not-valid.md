---
title: "Access modifier &#39;&lt;accessmodifier&gt;&#39; is not valid"
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
  - "bc31100"
  - "vbc31100"
helpviewer_keywords: 
  - "BC31100"
ms.assetid: 1cd71acc-0b54-4f64-8d61-75b272d293cb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Access modifier &#39;&lt;accessmodifier&gt;&#39; is not valid
A [Get Statement](../vs140/get-statement.md) or [Set Statement (Visual Basic)](../vs140/set-statement--visual-basic-.md) specifies an access level that is less restrictive than that specified for the containing property.  
  
 You can always specify an access level for the property. In addition, you can specify a different access level for at most one of its property procedures (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>), provided it is more restrictive than the property's access level. For example, if the property is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, you can specify <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for a property procedure, but not <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You cannot specify access levels for both of the property procedures.  
  
 **Error ID:** BC31100  
  
### To correct this error  
  
-   Make the access level for the property procedure more restrictive than for the property, or remove the access modifier entirely.  
  
-   Declare the less restrictive access level in the [Property Statement](../vs140/property-statement.md), and declare the more restrictive access level in one of the property procedures.  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [How to: Declare a Property with Mixed Access Levels](../vs140/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)