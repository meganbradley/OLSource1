---
title: "CFile::GetFileTitle"
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
  - "CFile::GetFileTitle"
  - "CFile.GetFileTitle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFile class, attributes"
  - "GetFileTitle method"
ms.assetid: 47e03007-f551-4ae7-b0e7-ccbc097e3056
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::GetFileTitle
Call this member function to retrieve the file title (the display name) for the file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The title of the underlying file.  
  
## Remarks  
 This method calls [GetFileTitle](http://msdn.microsoft.com/library/windows/desktop/ms646924) to retrieve the title of the file. If successful, the method returns the string that the system would use to display the file name to the user. Otherwise, the method calls [PathFindFileName](http://msdn.microsoft.com/library/windows/desktop/bb773589) to retrieve the file name (including the file extension) of the underlying file. Therefore, the file extension will not always be included in the returned file title string. For more information, see [GetFileTitle](http://msdn.microsoft.com/library/windows/desktop/ms646924) and [PathFindFileName](http://msdn.microsoft.com/library/windows/desktop/bb773589) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 To return the entire path of the file, including the name, call [GetFilePath](../vs140/cfile--getfilepath.md). To return just the name of the file, call [GetFileName](../vs140/cfile--getfilename.md).  
  
## Example  
 See the example for [GetFileName](../vs140/cfile--getfilename.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::GetFileName](../vs140/cfile--getfilename.md)   
 [CFile::GetFilePath](../vs140/cfile--getfilepath.md)   
 [GetFileTitle](http://msdn.microsoft.com/library/windows/desktop/ms646924)   
 [PathFindFileName](http://msdn.microsoft.com/library/windows/desktop/bb773589)