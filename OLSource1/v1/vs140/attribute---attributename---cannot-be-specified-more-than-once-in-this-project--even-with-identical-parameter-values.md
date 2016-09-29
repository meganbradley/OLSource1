---
title: "Attribute &#39;&lt;attributename&gt;&#39; cannot be specified more than once in this project, even with identical parameter values"
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
  - "bc41000"
  - "vbc41000"
helpviewer_keywords: 
  - "BC41000"
ms.assetid: 7e846177-7b89-44da-8f17-cdc8606ef148
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Attribute &#39;&lt;attributename&gt;&#39; cannot be specified more than once in this project, even with identical parameter values
A custom attribute is specified more than once on the same programming element, but an <xref:System.AttributeUsageAttribute*> is applied to the custom attribute, and its <xref:System.AttributeUsageAttribute.AllowMultiple*> property is set to `False`. <xref:System.AttributeUsageAttribute.AllowMultiple*> controls whether the attribute is multi-use.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC41000  
  
### To correct this error  
  
-   Remove the extra specification of the custom attribute, or set <xref:System.AttributeUsageAttribute.AllowMultiple*> to `True` in the <xref:System.AttributeUsageAttribute*> applied to it.  
  
## See Also  
 <xref:System.AttributeUsageAttribute*>   
 <xref:System.AttributeUsageAttribute.AllowMultiple*>   
 [NOT IN BUILD: Application of Attributes](assetId:///2b1703ed-4437-49b3-bc0b-568094324f47)