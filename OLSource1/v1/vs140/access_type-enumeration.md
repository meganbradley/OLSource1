---
title: "access_type Enumeration"
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
ms.assetid: a1b2d084-38dd-4fb6-b268-48e3ab15d634
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# access_type Enumeration
Enumeration type used to denote the various types of access to data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Automatically choose the best <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for the accelerator.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Dedicated. The allocation is only accessible on the accelerator and not on the CPU.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Shared. The allocation is accessible on the accelerator and is readable on the CPU.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Shared. The allocation is accessible on the accelerator and is writable on the CPU.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Shared. The allocation is accessible on the accelerator and is both readable and writable on the CPU.|  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace (C++ AMP)](../vs140/concurrency-namespace--c---amp-.md)