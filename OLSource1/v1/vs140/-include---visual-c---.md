---
title: "&lt;include&gt; (Visual C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "include"
  - "<include>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "include C++ XML tag"
  - "<include> C++ XML tag"
ms.assetid: 392a3e61-0371-4617-8362-446650876ce3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;include&gt; (Visual C++)
The \<include> tag lets you refer to comments in another file that describe the types and members in your source code. This is an alternative to placing documentation comments directly in your source code file.  For example, you can use \<include> to insert standard "boilerplate" comments that are used throughout your team or company.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The name of the file containing the documentation. The file name can be qualified with a path.  Enclose the name in single or double quotation marks.  The compiler issues a warning if it does not find <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A valid XPath expression that selects the desired node-set contained in the file.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The name specifier in the tag that precedes the comments; <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> will have an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The ID for the tag that precedes the comments.  Enclose the name in single or double quotation marks.  
  
## Remarks  
 The \<include> tag uses the XML XPath syntax. Refer to XPath documentation for ways to customize using \<include>.  
  
 Compile with [/doc](../vs140/-doc--process-documentation-comments---c-c---.md) to process documentation comments to a file.  
  
## Example  
 This is a multifile example. The first file, which uses \<include>, contains the following documentation comments:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The second file, xml_include_tag.doc, contains the following documentation comments:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Program Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation](../vs140/xml-documentation--visual-c---.md)