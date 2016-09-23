---
title: "XML comment block must immediately precede the language element to which it applies"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc42300
  - bc42300
helpviewer_keywords: 
  - BC42300
ms.assetid: f9f7d1da-a723-4237-bd78-6db7ed8bc4aa
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# XML comment block must immediately precede the language element to which it applies
XML comment block must immediately precede the language element to which it applies. XML comment will be ignored.  
  
 This error will also occur if a tag is misplaced or otherwise malformed.  
  
 **Error ID:** BC42300  
  
### To correct this error  
  
1.  Move the comment block to precede the language element to which it applies. Make sure that extraneous characters have not been accidentally inserted before the initial tag.  
  
2.  Make sure the tag is valid.  
  
## See Also  
 [How to: Create XML Documentation in Visual Basic](../vs140/how-to--create-xml-documentation-in-visual-basic.md)   
 [Recommended XML Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)