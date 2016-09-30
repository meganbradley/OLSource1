---
title: "&lt;param&gt; (Visual Basic)"
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
  - "param XML tag"
  - "<param> XML tag"
ms.assetid: 4e32e86f-f6f3-4301-b7fc-2f321fb54368
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;param&gt; (Visual Basic)
Defines a parameter name and description.  
  
## Syntax  
  
```  
<param name="name">description</param>  
```  
  
#### Parameters  
 `name`  
 The name of a method parameter. Enclose the name in double quotation marks (" ").  
  
 `description`  
 A description for the parameter.  
  
## Remarks  
 The `<param>` tag should be used in the comment for a method declaration to describe one of the parameters for the method.  
  
 The text for the `<param>` tag will appear in the following locations:  
  
-   Parameter Info of IntelliSense. For more information, see [Using IntelliSense](../vs140/using-intellisense.md).  
  
-   Object Browser. For more information, see [Viewing the Structure of Code](../vs140/viewing-the-structure-of-code.md).  
  
 Compile with [/doc](../vs140/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the `<param>` tag to describe the `id` parameter.  
  
 [!code[VbVbcnXmlDocComments#6](../vs140/codesnippet/VisualBasic/-param---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)