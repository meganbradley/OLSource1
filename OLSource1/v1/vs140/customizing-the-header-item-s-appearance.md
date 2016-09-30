---
title: "Customizing the Header Item&#39;s Appearance"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "header controls, customization of items"
  - "CHeaderCtrl class, customizing the items"
  - "HDS_ styles"
ms.assetid: b1e1e326-ec7d-4dbd-a46f-96a3e2055618
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Customizing the Header Item&#39;s Appearance
By setting the *dwStyle* parameter when you first create a header control ([CHeaderCtrl::Create](../vs140/cheaderctrl--create.md)), you can define the appearance and behavior of header items or of the header control itself.  
  
 Here is a sampling of the styles you can set, and their purpose:  
  
-   To make a header item look like a pushbutton, use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> style.  
  
     Use this style if you want to carry out actions in response to mouse clicks on a header item, such as sorting data by a particular column, as is done in Microsoft Outlook.  
  
-   To give the header items a "hot tracking" appearance when the mouse cursor passes over them, use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> style.  
  
     Hot tracking displays a 3D outline as the pointer passes over an item in an otherwise flat bar.  
  
-   To indicate that the header control should be hidden, use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> style.  
  
     The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> style indicates that the header control is intended to be used as a data container and not a visual control. This style does not automatically hide the control but, instead, affects the behavior of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The value returned in the **cy** member of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure will be zero indicating that the control should not be visible to the user.  
  
 For more information about these properties, see [Items](http://msdn.microsoft.com/library/windows/desktop/bb775238) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For information about adding items to a header control, see [Adding Items to the Header Control](../vs140/adding-items-to-the-header-control.md).  
  
## See Also  
 [Using CHeaderCtrl](../vs140/using-cheaderctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)