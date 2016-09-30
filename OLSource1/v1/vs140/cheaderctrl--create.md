---
title: "CHeaderCtrl::Create"
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
  - "HDS_HIDDEN"
  - "HDS_BUTTONS"
  - "HDS_FULLDRAG"
  - "HDS_DRAGDROP"
  - "HDS_HOTTRACK"
  - "CHeaderCtrl::Create"
  - "HDS_VERT"
  - "HDS_HORZ"
  - "CHeaderCtrl.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCS_NORESIZE constant"
  - "CCS_NOMOVEY constant"
  - "CCS_TOP constant"
  - "Create method [C++]"
  - "HDS_HOTTRACK"
  - "CCS_NOPARENTALIGN constant"
  - "CCS_BOTTOM constant"
  - "HDS_VERT"
  - "CCS_NOHILITE constant"
  - "HDS_HORZ"
  - "HDS_BUTTONS"
  - "CCS_NODIVIDER constant"
  - "HDS_FULLDRAG"
  - "HDS_HIDDEN"
  - "HDS_DRAGDROP"
ms.assetid: d75b8f01-6678-435e-96a7-3963f64c24ae
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::Create
Creates a header control and attaches it to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the header control's style. For a description of header control styles, see [Header Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775241) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the header control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the header control's parent window, usually a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the header control's ID.  
  
## Return Value  
 Nonzero if initialization was successful; otherwise zero.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object in two steps. First, call the constructor and then call **Create**, which creates the header control and attaches it to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 In addition to the header control styles, you can use the following common control styles to determine how the header control positions and resizes itself (see [Common Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775498) for more information):  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> Causes the control to position itself at the bottom of the parent window's client area and sets the width to be the same as the parent window's width.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Prevents a two-pixel highlight from being drawn at the top of the control.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> Causes the control to resize and move itself horizontally, but not vertically, in response to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> message. If the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> style is used, this style does not apply. Header controls have this style by default.  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> Prevents the control from automatically moving to the top or bottom of the parent window. Instead, the control keeps its position within the parent window despite changes to the size of the parent window. If the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> style is also used, the height is adjusted to the default, but the position and width remain unchanged.  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> Prevents the control from using the default width and height when setting its initial size or a new size. Instead, the control uses the width and height specified in the request for creation or sizing.  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> Causes the control to position itself at the top of the parent window's client area and sets the width to be the same as the parent window's width.  
  
 You can also apply the following window styles to a header control (see [Window Styles](../vs140/window-styles.md) for more information):  
  
-   **WS_CHILD** Creates a child window. Cannot be used with the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> style.  
  
-   **WS_VISIBLE** Creates a window that is initially visible.  
  
-   **WS_DISABLED** Creates a window that is initially disabled.  
  
-   **WS_GROUP** Specifies the first control of a group of controls in which the user can move from one control to the next with the arrow keys. All controls defined with the **WS_GROUP** style after the first control belong to the same group. The next control with the **WS_GROUP** style ends the style group and starts the next group (that is, one group ends where the next begins).  
  
-   **WS_TABSTOP** Specifies one of any number of controls through which the user can move by using the TAB key. The TAB key moves the user to the next control specified by the **WS_TABSTOP** style.  
  
 If you want to use extended windows styles with your control, call [CreateEx](../vs140/cheaderctrl--createex.md) instead of **Create**.  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#4](../vs140/codesnippet/CPP/cheaderctrl--create_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::CHeaderCtrl](../vs140/cheaderctrl--cheaderctrl.md)