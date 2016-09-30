---
title: "Using Image Lists in a Toolbar Control"
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
  - "toolbar controls [MFC], image"
  - "image lists [C++], toolbar controls"
  - "CToolBarCtrl class, image lists"
ms.assetid: ccbe8df4-4ed9-4b54-bb93-9a1dcb3b97eb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Image Lists in a Toolbar Control
By default, the images used by the buttons in a toolbar control are stored as a single bitmap. However, you can also store button images in a set of image lists. The toolbar control object can use up to three separate image lists:  
  
-   Enabled image list   Contains images for toolbar buttons that are currently enabled.  
  
-   Disabled image list   Contains images for toolbar buttons that are currently disabled.  
  
-   Highlighted image list   Contains images for toolbar buttons that are currently highlighted. This image list is used only when the toolbar uses the **TBSTYLE_FLAT** style.  
  
 These image lists are used by the toolbar control when you associate them with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object. This association is accomplished by making calls to [CToolBarCtrl::SetImageList](../vs140/ctoolbarctrl--setimagelist.md), [SetDisabledImageList](../vs140/ctoolbarctrl--setdisabledimagelist.md), and [SetHotImageList](../vs140/ctoolbarctrl--sethotimagelist.md).  
  
 By default, MFC uses the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class to implement MFC application toolbars. However, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function can be used to retrieve the embedded <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. You can then make calls to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member functions using the returned object.  
  
 The following example demonstrates this technique by assigning an enabled (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) and disabled (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) image list to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>).  
  
 [!code[NVC_MFCControlLadenDialog#35](../vs140/codesnippet/CPP/using-image-lists-in-a-toolbar-control_1.cpp)]  
  
> [!NOTE]
>  The image lists used by the toolbar object must be permanent objects. For this reason, they are commonly data members of an MFC class; in this example, the main frame window class.  
  
 Once the image lists are associated with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object, the framework automatically displays the proper button image.  
  
## See Also  
 [Using CToolBarCtrl](../vs140/using-ctoolbarctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)