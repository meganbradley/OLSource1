---
title: "Attribute &#39;&lt;attributename&gt;&#39; cannot be applied multiple times"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc30663"
  - "vbc30663"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30663"
ms.assetid: 3760e7ff-7238-40a1-8676-77d858a64fc0
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Attribute &#39;&lt;attributename&gt;&#39; cannot be applied multiple times
The attribute can only be applied once. The `AttributeUsage` attribute determines whether an attribute can be applied more than once.  
  
 **Error ID:** BC30663  
  
### To correct this error  
  
1.  Make sure the attribute is only applied once.  
  
2.  If you are using custom attributes you developed, consider changing their `AttributeUsage` attribute to allow multiple attribute usage, as with the following example.  
  
    ```  
    <AttributeUsage(AllowMultiple := True)>  
    ```  
  
## See Also  
 <xref:System.AttributeUsageAttribute*>   
 [Creating Custom Attributes (C# and Visual Basic)](../vs140/creating-custom-attributes--csharp-and-visual-basic-.md)   
 [AttributeUsage (C# and Visual Basic)](../vs140/attributeusage--csharp-and-visual-basic-.md)