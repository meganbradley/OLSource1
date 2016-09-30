---
title: "CGopherFileFind::GetLastAccessTime"
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
  - "GetLastAccessTime"
  - "CGopherFileFind.GetLastAccessTime"
  - "CGopherFileFind::GetLastAccessTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLastAccessTime method"
ms.assetid: 0cfaa883-b11a-4d50-94a1-a1ad3d8fdf71
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherFileFind::GetLastAccessTime
Gets the time the specified file was last accessed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a [CTime](../vs140/ctime-class.md) object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structure containing the time the file was last accessed.  
  
## Return Value  
 Nonzero if successful; 0 if unsuccessful. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns 0 only if [FindNextFile](../vs140/cgopherfilefind--findnextfile.md) has never been called on this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Remarks  
 You must call [FindNextFile](../vs140/cgopherfilefind--findnextfile.md) at least once before calling <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Not all file systems use the same semantics to implement the time stamp returned by this function. This function may return the same value returned by other time stamp functions if the underlying file system or server does not support keeping the time attribute. See the [Win32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure for information about time formats. On some operating systems, the returned time is in the time zone local to the machine were the file is located. See the Win32 [FileTimeToLocalFileTime](http://msdn.microsoft.com/library/windows/desktop/ms724277) API for more information.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)