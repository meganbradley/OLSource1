---
title: "&lt;returns&gt; (Visual Basic)"
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
  - "returns XML tag"
  - "<returns> XML tag"
ms.assetid: a03a6469-d907-425d-882f-083187950e7e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;returns&gt; (Visual Basic)
Specifies the return value of the property or function.  
  
## Syntax  
  
```  
<returns>description</returns>  
```  
  
#### Parameters  
 `description`  
 A description of the return value.  
  
## Remarks  
 Use the `<returns>` tag in the comment for a method declaration to describe the return value.  
  
 Compile with [/doc](../vs140/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the `<returns>` tag to explain what the `DoesRecordExist` function returns.  
  
 [!code[VbVbcnXmlDocComments#6](../vs140/codesnippet/VisualBasic/-returns---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)