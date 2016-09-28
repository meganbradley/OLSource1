---
title: "CStatic::Create"
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
  - "CStatic.Create"
  - "CStatic::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
  - "CStatic class, initialization"
ms.assetid: 2c50841a-fda3-4621-9c31-24729ea6aa52
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatic::Create
Creates the Windows static control and attaches it to the `CStatic` object.  
  
## Syntax  
  
```  
  
      virtual BOOL Create(  
   LPCTSTR lpszText,  
   DWORD dwStyle,  
   const RECT& rect,  
   CWnd* pParentWnd,  
   UINT nID = 0xffff   
);  
```  
  
#### Parameters  
 `lpszText`  
 Specifies the text to place in the control. If **NULL**, no text will be visible.  
  
 `dwStyle`  
 Specifies the static control's window style. Apply any combination of [static control styles](../vs140/static-styles.md) to the control.  
  
 `rect`  
 Specifies the position and size of the static control. It can be either a `RECT` structure or a `CRect` object.  
  
 `pParentWnd`  
 Specifies the `CStatic` parent window, usually a `CDialog` object. It must not be **NULL**.  
  
 `nID`  
 Specifies the static control's control ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Construct a `CStatic` object in two steps. First, call the constructor `CStatic`, and then call **Create**, which creates the Windows static control and attaches it to the `CStatic` object.  
  
 Apply the following [window styles](../vs140/window-styles.md) to a static control:  
  
-   **WS_CHILD** Always  
  
-   **WS_VISIBLE** Usually  
  
-   **WS_DISABLED** Rarely  
  
 If you're going to display a bitmap, cursor, icon, or metafile in the static control, you'll need to apply one of the following [static styles](../vs140/static-styles.md):  
  
-   **SS_BITMAP** Use this style for bitmaps.  
  
-   **SS_ICON** Use this style for cursors and icons.  
  
-   **SS_ENHMETAFILE** Use this style for enhanced metafiles.  
  
 For cursors, bitmaps, or icons, you may also want to use the following style:  
  
-   **SS_CENTERIMAGE** Use to center the image in the static control.  
  
## Example  
 [!code[NVC_MFC_CStatic#1](../vs140/codesnippet/CPP/cstatic--create_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CStatic Class](../vs140/cstatic-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatic::CStatic](../vs140/cstatic--cstatic.md)