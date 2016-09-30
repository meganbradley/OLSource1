---
title: "CFileFind::GetFileURL"
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
  - "CFileFind.GetFileURL"
  - "CFileFind::GetFileURL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFileURL method"
  - "Internet files, finding"
  - "URLs, finding"
ms.assetid: dc498259-5d1f-4687-b9d0-964e1673e49a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind::GetFileURL
Call this member function to retrieve the specified URL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The complete URL.  
  
## Remarks  
 You must call [FindNextFile](../vs140/cfilefind--findnextfile.md) at least once before calling <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is similar to the member function [GetFilePath](../vs140/cfilefind--getfilepath.md), except that it returns the URL in the form <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. For example, calling <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to get the complete URL for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the URL <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [CFileFind::GetFileName](../vs140/cfilefind--getfilename.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileFind::FindFile](../vs140/cfilefind--findfile.md)