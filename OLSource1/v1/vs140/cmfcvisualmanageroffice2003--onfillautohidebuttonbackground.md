---
title: "CMFCVisualManagerOffice2003::OnFillAutoHideButtonBackground"
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
  - "CMFCVisualManagerOffice2003.OnFillAutoHideButtonBackground"
  - "OnFillAutoHideButtonBackground"
  - "CMFCVisualManagerOffice2003::OnFillAutoHideButtonBackground"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillAutoHideButtonBackground method"
ms.assetid: d4d93a58-911c-437d-bd0e-35b09f734eac
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnFillAutoHideButtonBackground
The framework calls this method when it fills the background of an auto-hide button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the auto-hide button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a [CMFCAutoHideButton](../vs140/cmfcautohidebutton-class.md) object. The framework fills the background for this auto-hide button.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of an auto-hide button.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)