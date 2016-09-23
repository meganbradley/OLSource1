---
title: "CToolBarCtrl::GetString"
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
  - CToolBarCtrl::GetString
  - CToolBarCtrl.GetString
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetString method
ms.assetid: 8d3e55ad-10aa-4924-bf42-e43a99c43dff
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolBarCtrl::GetString
Retrieves a toolbar string.  
  
## Syntax  
  
```  
  
      int GetString(  
   int nString,  
   LPTSTR lpstrString,  
   int cchMaxLen   
) const;  
int GetString(  
   int nString,  
   CString& str   
) const;  
```  
  
#### Parameters  
 *nString*  
 Index of the string.  
  
 *lpstrString*  
 Pointer to a buffer used to return the string.  
  
 *cchMaxLen*  
 Length of the buffer in bytes.  
  
 `str`  
 The string.  
  
## Return Value  
 The length of the string if successful, -1 if not.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETSTRING](http://msdn.microsoft.com/library/windows/desktop/bb787349), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::AddString](../vs140/ctoolbarctrl--addstring.md)