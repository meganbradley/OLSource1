---
title: "CMFCShellListCtrl::OnFormatFileSize"
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
  - "CMFCShellListCtrl.OnFormatFileSize"
  - "CMFCShellListCtrl::OnFormatFileSize"
  - "OnFormatFileSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFormatFileSize method"
ms.assetid: 4c35bddf-bade-4878-b0aa-578c99afe224
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellListCtrl::OnFormatFileSize
The framework calls this method when it converts the size of an object to a string.  
  
## Syntax  
  
```  
virtual void OnFormatFileSize(  
   long lFileSize,  
   CString& str   
);  
```  
  
#### Parameters  
 [in] `lFileSize`  
 The size of the file that the framework will display.  
  
 [out] `str`  
 A string that contains the formatted file size.  
  
## Remarks  
 When a [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md) object needs to display the size of a file, it needs to convert the file size into a string format. The `CMFCShellListCtrl` uses this method to make that conversion. By default, this method converts the file size from bytes to kilobytes and then uses the current locale to format the size into string.  
  
## Requirements  
 **Header:** afxshelllistctrl.h  
  
## See Also  
 [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)