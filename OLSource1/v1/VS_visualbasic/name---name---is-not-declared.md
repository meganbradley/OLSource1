---
title: "Name &#39;&lt;name&gt;&#39; is not declared"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc30451"
  - "vbc30451"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30451"
ms.assetid: 765f099b-e21e-47c6-a906-a065444e56b3
caps.latest.revision: 11
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
# Name &#39;&lt;name&gt;&#39; is not declared
A statement refers to a programming element, but the compiler cannot find an element with that exact name.  
  
 **Error ID:** BC30451  
  
### To correct this error  
  
1.  Check the spelling of the name in the referring statement. [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] is case-insensitive, but any other variation in the spelling is regarded as a completely different name. Note that the underscore (`_`) is part of the name and therefore part of the spelling.  
  
2.  Check that you have the member access operator (`.`) between an object and its member. For example, if you have a \<xref:System.Windows.Forms.TextBox> control named `TextBox1`, to access its \<xref:System.Windows.Forms.TextBoxBase.Text*> property you should type `TextBox1.Text`. If instead you type `TextBox1Text`, you have created a different name.  
  
3.  If the spelling is correct and the syntax of any object member access is correct, verify that the element has been declared. For more information, see [Declared Elements](../VS_visualbasic/declared-elements-in-visual-basic.md).  
  
4.  If the programming element has been declared, check that it is in scope. If the referring statement is outside the region declaring the programming element, you might need to qualify the element name. For more information, see [Scope in Visual Basic](../VS_visualbasic/scope-in-visual-basic.md).  
  
## See Also  
 [Declarations and Constants Summary](../VS_visualbasic/declarations-and-constants-summary--visual-basic-.md)   
 [Visual Basic Naming Conventions](../VS_visualbasic/visual-basic-naming-conventions.md)   
 [Declared Element Names](../VS_visualbasic/declared-element-names--visual-basic-.md)   
 [References to Declared Elements](../VS_visualbasic/references-to-declared-elements--visual-basic-.md)