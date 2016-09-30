---
title: "CFileDialog::GetFileName"
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
  - "CFileDialog.GetFileName"
  - "CFileDialog::GetFileName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class, operations"
  - "GetFileName method"
ms.assetid: 69179eec-f628-4f46-a6dc-627a7614f799
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::GetFileName
Call this function to retrieve the name of the filename entered in the dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The name of the file.  
  
## Remarks  
 The name of the file includes both the prefix and the extension. For example, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> will return "TEXT.DAT" for the file C:\FILES\TEXT.DAT.  
  
 If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> has the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> flag set, you should call [GetStartPosition](../vs140/cfiledialog--getstartposition.md) and [GetNextPathName](../vs140/cfiledialog--getnextpathname.md) to retrieve a file pathname.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog::GetPathName](../vs140/cfiledialog--getpathname.md)   
 [CFileDialog::GetStartPosition](../vs140/cfiledialog--getstartposition.md)   
 [CFileDialog::GetFileTitle](../vs140/cfiledialog--getfiletitle.md)