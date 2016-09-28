---
title: "&lt;value&gt; (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "<value> XML tag"
  - "value XML tag"
ms.assetid: 0b84b02e-9e6d-41b5-a926-0d5dc76dacb5
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;value&gt; (Visual Basic)
Specifies the description of a property.  
  
## Syntax  
  
```  
<value>property-description</value>  
```  
  
#### Parameters  
 `property-description`  
 A description for the property.  
  
## Remarks  
 Use the `<value>` tag to describe a property. Note that when you add a property using the code wizard in the Visual Studio development environment, it will add a [<summary\> (Visual Basic)](../vs140/-summary---visual-basic-.md) tag for the new property. You should then manually add a `<value>` tag to describe the value that the property represents.  
  
 Compile with [/doc](../vs140/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the `<value>` tag to describe what value the `Counter` property holds.  
  
 [!code[VbVbcnXmlDocComments#1](../vs140/codesnippet/VisualBasic/-value---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended XML Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)