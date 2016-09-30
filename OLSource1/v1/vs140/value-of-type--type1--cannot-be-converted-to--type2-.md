---
title: "Value of type &#39;type1&#39; cannot be converted to &#39;type2&#39;"
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
  - "vbc31194"
  - "bc31194"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC31194"
ms.assetid: 03d50c31-addd-4c90-9c53-725b84f9782e
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Value of type &#39;type1&#39; cannot be converted to &#39;type2&#39;
Value of type 'type1' cannot be converted to 'type2'. You can use the 'Value' property to get the string value of the first element of '\<parentElement>'.  
  
 An attempt has been made to implicitly cast an XML literal to a specific type. The XML literal cannot be implicitly cast to the specified type.  
  
 **Error ID:** BC31194  
  
### To correct this error  
  
-   Use the `Value` property of the XML literal to reference its value as a `String`. Use the `CType` function, another type conversion function, or the \<xref:System.Convert*> class to cast the value as the specified type.  
  
## See Also  
 \<xref:System.Convert*>   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)