---
title: "Cannot convert &#39;type1&#39; to &#39;type2&#39;"
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
  - "bc31193"
  - "vbc31193"
helpviewer_keywords: 
  - "BC31193"
ms.assetid: f25a9f5b-7741-4cd6-b85a-b19037ed8e49
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Cannot convert &#39;type1&#39; to &#39;type2&#39;
Cannot convert 'type1' to 'type2'. You can use the 'Value' property to get the string value of the first element of 'parentElement'.  
  
 An attempt has been made to implicitly cast an XML literal to a specific type. The XML literal cannot be implicitly cast to the specified type.  
  
 **Error ID:** BC31193  
  
### To correct this error  
  
-   Use the `Value` property of the XML literal to reference its value as a `String`. Use the `CType` function, another type conversion function, or the <xref:System.Convert*> class to cast the value as the specified type.  
  
## See Also  
 <xref:System.Convert*>   
 [Accessing XML in Visual Basic](../vs140/accessing-xml-in-visual-basic.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)