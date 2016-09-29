---
title: "Recommended XML Tags for Documentation Comments (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.XmlDocComment"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "tags, XML"
  - "XML comments, recommended tags [Visual Basic]"
  - "comments, recommended XML tags"
ms.assetid: 294e0736-ff1e-498e-af83-6db71ed41a72
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Recommended XML Tags for Documentation Comments (Visual Basic)
The [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] compiler can process documentation comments in your code to an XML file. You can use additional tools to process the XML file into documentation.  
  
 XML comments are allowed on code constructs such as types and type members. For partial types, only one part of the type can have XML comments, although there is no restriction on commenting its members.  
  
> [!NOTE]
>  Documentation comments cannot be applied to namespaces. The reason is that one namespace can span several assemblies, and not all assemblies have to be loaded at the same time.  
  
 The compiler processes any tag that is valid XML. The following tags provide commonly used functionality in user documentation.  
  
||||  
|-|-|-|  
|[<c\>](../VS_csharp/-c---visual-basic-.md)|[<code\>](../VS_csharp/-code---visual-basic-.md)|[<example\>](../VS_csharp/-example---visual-basic-.md)|  
|[<exception\>](../VS_csharp/-exception---visual-basic-.md) <sup>1</sup>|[<include\>](../VS_csharp/-include---visual-basic-.md) <sup>1</sup>|[<list\>](../VS_csharp/-list---visual-basic-.md)|  
|[<para\>](../VS_csharp/-para---visual-basic-.md)|[<param\>](../VS_csharp/-param---visual-basic-.md) <sup>1</sup>|[<paramref\>](../VS_csharp/-paramref---visual-basic-.md)|  
|[<permission\>](../VS_csharp/-permission---visual-basic-.md) <sup>1</sup>|[<remarks\>](../VS_csharp/-remarks---visual-basic-.md)|[<returns\>](../VS_csharp/-returns---visual-basic-.md)|  
|[<see\>](../VS_csharp/-see---visual-basic-.md) <sup>1</sup>|[<seealso\>](../VS_csharp/-seealso---visual-basic-.md) <sup>1</sup>|[<summary\>](../VS_csharp/-summary---visual-basic-.md)|  
|[<typeparam\>](../VS_csharp/-typeparam---visual-basic-.md) <sup>1</sup>|[<value\>](../VS_csharp/-value---visual-basic-.md)||  
  
 (<sup>1</sup> The compiler verifies syntax.)  
  
> [!NOTE]
>  If you want angle brackets to appear in the text of a documentation comment, use `<` and `>`. For example, the string `"<text in angle brackets>"` will appear as `<text in angle``brackets>`.  
  
## See Also  
 [Documenting Your Code with XML (Visual Basic)](../VS_csharp/documenting-your-code-with-xml--visual-basic-.md)   
 [/doc](../VS_csharp/-doc.md)   
 [How to: Create XML Documentation in Visual Basic](../VS_csharp/how-to--create-xml-documentation-in-visual-basic.md)