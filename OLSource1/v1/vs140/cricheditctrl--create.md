---
title: "CRichEditCtrl::Create"
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
  - "CRichEditCtrl::Create"
  - "CRichEditCtrl.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: 3546c313-6d8d-4716-9708-ce82d1e4e563
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::Create
Creates the Windows rich edit control and associates it with this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the edit control's style. Apply a combination of the window styles listed in the **Remarks** section below, and [edit control styles](http://msdn.microsoft.com/library/windows/desktop/bb775464), described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the edit control's size and position. Can be a [CRect](../vs140/crect-class.md) object or [RECT](../vs140/rect-structure.md) structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the edit control's parent window (often a [CDialog](../vs140/cdialog-class.md)). It must not be **NULL**.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the edit control's ID.  
  
## Return Value  
 Nonzero if initialization is successful; otherwise, 0.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object in two steps. First, call the [CRichEditCtrl](../vs140/cricheditctrl--cricheditctrl.md) constructor, then call **Create**, which creates the Windows edit control and attaches it to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 When you create a rich edit control with this function, first you must load the necessary common controls library. To load the libary, call the global function [AfxInitRichEdit](../vs140/afxinitrichedit.md), which in turn initializes the common controls library. You need to call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> only once in your process.  
  
 When **Create** executes, Windows sends the [WM_NCCREATE](../vs140/cwnd--onnccreate.md), [WM_NCCALCSIZE](../vs140/cwnd--onnccalcsize.md), [WM_CREATE](../vs140/cwnd--oncreate.md), and [WM_GETMINMAXINFO](../vs140/cwnd--ongetminmaxinfo.md) messages to the edit control.  
  
 These messages are handled by default by the [OnNcCreate](../vs140/cwnd--onnccreate.md), [OnNcCalcSize](../vs140/cwnd--onnccalcsize.md), [OnCreate](../vs140/cwnd--oncreate.md), and [OnGetMinMaxInfo](../vs140/cwnd--ongetminmaxinfo.md) member functions in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> base class. To extend the default message handling, derive a class from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, add a message map to the new class, and override the above message-handler member functions. Override <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, for example, to perform needed initialization for the new class.  
  
 Apply the following [window styles](../vs140/window-styles.md) to an edit control.  
  
-   **WS_CHILD** Always.  
  
-   **WS_VISIBLE** Usually.  
  
-   **WS_DISABLED** Rarely.  
  
-   **WS_GROUP** To group controls.  
  
-   **WS_TABSTOP** To include edit control in the tabbing order.  
  
 For more information about window styles, see [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#5](../vs140/codesnippet/CPP/cricheditctrl--create_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::CreateEx](../vs140/cricheditctrl--createex.md)   
 [CRichEditCtrl::CRichEditCtrl](../vs140/cricheditctrl--cricheditctrl.md)