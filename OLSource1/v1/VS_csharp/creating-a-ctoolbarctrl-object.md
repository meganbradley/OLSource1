---
title: "Creating a CToolBarCtrl Object"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CToolBarCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "toolbar controls [MFC], creating"
  - "CToolBarCtrl class, creating toolbars"
ms.assetid: a4f6bf0c-0195-4dbf-a09e-aee503e19dc3
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating a CToolBarCtrl Object
[CToolBarCtrl](../VS_csharp/ctoolbarctrl-class.md) objects contain several internal data structures — a list of button image bitmaps, a list of button label strings, and a list of `TBBUTTON` structures — that associate an image and/or string with the position, style, state, and command ID of the button. Each of the elements of these data structures is referred to by a zero-based index. Before you can use a `CToolBarCtrl` object, you must set up these data structures. For a list of the data structures, see [Toolbar Controls](https://msdn.microsoft.com/en-us/library/47xcww9x.aspx) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)]. The list of strings can only be used for button labels; you cannot retrieve strings from the toolbar.  
  
 To use a `CToolBarCtrl` object, you will typically follow these steps:  
  
### To use a CToolBarCtrl object  
  
1.  Construct the [CToolBarCtrl](../VS_csharp/ctoolbarctrl-class.md) object.  
  
2.  Call [Create](../Topic/CToolBarCtrl::Create.md) to create the Windows toolbar common control and attach it to the `CToolBarCtrl` object. If you want bitmap images for buttons, add the button bitmaps to the toolbar by calling [AddBitmap](../Topic/CToolBarCtrl::AddBitmap.md). If you want string labels for buttons, add the strings to the toolbar by calling [AddString](../Topic/CToolBarCtrl::AddString.md) and/or [AddStrings](../Topic/CToolBarCtrl::AddStrings.md). After calling `AddString` and/or `AddStrings`, you should call [AutoSize](../Topic/CToolBarCtrl::AutoSize.md) in order to get the string or strings to appear.  
  
3.  Add button structures to the toolbar by calling [AddButtons](../Topic/CToolBarCtrl::AddButtons.md).  
  
4.  If you want tool tips, handle **TTN_NEEDTEXT** messages in the toolbar's owner window as described in [Handling Tool Tip Notifications](../VS_csharp/handling-tool-tip-notifications.md).  
  
5.  If you want your user to be able to customize the toolbar, handle customization notification messages in the owner window as described in [Handling Customization Notifications](../VS_csharp/handling-customization-notifications.md).  
  
## See Also  
 [Using CToolBarCtrl](../VS_csharp/using-ctoolbarctrl.md)   
 [Controls (MFC)](../VS_csharp/controls--mfc-.md)