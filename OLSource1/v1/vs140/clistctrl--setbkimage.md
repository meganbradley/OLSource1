---
title: "CListCtrl::SetBkImage"
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
  - "SetBkImage"
  - "CListCtrl.SetBkImage"
  - "CListCtrl::SetBkImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBkImage method"
ms.assetid: 0d3ad581-125e-427b-9b68-45d9377d0d07
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetBkImage
Sets the background image of a list view control.  
  
## Syntax  
  
```  
  
      BOOL SetBkImage(  
   LVBKIMAGE* plvbkImage   
);  
BOOL SetBkImage(  
   HBITMAP hbm,  
   BOOL fTile = TRUE,  
   int xOffsetPercent = 0,  
   int yOffsetPercent = 0  
);  
BOOL SetBkImage(  
   LPTSTR pszUrl,  
   BOOL fTile = TRUE,  
   int xOffsetPercent = 0,  
   int yOffsetPercent = 0   
);  
```  
  
#### Parameters  
 `plvbkImage`  
 Address of an **LVBKIMAGE** structure, containing the new background image information.  
  
 `hbm`  
 Handle to a bitmap.  
  
 `pszUrl`  
 A **NULL**-terminated string that contains the URL of the background image.  
  
 *fTile*  
 Nonzero if the image is to be tiled in the background of the list view control; otherwise 0.  
  
 *xOffsetPercent*  
 The offset, in pixels, of the image's left edge, from origin of the list view control.  
  
 *yOffsetPercent*  
 The offset, in pixels, of the image's top edge, from origin of the list view control.  
  
## Return Value  
 Returns nonzero if successful, or zero otherwise.  
  
## Remarks  
  
> [!NOTE]
>  Because `CListCtrl::SetBkImage` makes use of OLE COM functionality, the OLE libraries must be initialized before using `SetBkImage`. It is best to initialize the COM libraries when the application is initialized and uninitialize the libraries when the application terminates. This is automatically done in MFC applications that make use of ActiveX technology, OLE Automation, OLE Linking/Embedding, or ODBC/DAO operations.  
  
## Example  
 See the example for [CListCtrl::GetBkImage](../vs140/clistctrl--getbkimage.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetBkImage](../vs140/clistctrl--getbkimage.md)