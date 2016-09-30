---
title: "raw_method_prefix"
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
  - "raw_method_prefix"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "raw_method_prefix attribute"
ms.assetid: 71490313-af78-4bb2-b28a-eee67950d30b
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# raw_method_prefix
**C++ Specific**  
  
 Specifies a different prefix to avoid name collisions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The prefix to be used.  
  
## Remarks  
 Low-level properties and methods are exposed by member functions named with a default prefix of **raw_** to avoid name collisions with the high-level error-handling member functions.  
  
> [!NOTE]
>  The effects of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute will not be changed by the presence of the [raw_interfaces_only](#_predir_raw_interfaces_only) attribute. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> always takes precedence over <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in specifying a prefix. If both attributes are used in the same <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement, then the prefix specified by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute is used.  
  
 **END C++ Specific**  
  
## See Also  
 [#import Attributes](../vs140/sharpimport-attributes--c---.md)   
 [The #import Directive](../vs140/sharpimport-directive--c---.md)