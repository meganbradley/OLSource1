---
title: "CGopherFileFind::GetLastWriteTime"
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
  - "CGopherFileFind.GetLastWriteTime"
  - "CGopherFileFind::GetLastWriteTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLastWriteTime method"
ms.assetid: 3efc0c66-8354-46d9-94e1-72fcc4ae41b5
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherFileFind::GetLastWriteTime
Gets the last time the file was changed.  
  
## Syntax  
  
```  
  
      virtual BOOL GetLastWriteTime(  
   FILETIME* pTimeStamp   
) const;  
virtual BOOL GetLastWriteTime(  
   CTime& refTime   
) const;  
```  
  
#### Parameters  
 `pTimeStamp`  
 A pointer to a [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structure containing the time the file was last written to.  
  
 `refTime`  
 A reference to a [CTime](../vs140/ctime-class.md) object.  
  
## Return Value  
 Nonzero if successful; 0 if unsuccessful. `GetLastWriteTime` returns 0 only if [FindNextFile](../vs140/cgopherfilefind--findnextfile.md) has never been called on this `CGopherFileFind` object.  
  
## Remarks  
 You must call [FindNextFile](../vs140/cgopherfilefind--findnextfile.md) at least once before calling `GetLastWriteTime`.  
  
> [!NOTE]
>  Not all file systems use the same semantics to implement the time stamp returned by this function. This function may return the same value returned by other time stamp functions if the underlying file system or server does not support keeping the time attribute. See the [Win32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure for information about time formats. On some operating systems, the returned time is in the time zone local to the machine were the file is located. See the Win32 [FileTimeToLocalFileTime](http://msdn.microsoft.com/library/windows/desktop/ms724277) API for more information.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)