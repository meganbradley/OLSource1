---
title: "&lt;summary&gt; (Visual Basic)"
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
  - "<summary> XML tag"
  - "summary XML tag"
ms.assetid: 861c847d-dd94-478a-aa23-bf4899cdc848
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;summary&gt; (Visual Basic)
Specifies the summary of the member.  
  
## Syntax  
  
```  
<summary>description</summary>  
```  
  
#### Parameters  
 `description`  
 A summary of the object.  
  
## Remarks  
 Use the `<summary>` tag to describe a type or a type member. Use [<remarks\> (Visual Basic)](../vs140/-remarks---visual-basic-.md) to add supplemental information to a type description.  
  
 The text for the `<summary>` tag is the only source of information about the type in IntelliSense, and is also displayed in the Object Browser. For information about the Object Browser, see [Viewing the Structure of Code](../vs140/viewing-the-structure-of-code.md).  
  
 Compile with [/doc](../vs140/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the `<summary>` tag to describe the `ResetCounter` method and `Counter` property.  
  
 [!code[VbVbcnXmlDocComments#1](../vs140/codesnippet/VisualBasic/-summary---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended XML Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)