---
title: "Namespace declaration must start with &#39;xmlns&#39;"
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
  - "bc31187"
  - "vbc31187"
helpviewer_keywords: 
  - "BC31187"
ms.assetid: 64c6a033-7cdc-48a0-bff0-bdd045cb13ad
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Namespace declaration must start with &#39;xmlns&#39;
An XML namespace has been specified without the required `xmlns` identifier. The `xmlns` identifier must contain only lowercase characters.  
  
 **Error ID:** BC31187  
  
### To correct this error  
  
-   Use the `xmlns` identifier when you declare an XML namespace. Following is an example:  
  
    ```vb#  
    Imports <xmlns:ns="http://SampleNamespace">  
    ```  
  
## See Also  
 [Imports Statement (XML Namespace Prefix)](../vs140/imports-statement--xml-namespace-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)