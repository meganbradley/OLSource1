---
title: "COleControlSite::CreateControl"
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
  - "COleControlSite.CreateControl"
  - "COleControlSite::CreateControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateControl method"
  - "COleControlSite class, operations"
ms.assetid: d62654ab-eec1-4e55-b13c-a103400de5f1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::CreateControl
Creates an ActiveX control, hosted by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the window object representing the control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The unique class ID of the control.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the text to be displayed in the control. Sets the value of the winodw's Caption or Text property (if any).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Windows styles. The available styles are listed under the **Remarks** section.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the control's size and position. It can be either a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object or a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the control's child window ID.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> containing the persistent state for the control. The default value is **NULL**, indicating that the control initializes itself without restoring its state from any persistent storage. If not **NULL**, it should be a pointer to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>-derived object that contains the control's persistent data, in the form of either a stream or a storage. This data could have been saved in a previous activation of the client. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> can contain other data, but must have its read-write pointer set to the first byte of persistent data at the time of the call to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Indicates whether the data in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> should be interpreted as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> data. If the data in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a storage, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> should be **TRUE**. If the data in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a stream, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> should be **FALSE**. The default value is **FALSE**.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Optional license key data. This data is needed only for creating controls that require a run-time license key. If the control supports licensing, you must provide a license key for the creation of the control to succeed. The default value is **NULL**.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A pointer to a **POINT** structure that contains the upper-left corner of the control. The size of the control is determined by the value of *psize*. The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and *psize* values are an optional method of specifying the size and position opf the control.  
  
 *psize*  
 A pointer to a **SIZE** structure that contains the size of the control. The upper-left corner is determined by the value of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and *psize* values are an optional method of specifying the size and position opf the control.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> value.  
  
## Remarks  
 Only a subset of the Windows <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> flags are supported by <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>:  
  
-   **WS_VISIBLE** Creates a window that is initially visible. Required if you want the control to be visible immediately, like ordinary windows.  
  
-   **WS_DISABLED** Creates a window that is initially disabled. A disabled window cannot receive input from the user. Can be set if the control has an Enabled property.  
  
-   <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> Creates a window with a thin-line border. Can be set if control has a BorderStyle property.  
  
-   **WS_GROUP** Specifies the first control of a group of controls. The user can change the keyboard focus from one control in the group to the next by using the direction keys. All controls defined with the **WS_GROUP** style after the first control belong to the same group. The next control with the **WS_GROUP** style ends the group and starts the next group.  
  
-   **WS_TABSTOP** Specifies a control that can receive the keyboard focus when the user presses the TAB key. Pressing the TAB key changes the keyboard focus to the next control of the **WS_TABSTOP** style.  
  
 Use the second overload to create default-sized controls.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControlContainer::CreateControl](../vs140/colecontrolcontainer--createcontrol.md)