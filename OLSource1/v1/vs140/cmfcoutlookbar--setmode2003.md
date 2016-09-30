---
title: "CMFCOutlookBar::SetMode2003"
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
  - "CMFCOutlookBar::SetMode2003"
  - "SetMode2003"
  - "CMFCOutlookBar.SetMode2003"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMode2003 method"
ms.assetid: 2cb3d634-cb09-4f42-86f5-feda86a59d18
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBar::SetMode2003
Specifies whether the behavior of the Outlook bar mimics that of Outlook 2003.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If TRUE, Office 2003 mode is enabled.  
  
## Remarks  
 Use this function to enable or disable Office 2003 mode. In this mode, the Outlook bar has an additional toolbar with a customization button. The behavior of the Outlook bar conforms to the behavior of the Outlook bar in Microsoft Office 2003.  
  
 By default, this mode is disabled.  
  
> [!NOTE]
>  This function must be called before [CMFCOutlookBar::Create](../vs140/cmfcoutlookbar--create.md).  
  
## Requirements  
 **Header:** afxoutlookbar.h  
  
## See Also  
 [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)