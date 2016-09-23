---
title: "CFileFind::GetLastAccessTime"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CFileFind.GetLastAccessTime
  - GetLastAccessTime
  - CFileFind::GetLastAccessTime
dev_langs: 
  - C++
helpviewer_keywords: 
  - timestamps, file modified or opened
  - time accessed
  - files [C++], timestamps
  - GetLastAccessTime method
ms.assetid: 2090cbe7-d043-4de0-b7d7-bddca832a886
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileFind::GetLastAccessTime
Call this member function to get the time that the specified file was last accessed.  
  
## Syntax  
  
```  
  
      virtual BOOL GetLastAccessTime(  
   CTime& refTime   
) const;  
virtual BOOL GetLastAccessTime(  
   FILETIME* pTimeStamp  
) const;  
```  
  
#### Parameters  
 `refTime`  
 A reference to a [CTime](../vs140/ctime-class.md) object.  
  
 `pTimeStamp`  
 A pointer to a [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structure containing the time the file was last accessed.  
  
## Return Value  
 Nonzero if successful; 0 if unsuccessful. `GetLastAccessTime` returns 0 only if [FindNextFile](../vs140/cfilefind--findnextfile.md) has never been called on this `CFileFind` object.  
  
## Remarks  
 You must call [FindNextFile](../vs140/cfilefind--findnextfile.md) at least once before calling `GetLastAccessTime`.  
  
> [!NOTE]
>  Not all file systems use the same semantics to implement the time stamp returned by this function. This function may return the same value returned by other time stamp functions if the underlying file system or server does not support keeping the time attribute. See the [Win32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure for information about time formats. On some operation systems, the returned time is in the time zone local to the machine were the file is located. See the Win32 [FileTimeToLocalFileTime](http://msdn.microsoft.com/library/windows/desktop/ms724277) API for more information.  
  
## Example  
 See the example for [CFileFind::GetLength](../vs140/cfilefind--getlength.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)