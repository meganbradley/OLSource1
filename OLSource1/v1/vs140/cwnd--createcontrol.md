---
title: "CWnd::CreateControl"
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
  - "CWnd::CreateControl"
  - "CWnd.CreateControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateControl method"
  - "CWnd class, OLE controls"
  - "CWnd class, control creation"
ms.assetid: c992b8d3-d824-451f-a094-c71f5e50f622
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::CreateControl
Use this member function to create an ActiveX control that will be represented in the MFC program by a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pszClass*  
 This string may contain the OLE "short name" (ProgID) for the class, e.g., "CIRC3.Circ3Ctrl.1". The name needs to match the same name registered by the control. Alternatively, the string may contain the string form of a **CLSID**, contained in braces, e.g., "{9DBAFCCF-592F-101B-85CE-00608CEC297B}". In either case, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> converts the string to the corresponding class ID.  
  
 *pszWindowName*  
 A pointer to the text to be displayed in the control. Sets the value of the control's Caption or Text property (if any). If **NULL**, the control's Caption or Text property is not changed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Windows styles. The available styles are listed under Remarks.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](../vs140/rect-structure.md) structure.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Points to a [POINT](../vs140/point-structure.md) structure or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that contains the upper left corner of the control.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Points to a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object that contains the control's size  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the control's parent window. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the control's ID.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to a [CFile](../vs140/cfile-class.md) containing the persistent state for the control. The default value is **NULL**, indicating that the control initializes itself without restoring its state from any persistent storage. If not **NULL**, it should be a pointer to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>-derived object which contains the control's persistent data, in the form of either a stream or a storage. This data could have been saved in a previous activation of the client. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> can contain other data, but must have its read-write pointer set to the first byte of persistent data at the time of the call to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Indicates whether the data in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> should be interpreted as IStorage or IStream data. If the data in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a storage, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> should be **TRUE**. If the data in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a stream, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> should be **FALSE**. The default value is **FALSE**.  
  
 *bstrLicKe*y  
 Optional license key data. This data is needed only for creating controls that require a run-time license key. If the control supports licensing, you must provide a license key for the creation of the control to succeed. The default value is **NULL**.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The unique class ID of the control.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a direct analog of the [CWnd::Create](../vs140/cwnd--create.md) function, which creates the window for a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> creates an ActiveX control instead of an ordinary window.  
  
 Only a subset of the Windows <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> flags are supported for <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>:  
  
-   **WS_VISIBLE** Creates a window that is initially visible. Required if you want the control to be visible immediately, like ordinary windows.  
  
-   **WS_DISABLED** Creates a window that is initially disabled. A disabled window cannot receive input from the user. Can be set if the control has an Enabled property.  
  
-   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> Creates a window with a thin-line border. Can be set if control has a BorderStyle property.  
  
-   **WS_GROUP** Specifies the first control of a group of controls. The user can change the keyboard focus from one control in the group to the next by using the direction keys. All controls defined with the **WS_GROUP** style after the first control belong to the same group. The next control with the **WS_GROUP** style ends the group and starts the next group.  
  
-   **WS_TABSTOP** Specifies a control that can receive the keyboard focus when the user presses the TAB key. Pressing the TAB key changes the keyboard focus to the next control of the **WS_TABSTOP** style.  
  
## Example  
 [!code[NVC_MFCWindowing#81](../vs140/codesnippet/CPP/cwnd--createcontrol_1.h)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)