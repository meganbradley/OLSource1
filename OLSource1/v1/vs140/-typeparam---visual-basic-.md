---
title: "&lt;typeparam&gt; (Visual Basic)"
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
  - "typeparam XML tag"
  - "<typeparam> XML tag"
ms.assetid: 1bb5ba78-f060-478c-905c-77a2e43639af
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;typeparam&gt; (Visual Basic)
Defines a type parameter name and description.  
  
## Syntax  
  
```  
<typeparam name="name">description</typeparam>  
```  
  
#### Parameters  
 `name`  
 The name of the type parameter. Enclose the name in double quotation marks (" ").  
  
 `description`  
 A description of the type parameter.  
  
## Remarks  
 Use the `<typeparam>` tag in the comment for a generic type or generic member declaration to describe one of the type parameters.  
  
 Compile with [/doc](../vs140/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the `<typeparam>` tag to describe the `id` parameter.  
  
 [!code[VbVbcnXmlDocComments#8](../vs140/codesnippet/VisualBasic/-typeparam---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended XML Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)