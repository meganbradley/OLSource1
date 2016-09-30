---
title: "Namespace declaration with prefix cannot have an empty value in XML literals"
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
  - "bc31184"
  - "vbc31184"
helpviewer_keywords: 
  - "BC31184"
ms.assetid: dde656b4-df3b-4a2e-8871-4e14832ca778
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Namespace declaration with prefix cannot have an empty value in XML literals
An XML namespace declaration in an XML literal does not include a namespace value. For example, the following code will cause this error:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Error ID:** BC31184  
  
### To correct this error  
  
-   Include a valid namespace in the XML namespace declaration, or remove the XML namespace declaration from the XML literal.  
  
     As an alternative, you can use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement to identify a namespace prefix for the empty namespace. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)   
 [Imports Statement (XML Namespace)](../vs140/imports-statement--xml-namespace-.md)