---
title: "codecvt_mode"
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
  - "codecvt/std::codecvt_mode"
  - "codecvt_mode"
  - "std.codecvt_mode"
  - "std::codecvt_mode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "codecvt_mode enumeration"
ms.assetid: c5dccee5-6fb7-4dbe-8dbc-b261f4c17b2f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt_mode
Specifies configuration information for [locale](../vs140/locale-class.md) facets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The enumeration defines three constants that supply configuration information to the locale facets declared in [\<codecvt>](../vs140/-codecvt-.md). The distinct values are:  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, to consume an initial header sequence when reading a multibyte sequence and determine the endianness of the subsequent multibyte sequence to be read  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, to generate an initial header sequence when writing a multibyte sequence to advertise the endianness of the subsequent multibyte sequence to be written  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, to generate a multibyte sequence in little-endian order, as opposed to the default big-endian order  
  
 These constants can be ORed together in arbitrary combinations.  
  
## Requirements  
 **Header:** \<codecvt>  
  
 **Namespace:** std