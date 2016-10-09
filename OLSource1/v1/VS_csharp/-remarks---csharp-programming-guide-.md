---
title: "&lt;remarks&gt; (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "remarks"
  - "<remarks>"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "remarks C# XML tag"
  - "<remarks> C# XML tag"
ms.assetid: f8641391-31f3-4735-af7a-c502a5b6a251
caps.latest.revision: 15
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
# &lt;remarks&gt; (C# Programming Guide)
## Syntax  
  
```  
<remarks>description</remarks>  
```  
  
#### Parameters  
 `Description`  
 A description of the member.  
  
## Remarks  
 The \<remarks> tag is used to add information about a type, supplementing the information specified with [\<summary>](../VS_csharp/-summary---csharp-programming-guide-.md). This information is displayed in the Object Browser window.  
  
 Compile with [/doc](../VS_csharp/-doc--csharp-compiler-options-.md) to process documentation comments to a file.  
  
## Example  
 [!code[csProgGuideDocComments#9](../VS_csharp/codesnippet/CSharp/-remarks---csharp-programming-guide-_1.cs)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Recommended Tags for Documentation Comments](../VS_csharp/recommended-tags-for-documentation-comments--csharp-programming-guide-.md)