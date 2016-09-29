---
title: "XML attributes cannot be selected from type &#39;type&#39;"
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
  - "bc36808"
  - "vbc36808"
helpviewer_keywords: 
  - "BC36808"
ms.assetid: 76b2605c-3d9b-4e56-ba3f-99c60c668290
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML attributes cannot be selected from type &#39;type&#39;
An XML attribute has been referenced for an object that is not of type <xref:System.Xml.Linq.XElement*> or `IEnumerable(Of XElement)`. For more information, see [XML Attribute Axis Property](../vs140/xml-attribute-axis-property--visual-basic-.md).  
  
```vb#  
' Generates an error.  
Dim var = "sample text".@attr  
```  
  
 **Error ID:** BC36808  
  
### To correct this error  
  
-   Ensure that the object of which you are referencing an attribute is strongly typed as <xref:System.Xml.Linq.XElement*> or `IEnumerable(Of XElement)`. Following is an example:  
  
    ```vb#  
    Dim elem As XElement = <root attr="value"/>  
    Dim var = elem.@attr  
    ```  
  
## See Also  
 [XML Attribute Axis Property](../vs140/xml-attribute-axis-property--visual-basic-.md)   
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)