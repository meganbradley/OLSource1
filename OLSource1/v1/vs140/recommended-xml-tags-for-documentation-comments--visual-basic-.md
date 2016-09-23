---
title: "Recommended XML Tags for Documentation Comments (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vb.XmlDocComment
dev_langs: 
  - VB
helpviewer_keywords: 
  - tags, XML
  - XML comments, recommended tags [Visual Basic]
  - comments, recommended XML tags
ms.assetid: 294e0736-ff1e-498e-af83-6db71ed41a72
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Recommended XML Tags for Documentation Comments (Visual Basic)
The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler can process documentation comments in your code to an XML file. You can use additional tools to process the XML file into documentation.  
  
 XML comments are allowed on code constructs such as types and type members. For partial types, only one part of the type can have XML comments, although there is no restriction on commenting its members.  
  
> [!NOTE]
>  Documentation comments cannot be applied to namespaces. The reason is that one namespace can span several assemblies, and not all assemblies have to be loaded at the same time.  
  
 The compiler processes any tag that is valid XML. The following tags provide commonly used functionality in user documentation.  
  
||||  
|-|-|-|  
|[<c\>](../vs140/-c---visual-basic-.md)|[<code\>](../vs140/-code---visual-basic-.md)|[<example\>](../vs140/-example---visual-basic-.md)|  
|[<exception\>](../vs140/-exception---visual-basic-.md) <sup>1</sup>|[<include\>](../vs140/-include---visual-basic-.md) <sup>1</sup>|[<list\>](../vs140/-list---visual-basic-.md)|  
|[<para\>](../vs140/-para---visual-basic-.md)|[<param\>](../vs140/-param---visual-basic-.md) <sup>1</sup>|[<paramref\>](../vs140/-paramref---visual-basic-.md)|  
|[<permission\>](../vs140/-permission---visual-basic-.md) <sup>1</sup>|[<remarks\>](../vs140/-remarks---visual-basic-.md)|[<returns\>](../vs140/-returns---visual-basic-.md)|  
|[<see\>](../vs140/-see---visual-basic-.md) <sup>1</sup>|[<seealso\>](../vs140/-seealso---visual-basic-.md) <sup>1</sup>|[<summary\>](../vs140/-summary---visual-basic-.md)|  
|[<typeparam\>](../vs140/-typeparam---visual-basic-.md) <sup>1</sup>|[<value\>](../vs140/-value---visual-basic-.md)||  
  
 (<sup>1</sup> The compiler verifies syntax.)  
  
> [!NOTE]
>  If you want angle brackets to appear in the text of a documentation comment, use `<` and `>`. For example, the string `"<text in angle brackets>"` will appear as `<text in angle``brackets>`.  
  
## See Also  
 [Documenting Your Code with XML (Visual Basic)](../vs140/documenting-your-code-with-xml--visual-basic-.md)   
 [/doc](../vs140/-doc.md)   
 [How to: Create XML Documentation in Visual Basic](../vs140/how-to--create-xml-documentation-in-visual-basic.md)