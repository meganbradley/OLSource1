---
title: "CMFCEditBrowseCtrl::OnIllegalFileName"
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
  - "afxeditbrowsectrl/CMFCEditBrowseCtrl::OnIllegalFileName"
  - "OnIllegalFileName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnIllegalFileName"
ms.assetid: 4e1b07b6-7dba-4655-9a1d-fe1333587007
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCEditBrowseCtrl::OnIllegalFileName
Called by the framework when an illegal file name was entered in the edit control.  
  
## Syntax  
  
```  
virtual BOOL OnIllegalFileName(  
   CString& strFileName  
);  
```  
  
#### Parameters  
 `strFileName`  
 Specifies the illegal file name.  
  
## Return Value  
 Should return `FALSE` if this file name can not be passed further to the file dialog. In this case, focus is set back to the edit control and the user should continue editing. The default implementation displays a message box telling the user about the illegal file name and returns `FALSE`. You can override this method, correct the file name, and return `TRUE` for further processing.  
  
## Remarks  
  
## Requirements  
 **Header:** afxeditbrowsectrl.h  
  
## See Also  
 [CMFCEditBrowseCtrl Class](../vs140/cmfceditbrowsectrl-class.md)