---
title: "CFileException::ThrowOsError"
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
  - "CFileException::ThrowOsError"
  - "CFileException.ThrowOsError"
  - "ThrowOsError"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ThrowOsError method"
  - "CFileException class, helper functions"
ms.assetid: d0ef7b4a-bb07-4213-9c62-e9a6ceb6535e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileException::ThrowOsError
Throws a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> corresponding to a given <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value. If the error code is unknown, then the function throws an exception coded as **CFileException::generic**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An operating-system-specific error code.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the string containing the name of the file that caused the exception, if available.  
  
## Example  
 [!code[NVC_MFCFiles#29](../vs140/codesnippet/CPP/cfileexception--throwoserror_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileException Class](../vs140/cfileexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileException::ThrowErrno](../vs140/cfileexception--throwerrno.md)