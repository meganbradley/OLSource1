---
title: "&lt;list&gt; (Visual C++)"
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
  - "list"
  - "<list>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "list C++ XML tag"
  - "<list> C++ XML tag"
ms.assetid: c792a10b-0451-422c-9aa0-604116e69d64
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;list&gt; (Visual C++)
The \<listheader> block is used to define the heading row of either a table or definition list. When defining a table, you only need to supply an entry for term in the heading.  
  
## Syntax  
  
```  
<list type="bullet" | "number" | "table">  
   <listheader>  
      <term>term</term>  
      <description>description</description>  
   </listheader>  
   <item>  
      <term>term</term>  
      <description>description</description>  
   </item>  
</list>  
```  
  
#### Parameters  
 `term`  
 A term to define, which will be defined in `description`.  
  
 `description`  
 Either an item in a bullet or numbered list or the definition of a `term`.  
  
## Remarks  
 Each item in the list is specified with an \<item> block. When creating a definition list, you will need to specify both `term` and `description`. However, for a table, bulleted list, or numbered list, you only need to supply an entry for `description`.  
  
 A list or table can have as many \<item> blocks as needed.  
  
 Compile with [/doc](../vs140/-doc--process-documentation-comments---c-c---.md) to process documentation comments to a file.  
  
## Example  
  
```  
// xml_list_tag.cpp  
// compile with: /doc /LD  
// post-build command: xdcmake xml_list_tag.dll  
/// <remarks>Here is an example of a bulleted list:  
/// <list type="bullet">  
/// <item>  
/// <description>Item 1.</description>  
/// </item>  
/// <item>  
/// <description>Item 2.</description>  
/// </item>  
/// </list>  
/// </remarks>  
class MyClass {};  
```  
  
## See Also  
 [XML Documentation](../vs140/xml-documentation--visual-c---.md)