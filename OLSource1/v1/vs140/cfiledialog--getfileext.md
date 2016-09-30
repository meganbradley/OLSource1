---
title: "CFileDialog::GetFileExt"
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
  - "GetFileExt"
  - "CFileDialog::GetFileExt"
  - "CFileDialog.GetFileExt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class, operations"
  - "GetFileExt method"
ms.assetid: 374512fe-5d0b-4180-a713-c8bff68d980a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::GetFileExt
Call this function to retrieve the extension of the filename entered into the dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The extension of the filename.  
  
## Remarks  
 For example, if the name of the file entered is DATA.TXT, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns "TXT".  
  
 If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> has the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> flag set, this string contains a sequence of null-terminated strings, with the first string being the directory path of the file group selected, followed by the names of all files selected by the user. To retrieve file pathnames, use the [GetStartPosition](../vs140/cfiledialog--getstartposition.md) and [GetNextPathName](../vs140/cfiledialog--getnextpathname.md) member functions.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog::GetPathName](../vs140/cfiledialog--getpathname.md)   
 [CFileDialog::GetFileName](../vs140/cfiledialog--getfilename.md)   
 [CFileDialog::GetFileTitle](../vs140/cfiledialog--getfiletitle.md)