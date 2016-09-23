---
title: "XML comment cannot be applied more than once on a partial &lt;type&gt;"
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
  - bc42314
  - vbc42314
helpviewer_keywords: 
  - BC42314
ms.assetid: 23c76238-843a-44fe-88b7-25e604ee924b
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# XML comment cannot be applied more than once on a partial &lt;type&gt;
XML comment cannot be applied more than once on a partial <type\>. XML comments for this <type\> will be ignored.  
  
 An XML comment block can appear above only one portion of a partial type.  
  
 If an XML comment block appears above more than one portion of a partial type, this warning is created for each comment block, and the top level XML comment will be ignored.  
  
 **Error ID:** BC42314  
  
### To correct this error  
  
-   Remove the extraneous comment blocks.  
  
## See Also  
 [How to: Create XML Documentation in Visual Basic](../vs140/how-to--create-xml-documentation-in-visual-basic.md)   
 [Recommended XML Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)