---
title: "CFile::GetFilePath"
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
  - "CFile::GetFilePath"
  - "CFile.GetFilePath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFilePath method"
  - "CFile class, attributes"
ms.assetid: 4d637b82-fe44-4f0a-bd2b-180bcfe10da4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::GetFilePath
Call this member function to retrieve the full path of a specified file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The full path of the specified file.  
  
## Remarks  
 For example, when you call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to generate a message to the user about the file <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the file path, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, is returned.  
  
 To return just the name of the file (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>), call [GetFileName](../vs140/cfile--getfilename.md). To return the title of the file (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>), call [GetFileTitle](../vs140/cfile--getfiletitle.md).  
  
## Example  
 See the example for [GetFileName](../vs140/cfile--getfilename.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::SetFilePath](../vs140/cfile--setfilepath.md)   
 [CFile::GetFileTitle](../vs140/cfile--getfiletitle.md)   
 [CFile::GetFileName](../vs140/cfile--getfilename.md)