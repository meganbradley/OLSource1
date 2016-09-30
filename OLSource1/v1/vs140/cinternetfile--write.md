---
title: "CInternetFile::Write"
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
  - "CInternetFile::Write"
  - "CInternetFile.Write"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInternetFile class, operations"
  - "Internet files, writing to"
  - "Write method"
ms.assetid: 021ef57e-a7db-400c-8ddb-eaa0b2e6ca47
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetFile::Write
Call this member function to write into the given memory, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, the specified number of bytes, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the first byte to be written.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the number of bytes to be written.  
  
## Remarks  
 If any error occurs while writing the data, the function throws a [CInternetException](../vs140/cinternetexception-class.md) object describing the error.  
  
## Exceptions  
 This method can throw exceptions of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetFile Class](../vs140/cinternetfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)