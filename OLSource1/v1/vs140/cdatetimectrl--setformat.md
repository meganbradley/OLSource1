---
title: "CDateTimeCtrl::SetFormat"
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
  - "SetFormat"
  - "CDateTimeCtrl::SetFormat"
  - "CDateTimeCtrl.SetFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFormat method"
ms.assetid: 18035c8e-a246-4e40-9ba5-1a9099bbf0d2
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::SetFormat
Sets the display of a date and time picker control in accordance with a given format string.  
  
## Syntax  
  
```  
  
      BOOL SetFormat(  
   LPCTSTR pstrFormat   
);  
```  
  
#### Parameters  
 *pstrFormat*  
 A pointer to a zero-terminated format string that defines the desired display. Setting this parameter to **NULL** will reset the control to the default format string for the current style.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
> [!NOTE]
>  User input does not determine success or failure for this call.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [DTM_SETFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb761771), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CDateTimeCtrl#6](../vs140/codesnippet/CPP/cdatetimectrl--setformat_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)