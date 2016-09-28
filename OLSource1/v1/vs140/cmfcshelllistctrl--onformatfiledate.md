---
title: "CMFCShellListCtrl::OnFormatFileDate"
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
  - "CMFCShellListCtrl.OnFormatFileDate"
  - "OnFormatFileDate"
  - "CMFCShellListCtrl::OnFormatFileDate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFormatFileDate method"
ms.assetid: 25bd7155-d2ee-4e22-9008-1bbfcc12c37c
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellListCtrl::OnFormatFileDate
The framework calls this method when it must convert the date associated with an object into a string.  
  
## Syntax  
  
```  
virtual void OnFormatFileDate(  
   const CTime& tmFile,  
   CString& str   
);  
```  
  
#### Parameters  
 [in] `tmFile`  
 The date associated with a file.  
  
 [out] `str`  
 A string that contains the formatted file date.  
  
## Remarks  
 When a [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md) object displays the date associated with a file, it must convert that date to a string format. The `CMFCShellListCtrl` uses this method to make that conversion. By default, this method uses the current locale to format the date into a string.  
  
## Requirements  
 **Header:** afxshelllistctrl.h  
  
## See Also  
 [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)