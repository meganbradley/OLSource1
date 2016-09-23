---
title: "COleControl::DisplayError"
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
  - COleControl::DisplayError
  - COleControl.DisplayError
  - DisplayError
dev_langs: 
  - C++
helpviewer_keywords: 
  - DisplayError method
ms.assetid: d25c5c06-7ecc-44ce-8989-875986e3d948
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::DisplayError
Called by the framework after the stock Error event has been handled (unless the event handler has suppressed the display of the error).  
  
## Syntax  
  
```  
  
      virtual void DisplayError(  
   SCODE scode,  
   LPCTSTR lpszDescription,  
   LPCTSTR lpszSource,  
   LPCTSTR lpszHelpFile,  
   UINT nHelpID   
);  
```  
  
#### Parameters  
 *scode*  
 The status code value to be reported. For a complete list of possible codes, see the article [ActiveX Controls: Advanced Topics](../vs140/mfc-activex-controls--advanced-topics.md).  
  
 `lpszDescription`  
 The description of the error being reported.  
  
 *lpszSource*  
 The name of the module generating the error (typically, the name of the OLE control module).  
  
 `lpszHelpFile`  
 The name of the help file containing a description of the error.  
  
 `nHelpID`  
 The Help Context ID of the error being reported.  
  
## Remarks  
 The default behavior displays a message box containing the description of the error, contained in `lpszDescription`.  
  
 Override this function to customize how errors are displayed.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::FireError](../vs140/colecontrol--fireerror.md)