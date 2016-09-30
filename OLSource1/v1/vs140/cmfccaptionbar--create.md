---
title: "CMFCCaptionBar::Create"
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
  - "Create"
  - "CMFCCaptionBar.Create"
  - "CMFCCaptionBar::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 212ea3db-85e5-4b59-b41c-7cfb76136fd2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionBar::Create
Creates the caption bar control and attaches it to the `CMFCCaptionBar` object.  
  
## Syntax  
  
```  
BOOL Create(  
   DWORD dwStyle,  
   CWnd* pParentWnd,  
   UINT uID,  
   int nHeight=-1,  
   BOOL bIsMessageBarMode=FALSE   
);  
```  
  
#### Parameters  
 `dwStyle`  
 The logical OR combination of the caption bar styles.  
  
 `pParentWnd`  
 The parent window of the caption bar control.  
  
 `uID`  
 The ID of caption bar control.  
  
 `nHeight`  
 The height, in pixels, of the caption bar control. If it is -1, the height is calculated according to the height of the icon, the text and the button that the caption bar control displays.  
  
 `bIsMessageBarMode`  
 `TRUE` if the caption bar is in the message bar mode; `FALSE` otherwise.  
  
## Return Value  
 `TRUE` if the caption bar control is created successfully; `FALSE` otherwise.  
  
## Remarks  
 You construct a `CMFCCaptionBar` object in two steps. First you call the constructor, and then you call the `Create` method, which creates the Windows control and attaches it to the `CMFCCaptionBar` object.  
  
## Requirements  
 **Header:** afxcaptionbar.h  
  
## See Also  
 [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)