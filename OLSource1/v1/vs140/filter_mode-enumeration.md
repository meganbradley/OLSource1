---
title: "filter_mode Enumeration"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: ccf92beb-e324-44e4-81b0-6ef8799ee8b1
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# filter_mode Enumeration
Enumeration type use to denote filter modes supported for texture sampling.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Yields the weighted average of the nearest texels.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Chooses the nearest texel to the specified coordinates.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Not exposed by the C++ AMP API. It represents a filter mode that's adopted from, and created through, the underlying platform. After it is created, you can adopt it in your C++ AMP code through the platform’s interop APIs.|  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [concurrency::graphics Namespace](../vs140/concurrency--graphics-namespace.md)