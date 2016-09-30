---
title: "CInternetFile::WriteString"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CInternetFile::WriteString"
  - "CInternetFile.WriteString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WriteString method"
  - "CInternetFile class, operations"
  - "Internet files, writing strings"
ms.assetid: b425fe84-a468-48df-819c-288a142f46f8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetFile::WriteString
This function writes a null-terminated string to the associated file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a string containing the contents to be written.  
  
## Remarks  
 If any error occurs while writing the data, the function throws a [CInternetException](../vs140/cinternetexception-class.md) object describing the error.  
  
## Exceptions  
 This method can throw exceptions of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetFile Class](../vs140/cinternetfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)