---
title: "Names of Declared XML Elements and Attributes (Visual Basic)"
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
  - "declarations [XML in Visual Basic]"
  - "element names [XML in Visual Basic]"
  - "names in XML literals"
  - "attribute names [XML in Visual Basic]"
  - "XML literals [Visual Basic], element names"
ms.assetid: cc110118-b6cf-4ff9-a4e4-6233c90c9fbf
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Names of Declared XML Elements and Attributes (Visual Basic)
This topic provides [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] guidelines for naming XML elements and attributes in XML literals.  In an XML literal, you can specify a local name or a qualified name. A qualified name consists of an XML namespace prefix, a colon, and a local name. For more information about XML namespace prefixes, see [XML Element Literal](../vs140/xml-element-literal--visual-basic-.md).  
  
## Rules  
 A local name of an element or attribute in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] must adhere to the following rules.  
  
-   It can begin with a namespace. It must begin with an alphabetical character or an underscore (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>).  
  
-   It must contain only alphabetical characters, decimal digits, underscores, periods (.), and hyphens (-).  
  
-   It must not be more than 1,024 characters long.  
  
-   Colons that appear in names indicate namespace demarcation. Therefore, you can use colons only to specify an XML namespace for a particular name.  
  
 In addition, you should adhere to the following guideline.  
  
-   The XML 1.0 specification reserves all names starting with the string "xml", of any capitalization variation. Therefore, do not use those names for your element and attribute names.  
  
### Name Length Guidelines  
 As a practical matter, a name should be as short as possible while still clearly identifying the nature of the element. This improves the readability of your code and reduces line length and source-file size.  
  
 However, your name should not be so short that it does not adequately describe the element or how your code uses it. This is important for the readability of your code. If somebody else is trying to understand it, or if you yourself are looking at it a long time after you wrote it, appropriate element names can save time.  
  
## Case Sensitivity in Names  
 XML element names are case sensitive. This means that when the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler compares two names that differ in alphabetical case only, it interprets them as different names. For example, it interprets <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> as referring to separate elements.  
  
## XML Namespaces  
 When creating an XML element literal, you can specify the XML namespace prefix for the element name. For more information, see [XML Element Literal](../vs140/xml-element-literal--visual-basic-.md).  
  
## See Also  
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)   
 [XML Element Literal](../vs140/xml-element-literal--visual-basic-.md)