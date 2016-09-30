---
title: "CEdit::Create"
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
  - "CEdit::Create"
  - "CEdit.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
  - "CEdit class, initialization"
ms.assetid: c0b0c36c-d27d-48f5-92d8-e9ed9fad1261
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::Create
Creates the Windows edit control and attaches it to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the edit control's style. Apply any combination of [edit styles](../vs140/edit-styles.md) to the control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the edit control's size and position. Can be a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the edit control's parent window (usually a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>). It must not be **NULL**.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies the edit control's ID.  
  
## Return Value  
 Nonzero if initialization is successful; otherwise 0.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object in two steps. First, call the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> constructor and then call **Create**, which creates the Windows edit control and attaches it to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
 When **Create** executes, Windows sends the [WM_NCCREATE](http://msdn.microsoft.com/library/windows/desktop/ms632635), [WM_NCCALCSIZE](http://msdn.microsoft.com/library/windows/desktop/ms632634), [WM_CREATE](http://msdn.microsoft.com/library/windows/desktop/ms632619), and [WM_GETMINMAXINFO](http://msdn.microsoft.com/library/windows/desktop/ms632626) messages to the edit control.  
  
 These messages are handled by default by the [OnNcCreate](../vs140/cwnd--onnccreate.md), [OnNcCalcSize](../vs140/cwnd--onnccalcsize.md), [OnCreate](../vs140/cwnd--oncreate.md), and [OnGetMinMaxInfo](../vs140/cwnd--ongetminmaxinfo.md) member functions in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> base class. To extend the default message handling, derive a class from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, add a message map to the new class, and override the above message-handler member functions. Override <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, for example, to perform needed initialization for the new class.  
  
 Apply the following [window styles](../vs140/window-styles.md) to an edit control.  
  
-   **WS_CHILD** Always  
  
-   **WS_VISIBLE** Usually  
  
-   **WS_DISABLED** Rarely  
  
-   **WS_GROUP** To group controls  
  
-   **WS_TABSTOP** To include edit control in the tabbing order  
  
## Example  
 [!code[NVC_MFC_CEdit#2](../vs140/codesnippet/CPP/cedit--create_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::CEdit](../vs140/cedit--cedit.md)