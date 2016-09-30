---
title: "Expanded properties cannot be initialized"
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
  - "vbc36714"
  - "bc36714"
helpviewer_keywords: 
  - "BC36714"
ms.assetid: ba9408f3-e606-4749-8372-987999f405f5
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expanded properties cannot be initialized
An auto-implemented property can be initialized as part of its declaration, but an expanded property cannot be.  
  
 **Error ID:** BC36714  
  
### To correct this error  
  
-   Either use an auto-implemented property or remove the initialization from the property declaration.  
  
## Example  
 The following examples show both auto-implemented and expanded properties. Auto-implemented properties can be initialized by using assignment or a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause, but expanded properties cannot be.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Auto-Implemented Properties](../vs140/auto-implemented-properties--visual-basic-.md)   
 [How to: Create a Property](../vs140/how-to--create-a-property--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)