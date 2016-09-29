---
title: "Compiler Warning (level 1) CS1709"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1709"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1709"
ms.assetid: e2bb1d30-4f30-4e10-82da-df1d3418454c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1709
Filename specified for preprocessor directive is empty  
  
 You have specified a preprocessor directive that includes a file name, but that file is empty. To resolve this warning, put the needed content into the file.  
  
## Example  
 The following example generates CS1709.  
  
```  
// CS1709.cs  
class Test  
{  
    static void Main()  
    {  
        #pragma checksum "" "{406EA660-64CF-4C82-B6F0-42D48172A799}" ""  // CS1709  
    }  
}  
```