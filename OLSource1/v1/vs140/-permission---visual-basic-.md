---
title: "&lt;permission&gt; (Visual Basic)"
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
  - "<permission> XML tag"
  - "permission XML tag"
ms.assetid: 0edf0500-5cd7-49c0-9255-64c48f972b77
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;permission&gt; (Visual Basic)
Specifies a required permission for the member.  
  
## Syntax  
  
```  
<permission cref="member">description</permission>  
```  
  
#### Parameters  
 `member`  
 A reference to a member or field that is available to be called from the current compilation environment. The compiler checks that the given code element exists and translates `member` to the canonical element name in the output XML. Enclose `member` in quotation marks (" ").  
  
 `description`  
 A description of the access to the member.  
  
## Remarks  
 Use the `<permission>` tag to document the access of a member. Use the \<xref:System.Security.PermissionSet*> class to specify access to a member.  
  
 Compile with [/doc](../vs140/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the `<permission>` tag to describe that the \<xref:System.Security.Permissions.FileIOPermission*> is required by the `ReadFile` method.  
  
 [!code[VbVbcnXmlDocComments#7](../vs140/codesnippet/VisualBasic/-permission---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)