---
title: "CCheckListBox::Create"
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
  - "CCheckListBox.Create"
  - "CCheckListBox::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: b46bc47a-e7a6-4e2e-ae54-368ec2c0b390
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCheckListBox::Create
Creates the Windows checklist box and attaches it to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the style of the checklist box. The style must be **LBS_HASSTRINGS** and either **LBS_OWNERDRAWFIXED** (all items in the list are the same height) or **LBS_OWNERDRAWVARIABLE** (items in the list are of varying heights). This style can be combined with other [list-box styles](../vs140/list-box-styles.md) except **LBS_USETABSTOPS**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the checklist-box size and position. Can be either a [CRect](../vs140/crect-class.md) object or a [RECT](../vs140/rect-structure.md) structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the checklist box's parent window (usually a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object). It must not be **NULL**.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the checklist box's control ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object in two steps. First, define a class derived from **CcheckListBox** and then call **Create**, which initializes the Windows checklist box and attaches it to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. See [CCheckListBox::CCheckListBox](../vs140/cchecklistbox--cchecklistbox.md) for a sample.  
  
 When **Create** executes, Windows sends the [WM_NCCREATE](../vs140/cwnd--onnccreate.md), [WM_CREATE](../vs140/cwnd--oncreate.md), [WM_NCCALCSIZE](../vs140/cwnd--onnccalcsize.md), and [WM_GETMINMAXINFO](../vs140/cwnd--ongetminmaxinfo.md) messages to the checklist-box control.  
  
 These messages are handled by default by the [OnNcCreate](../vs140/cwnd--onnccreate.md), [OnCreate](../vs140/cwnd--oncreate.md), [OnNcCalcSize](../vs140/cwnd--onnccalcsize.md), and [OnGetMinMaxInfo](../vs140/cwnd--ongetminmaxinfo.md) member functions in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> base class. To extend the default message handling, add a message map to the your derived class and override the preceding message-handler member functions. Override <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, for example, to perform needed initialization for a new class.  
  
 Apply the following [window styles](../vs140/window-styles.md) to a checklist-box control:  
  
-   **WS_CHILD** Always  
  
-   **WS_VISIBLE** Usually  
  
-   **WS_DISABLED** Rarely  
  
-   **WS_VSCROLL** To add a vertical scroll bar  
  
-   **WS_HSCROLL** To add a horizontal scroll bar  
  
-   **WS_GROUP** To group controls  
  
-   **WS_TABSTOP** To allow tabbing to this control  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCheckListBox Class](../vs140/cchecklistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCheckListBox::CCheckListBox](../vs140/cchecklistbox--cchecklistbox.md)