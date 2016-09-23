---
title: "CMFCOutlookBarPane::AddButton"
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
  - CMFCOutlookBarPane::AddButton
  - AddButton
  - CMFCOutlookBarPane.AddButton
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddButton method
ms.assetid: 10703171-c7a9-404c-a227-5d5580477192
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCOutlookBarPane::AddButton
Adds a button to the Outlook bar pane.  
  
## Syntax  
  
```  
BOOL AddButton(  
   UINT uiImage,  
   LPCTSTR lpszLabel,  
   UINT iIdCommand,  
   int iInsertAt=-1   
);  
BOOL AddButton(  
   UINT uiImage,  
   UINT uiLabel,  
   UINT iIdCommand,  
   int iInsertAt=-1   
);  
BOOL AddButton(  
   LPCTSTR szBmpFileName,  
   LPCTSTR szLabel,  
   UINT iIdCommand,  
   int iInsertAt=-1   
);  
BOOL AddButton(  
   HBITMAP hBmp,  
   LPCTSTR lpszLabel,  
   UINT iIdCommand,  
   int iInsertAt=-1   
);  
BOOL AddButton(  
   HICON hIcon,  
   LPCTSTR lpszLabel,  
   UINT iIdCommand,  
   int iInsertAt=-1,  
   BOOL bAlphaBlend=FALSE   
);  
```  
  
#### Parameters  
 [in] `uiImage`  
 Specifies the resource identifier of a bitmap.  
  
 [in] `lpszLabel`  
 Specifies the button's text.  
  
 [in] `iIdCommand`  
 Specifies the button control's ID.  
  
 [in] `iInsertAt`  
 Specifies the zero-based index on the outlook bar's page at which to insert the button.  
  
 [in] `uiLabel`  
 A string resource ID.  
  
 [in] `szBmpFileName`  
 Specifies the name of the disk image file to load.  
  
 [in] `szLabel`  
 Specifies the button's text.  
  
 [in] `hBmp`  
 A handle to a button's bitmap.  
  
 [in] `hIcon`  
 A handle to a buttons' icon.  
  
## Return Value  
 `TRUE` if a button was added successfully; otherwise `FALSE`.  
  
## Remarks  
 Use this method to insert a new button into an Outlook bar's page. The button's image can be loaded either from the application resources or from a disk file.  
  
 If the page ID specified by `uiPageID` is -1, the button is inserted into the first page.  
  
 If the index specified by `iInsertAt` is -1, the button is added at the end of the page.  
  
## Requirements  
 **Header:** afxoutlookbarpane.h  
  
## See Also  
 [CMFCOutlookBarPane Class](../vs140/cmfcoutlookbarpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)