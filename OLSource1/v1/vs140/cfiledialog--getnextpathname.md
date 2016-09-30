---
title: "CFileDialog::GetNextPathName"
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
  - "CFileDialog.GetNextPathName"
  - "GetNextPathName"
  - "CFileDialog::GetNextPathName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class, operations"
  - "GetNextPathName method"
ms.assetid: 020a54b6-9425-409e-a17b-6e37bf564277
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::GetNextPathName
Call this function to retrieve the next filename from the group selected in the dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function call. **NULL** if the end of the list has been reached.  
  
## Return Value  
 The full path of the file.  
  
## Remarks  
 The path of the filename includes the file's title plus the entire directory path. For example, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will return "C:\FILES\TEXT.DAT" for the file C:\FILES\TEXT.DAT. You can use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in a forward iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 If the selection consists of only one file, that file name will be returned.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog::GetFileName](../vs140/cfiledialog--getfilename.md)   
 [CFileDialog::GetStartPosition](../vs140/cfiledialog--getstartposition.md)