---
title: "&lt;exception&gt; (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "<exception> XML tag"
  - "exception XML tag"
ms.assetid: c0517549-171e-4dae-ab88-a9c1700b6eee
caps.latest.revision: 9
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# &lt;exception&gt; (Visual Basic)
Specifies which exceptions can be thrown.  
  
## Syntax  
  
```  
<exception cref="member">description</exception>  
```  
  
#### Parameters  
 `member`  
 A reference to an exception that is available from the current compilation environment. The compiler checks that the given exception exists and translates `member` to the canonical element name in the output XML. `member` must appear within double quotation marks (" ").  
  
 `description`  
 A description.  
  
## Remarks  
 Use the `<exception>` tag to specify which exceptions can be thrown. This tag is applied to a method definition.  
  
 Compile with [/doc](../VS_visualbasic/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the `<exception>` tag to describe an exception that the `IntDivide` function can throw.  
  
 [!code[VbVbcnXmlDocComments#3](../VS_visualbasic/codesnippet/VisualBasic/-exception---visual-basic-_1.vb)]  
  
## See Also  
 [XML Comment Tags](../VS_visualbasic/recommended-xml-tags-for-documentation-comments--visual-basic-.md)