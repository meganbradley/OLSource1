---
title: "CToolBarCtrl::Create"
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
  - "CToolBarCtrl.Create"
  - "CCS_NOMOVEY"
  - "TBSTYLE_TOOLTIPS"
  - "CCS_NOPARENTALIGN"
  - "CCS_TOP"
  - "TBSTYLE_WRAPABLE"
  - "CCS_NOHILITE"
  - "CCS_BOTTOM"
  - "CCS_NORESIZE"
  - "CCS_ADJUSTABLE"
  - "CCS_NODIVIDER"
  - "CToolBarCtrl::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCS_NORESIZE constant"
  - "CCS_NOMOVEY constant"
  - "CCS_TOP constant"
  - "Create method [C++]"
  - "CCS_NOPARENTALIGN constant"
  - "CCS_BOTTOM constant"
  - "CCS_NOHILITE constant"
  - "CCS_ADJUSTABLE constant"
  - "TBSTYLE_WRAPABLE constant"
  - "CCS_NODIVIDER constant"
ms.assetid: 380788be-0f0d-4a81-9cee-52bafe6c8235
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::Create
Creates a toolbar control and attaches it to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the toolbar control's style. Toolbars must always have the **WS_CHILD** style. In addition, you can specify any combination of toolbar styles and window styles as described under **Remarks**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optionally specifies the toolbar control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the toolbar control's parent window. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the toolbar control's ID.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in two steps. First, call the constructor, and then call **Create**, which creates the toolbar control and attaches it to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. Apply the following window styles to a toolbar control.  
  
-   **WS_CHILD** Always  
  
-   **WS_VISIBLE** Usually  
  
-   **WS_DISABLED** Rarely  
  
 See [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a description of window styles.  
  
 Optionally, apply a combination of [common control styles](http://msdn.microsoft.com/library/windows/desktop/bb775498), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Apply a combination of toolbar styles to either the control or the buttons themselves. The styles are described in the topic [Toolbar Control and Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb760439) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 To use extended toolbar styles, call [SetExtendedStyle](../vs140/ctoolbarctrl--setextendedstyle.md) after you call **Create**. To create a toolbar with extended window styles, call [CToolBarCtrl::CreateEx](../vs140/ctoolbarctrl--createex.md) instead of **Create**.  
  
 The toolbar control automatically sets the size and position of the toolbar window. The height is based on the height of the buttons in the toolbar. The width is the same as the width of the parent window's client area. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> styles determine whether the toolbar is positioned along the top or bottom of the client area. By default, a toolbar has the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> style.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::CToolBarCtrl](../vs140/ctoolbarctrl--ctoolbarctrl.md)   
 [CToolBarCtrl::SetButtonStructSize](../vs140/ctoolbarctrl--setbuttonstructsize.md)