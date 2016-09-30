---
title: "CComboBox::Create"
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
  - "CComboBox.Create"
  - "CComboBox::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
  - "CComboBox class, initialization"
ms.assetid: 4886d704-7054-4ea4-b8d1-fd55d0500cf2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::Create
Creates the combo box and attaches it to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the style of the combo box. Apply any combination of [combo-box styles](../vs140/combo-box-styles.md) to the box.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the position and size of the combo box. Can be a [RECT](../vs140/rect-structure.md) structure or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the combo box's parent window (usually a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>). It must not be **NULL**.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the combo box's control ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object in two steps. First, call the constructor and then call **Create**, which creates the Windows combo box and attaches it to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
 When **Create** executes, Windows sends the [WM_NCCREATE](../vs140/cwnd--onnccreate.md), [WM_CREATE](../vs140/cwnd--oncreate.md), [WM_NCCALCSIZE](../vs140/cwnd--onnccalcsize.md), and [WM_GETMINMAXINFO](../vs140/cwnd--ongetminmaxinfo.md) messages to the combo box.  
  
 These messages are handled by default by the [OnNcCreate](../vs140/cwnd--onnccreate.md), [OnCreate](../vs140/cwnd--oncreate.md), [OnNcCalcSize](../vs140/cwnd--onnccalcsize.md), and [OnGetMinMaxInfo](../vs140/cwnd--ongetminmaxinfo.md) member functions in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> base class. To extend the default message handling, derive a class from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, add a message map to the new class, and override the preceding message-handler member functions. Override <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, for example, to perform needed initialization for a new class.  
  
 Apply the following [window styles](../vs140/window-styles.md) to a combo-box control. :  
  
-   **WS_CHILD** Always  
  
-   **WS_VISIBLE** Usually  
  
-   **WS_DISABLED** Rarely  
  
-   **WS_VSCROLL** To add vertical scrolling for the list box in the combo box  
  
-   **WS_HSCROLL** To add horizontal scrolling for the list box in the combo box  
  
-   **WS_GROUP** To group controls  
  
-   **WS_TABSTOP** To include the combo box in the tabbing order  
  
## Example  
 [!code[NVC_MFC_CComboBox#2](../vs140/codesnippet/CPP/ccombobox--create_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::CComboBox](../vs140/ccombobox--ccombobox.md)   
 [Combo-Box Styles](../vs140/combo-box-styles.md)