---
title: "CPageSetupDialog::PreDrawPage"
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
  - "CPageSetupDialog.PreDrawPage"
  - "CPageSetupDialog::PreDrawPage"
  - "PreDrawPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PreDrawPage method"
  - "CPageSetupDialog class, overridables"
ms.assetid: 5ff204ee-e0db-4d6a-b3f9-9cc5ad25188a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPageSetupDialog::PreDrawPage
Called by the framework before drawing the screen image of a printed page.  
  
## Syntax  
  
```  
  
      virtual UINT PreDrawPage(  
   WORD wPaper,  
   WORD wFlags,  
   LPPAGESETUPDLG pPSD   
);  
```  
  
#### Parameters  
 *wPaper*  
 Specifies a value that indicates the paper size. This value can be one of the **DMPAPER_** values listed in the description of the [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) structure.  
  
 `wFlags`  
 Indicates the orientation of the paper or envelope, and whether the printer is a dot-matrix or HPPCL (Hewlett Packard Printer Control Language) device. This parameter can have one of the following values:  
  
-   0x001   Paper in landscape mode (dot matrix)  
  
-   0x003   Paper in landscape mode (HPPCL)  
  
-   0x005   Paper in portrait mode (dot matrix)  
  
-   0x007   Paper in portrait mode (HPPCL)  
  
-   0x00b   Envelope in landscape mode (HPPCL)  
  
-   0x00d   Envelope in portrait mode (dot matrix)  
  
-   0x019   Envelope in landscape mode (dot matrix)  
  
-   0x01f   Envelope in portrait mode (dot matrix)  
  
 `pPSD`  
 Pointer to a **PAGESETUPDLG** structure. For more information on [PAGESETUPDLG](http://msdn.microsoft.com/library/windows/desktop/ms646842), see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero value if handled; otherwise 0.  
  
## Remarks  
 Override this function to customize the drawing of the image. If you override this function and return **TRUE**, you must draw the entire image. If you override this function and return **FALSE**, the entire default image is drawn by the framework.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPageSetupDialog Class](../vs140/cpagesetupdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPageSetupDialog::OnDrawPage](../vs140/cpagesetupdialog--ondrawpage.md)