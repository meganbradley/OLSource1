---
title: "&lt;summary&gt; (Visual C++)"
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
  - "<summary>"
  - "summary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<summary> C++ XML tag"
  - "summary C++ XML tag"
ms.assetid: cdeeefbb-1339-45d6-9002-10042a9a2726
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;summary&gt; (Visual C++)
The \<summary> tag should be used to describe a type or a type member. Use [\<remarks>](../vs140/-remarks---visual-c---.md) to add supplemental information to a type description.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A summary of the object.  
  
## Remarks  
 The text for the \<summary> tag is the only source of information about the type in IntelliSense, and is also displayed in the [Object Browser](assetId:///f89acfc5-1152-413d-9f56-3dc16e3f0470) and in the Code Comment Web Report.  
  
 Compile with [/doc](../vs140/-doc--process-documentation-comments---c-c---.md) to process documentation comments to a file.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation](../vs140/xml-documentation--visual-c---.md)