---
title: "XML elements cannot be selected from type &#39;type&#39;"
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
  - "vbc36807"
  - "bc36807"
helpviewer_keywords: 
  - "BC36807"
ms.assetid: 01c19899-2b44-41e9-a99c-35edfa0deaf1
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML elements cannot be selected from type &#39;type&#39;
An XML child element has been referenced for an object that is not of type <xref:System.Xml.Linq.XElement*>, <xref:System.Xml.Linq.XDocument*>, or `IEnumerable(Of XElement)`. For more information, see [XML Child Axis Property](../vs140/xml-child-axis-property--visual-basic-.md).  
  
```vb#  
' Generates an error.  
Dim var = "sample text".<child>  
```  
  
 **Error ID:** BC36807  
  
### To correct this error  
  
-   Ensure that the object of which you are referencing an attribute is strongly typed as <xref:System.Xml.Linq.XElement*>, <xref:System.Xml.Linq.XDocument*>, or `IEnumerable(Of XElement)`. Following is an example:  
  
    ```vb#  
    Dim elem As XElement = <root>  
                             <child />  
                           </root>  
    Dim var = elem.<child>  
    ```  
  
## See Also  
 [XML Child Axis Property](../vs140/xml-child-axis-property--visual-basic-.md)   
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)