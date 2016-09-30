---
title: "&lt;permission&gt; (Visual C++)"
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
  - "permission"
  - "<permission>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<permission> C++ XML tag"
  - "permission C++ XML tag"
ms.assetid: 537ee2bc-95bd-48e4-9ce6-3420c3da87f4
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;permission&gt; (Visual C++)
The \<permission> tag lets you document the access of a member. \<xref:System.Security.PermissionSet*> lets you specify access to a member.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a member or field that is available to be called from the current compilation environment. The compiler checks that the given code element exists and translates <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to the canonical element name in the output XML.  Enclose the name in single or double quotation marks.  
  
 The compiler issues a warning if it does not find <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 For information on how to create a cref reference to a generic type, see [\<see> (C++)](../vs140/-see---visual-c---.md).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A description of the access to the member.  
  
## Remarks  
 Compile with [/doc](../vs140/-doc--process-documentation-comments---c-c---.md) to process documentation comments to a file.  
  
 The Visual C++ compiler will attempt to resolve cref references in one pass through the documentation comments.  Therefore, if using the C++ lookup rules, a symbol is not found by the compiler the reference will be marked as unresolved. See [\<seealso> (C++)](../vs140/-seealso---visual-c---.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation](../vs140/xml-documentation--visual-c---.md)