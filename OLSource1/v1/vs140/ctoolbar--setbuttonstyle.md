---
title: "CToolBar::SetButtonStyle"
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
  - "CToolBar.SetButtonStyle"
  - "CToolBar::SetButtonStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetButtonStyle method"
  - "CToolBar class, construction/destruction"
  - "toolbar controls [MFC], style"
  - "toolbar controls [MFC], grouping"
ms.assetid: 05b3f897-7aad-45e2-9a10-e1a12e416e2e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBar::SetButtonStyle
Call this member function to set the style of a button or separator, or to group buttons.  
  
## Syntax  
  
```  
  
      void SetButtonStyle(  
   int nIndex,  
   UINT nStyle   
);  
```  
  
#### Parameters  
 `nIndex`  
 Index of the button or separator whose information is to be set.  
  
 `nStyle`  
 The button style. The following button styles are supported:  
  
-   **TBBS_BUTTON** Standard pushbutton (default)  
  
-   **TBBS_SEPARATOR** Separator  
  
-   **TBBS_CHECKBOX** Auto check-box button  
  
-   **TBBS_GROUP** Marks the start of a group of buttons  
  
-   **TBBS_CHECKGROUP** Marks the start of a group of check-box buttons  
  
-   **TBBS_DROPDOWN** Creates a drop-down list button  
  
-   **TBBS_AUTOSIZE** The button's width will be calculated based on the text of the button, not on the size of the image  
  
-   **TBBS_NOPREFIX** The button text will not have an accelerator prefix associated with it  
  
## Remarks  
 A button's style determines how the button appears and how it responds to user input.  
  
 Before calling `SetButtonStyle`, call the [GetButtonStyle](../vs140/ctoolbar--getbuttonstyle.md) member function to retrieve the button or separator style.  
  
> [!NOTE]
>  You can also set button states using the `nStyle` parameter; however, because button states are controlled by the [ON_UPDATE_COMMAND_UI](../vs140/on_update_command_ui.md) handler, any state you set using `SetButtonStyle` will be lost during the next idle processing. See [How to Update User-Interface Objects](../vs140/how-to--update-user-interface-objects.md) and [TN031: Control Bars](../vs140/tn031--control-bars.md) for more information.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::GetButtonStyle](../vs140/ctoolbar--getbuttonstyle.md)