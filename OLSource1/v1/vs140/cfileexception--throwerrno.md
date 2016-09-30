---
title: "CFileException::ThrowErrno"
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
  - "CFileException.ThrowErrno"
  - "CFileException::ThrowErrno"
  - "ThrowErrno"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ThrowErrno method"
  - "CFileException class, helper functions"
ms.assetid: e0088d8a-89ed-4ad8-8128-edc456cfb33d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileException::ThrowErrno
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object corresponding to a given <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value, then throws the exception.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An integer error code as defined in the run-time include file ERRNO.H.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the string containing the name of the file that caused the exception, if available.  
  
## Example  
 [!code[NVC_MFCFiles#28](../vs140/codesnippet/CPP/cfileexception--throwerrno_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileException Class](../vs140/cfileexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileException::ThrowOsError](../vs140/cfileexception--throwoserror.md)