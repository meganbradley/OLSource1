---
title: "CFileFind::CloseContext"
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
  - "CFileFind.CloseContext"
  - "CFileFind::CloseContext"
  - "CloseContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CloseContext method"
ms.assetid: 66b40c92-0775-4e60-979c-6627ebb9b988
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind::CloseContext
Closes the file specified by the current search handle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Closes the file specified by the current value of the search handle. Override this function to change the default behavior.  
  
 You must call the [FindFile](../vs140/cfilefind--findfile.md) or [FindNextFile](../vs140/cfilefind--findnextfile.md) functions at least once to retrieve a valid search handle. The **FindFile** and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> functions use the search handle to locate files with names that match a given name.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileFind::FindNextFile](../vs140/cfilefind--findnextfile.md)   
 [CFileFind::FindFile](../vs140/cfilefind--findfile.md)