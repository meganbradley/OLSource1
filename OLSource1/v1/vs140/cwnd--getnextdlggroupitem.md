---
title: "CWnd::GetNextDlgGroupItem"
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
  - "GetNextDlgGroupItem"
  - "CWnd::GetNextDlgGroupItem"
  - "COleControlSiteOrWnd"
  - "CWnd.GetNextDlgGroupItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextDlgGroupItem method"
ms.assetid: 16911d6f-4ed8-4a18-8763-3ef425a5532e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetNextDlgGroupItem
Searches for the previous or next control within a group of controls in a dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifies the control to be used as the starting point for the search.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies how the function is to search the group of controls in the dialog box. If **TRUE**, the function searches for the previous control in the group; if **FALSE**, it searches for the next control in the group.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Identifies the **COleControlSiteOrWnd** control. For more information about <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, see **Remarks**.  
  
## Return Value  
 Pointer to the previous or next control in the group if the member function is successful.  
  
 The returned pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 A group of controls begins with a control that was created with the [WS_GROUP](../vs140/window-styles.md) style and ends with the last control that was not created with the **WS_GROUP** style.  
  
 By default, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function returns a pointer to the next control in the group. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> identifies the first control in the group and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is **TRUE**, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns a pointer to the last control in the group.  
  
> [!NOTE]
>  Because MFC supports windowless ActiveX controls, standard ActiveX controls, and windows, referring to a control by only an HWND no longer suffices. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object includes information that identifies the object as a windowed ActiveX control, a windowless ActiveX control, or a window, as follows:  
  
|Control or window type|Identifying information|  
|----------------------------|-----------------------------|  
|Windowed ActiveX control|Contains an HWND and associates a [COleControlSite](../vs140/colecontrolsite-class.md) object with it. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to the HWND of the control, and the **m_pSite** member points to the control's <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|Windowless ActiveX control|Contains no <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The **m_pSite** member of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> points to the control's <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and the **m_hWnd** member is **NULL**.|  
|Standard window|Contains just an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> member of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is set to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> of the window, and the **m_pSite** member is **NULL**.|  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetNextDlgTabItem](../vs140/cwnd--getnextdlgtabitem.md)   
 [GetNextDlgGroupItem](http://msdn.microsoft.com/library/windows/desktop/ms645492)