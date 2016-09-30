---
title: "codecvt_utf16"
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
  - "codecvt/std::codecvt_utf16"
  - "std::codecvt_utf16"
  - "std.codecvt_utf16"
  - "codecvt_utf16"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "codecvt_utf16 class"
ms.assetid: a9897f98-f84d-4db6-90ad-858b2727570c
caps.latest.revision: 23
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# codecvt_utf16
Represents a [locale](../vs140/locale-class.md) facet that converts between wide characters encoded as UCS-2 or UCS-4 and a byte stream encoded as UTF-16LE or UTF-16BE.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The wide-character element type.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The maximum number of characters for the locale facet.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Configuration information for the locale facet.|  
  
## Remarks  
 This template class converts between wide characters encoded as UCS-2 or UCS-4 and a byte stream encoded as UTF-16LE, if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or UTF-16BE otherwise.  
  
 The byte stream should be written to a binary file; it can be corrupted if written to a text file.  
  
## Requirements  
 **Header:** \<codecvt>  
  
 **Namespace:** std