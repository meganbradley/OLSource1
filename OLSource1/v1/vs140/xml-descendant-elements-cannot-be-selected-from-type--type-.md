---
title: "XML descendant elements cannot be selected from type &#39;type&#39;"
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
  - "vbc36809"
  - "bc36809"
helpviewer_keywords: 
  - "BC36809"
ms.assetid: 560a3370-f24d-4ca3-93b1-39aabe13c238
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML descendant elements cannot be selected from type &#39;type&#39;
An XML descendant has been referenced for an object that is not of type <xref:System.Xml.Linq.XElement*>, <xref:System.Xml.Linq.XDocument*>, or `IEnumerable(Of XElement)`. For more information, see [XML Descendant Axis Property](../vs140/xml-descendant-axis-property--visual-basic-.md).  
  
```vb#  
' Generates an error.  
Dim var = "sample text"...<childElement>  
```  
  
 **Error ID:** BC36809  
  
### To correct this error  
  
-   Ensure that the object of which you are referencing a descendant element is strongly typed as <xref:System.Xml.Linq.XElement*>, <xref:System.Xml.Linq.XDocument*>, or `IEnumerable(Of XElement)`. Following is an example:  
  
    ```vb#  
    Dim elem As XElement = <root>  
                            <child />  
                           </root>  
    Dim var = elem...<child>  
    ```  
  
## See Also  
 [XML Descendant Axis Property](../vs140/xml-descendant-axis-property--visual-basic-.md)   
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)