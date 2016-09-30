---
title: "&lt;remarks&gt; (Visual C++)"
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
  - "remarks"
  - "<remarks>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<remarks> C++ XML tag"
  - "remarks C++ XML tag"
ms.assetid: c820083b-3192-40ab-9ec8-1472c55b4247
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;remarks&gt; (Visual C++)
The \<remarks> tag is used to add information about a type, supplementing the information specified with [\<summary>](../vs140/-summary---visual-c---.md). This information is displayed in the [Object Browser](assetId:///f89acfc5-1152-413d-9f56-3dc16e3f0470) and in the Code Comment Web Report.  
  
## Syntax  
  
```  
<remarks>description</remarks>  
```  
  
#### Parameters  
 `description`  
 A description of the member.  
  
## Remarks  
 Compile with [/doc](../vs140/-doc--process-documentation-comments---c-c---.md) to process documentation comments to a file.  
  
## Example  
  
```  
// xml_remarks_tag.cpp  
// compile with: /LD /clr /doc  
// post-build command: xdcmake xml_remarks_tag.dll  
  
using namespace System;  
  
/// <summary>  
/// You may have some primary information about this class.  
/// </summary>  
/// <remarks>  
/// You may have some additional information about this class.  
/// </remarks>  
public ref class MyClass {};  
```  
  
## See Also  
 [XML Documentation](../vs140/xml-documentation--visual-c---.md)