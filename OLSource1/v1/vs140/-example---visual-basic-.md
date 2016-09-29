---
title: "&lt;example&gt; (Visual Basic)"
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
  - "example XML tag"
  - "<example> XML tag"
ms.assetid: 90eeda1c-3fc4-427c-879c-5046d265a97c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;example&gt; (Visual Basic)
Specifies an example for the member.  
  
## Syntax  
  
```  
<example>description</example>  
```  
  
#### Parameters  
 `description`  
 A description of the code sample.  
  
## Remarks  
 The `<example>` tag lets you specify an example of how to use a method or other library member. This commonly involves using the [<code\> (Visual Basic)](../vs140/-code---visual-basic-.md) tag.  
  
 Compile with [/doc](../vs140/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the `<example>` tag to include an example for using the `ID` field.  
  
 [!code[VbVbcnXmlDocComments#2](../vs140/codesnippet/VisualBasic/-example---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)