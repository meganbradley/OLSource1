---
title: "Name &#39;&lt;name&gt;&#39; is either not declared or not in the current scope"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc36610"
  - "bc36610"
helpviewer_keywords: 
  - "BC36610"
ms.assetid: e66a4b8a-9252-42ae-a30d-341fad4f74be
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Name &#39;&lt;name&gt;&#39; is either not declared or not in the current scope
A LINQ query refers to a programming element, but the compiler cannot find an element that has that exact name.  
  
 **Error ID:** BC36610  
  
### To correct this error  
  
1.  Check the spelling of the name in the referring statement. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] is case-insensitive, but any other variation in the spelling constitutes a different name. Note that the underscore (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>) is part of the name and therefore part of the spelling.  
  
2.  Verify that the programming element is in scope. If the referring statement is outside the region declaring the programming element, you might have to qualify the element name. For more information, see [Scope in Visual Basic](../vs140/scope-in-visual-basic.md).  
  
3.  Ensure that you have the member access operator (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) between an object and its member. For example, if you have a \<xref:System.Windows.Forms.TextBox*> control named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, to access its \<xref:System.Windows.Forms.TextBoxBase.Text*> property you should type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If instead you type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, you have created a different name.  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Visual Basic Naming Conventions](../vs140/visual-basic-naming-conventions.md)   
 [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md)