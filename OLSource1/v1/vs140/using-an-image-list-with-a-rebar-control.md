---
title: "Using an Image List with a Rebar Control"
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
  - "image lists [C++], rebar controls"
  - "rebar controls, image lists"
ms.assetid: 1a5836ac-019a-46aa-8741-b35c3376b839
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using an Image List with a Rebar Control
Each rebar band can contain, among other things, an image from an associated image list. The following procedure details the necessary steps for displaying an image in a rebar band.  
  
### To display images in a rebar band  
  
1.  Attach an image list to your rebar control object by making a call to [SetImageList](../vs140/crebarctrl--setimagelist.md), passing a pointer to an existing image list.  
  
2.  Modify the **REBARBANDINFO** structure to assign an image to a rebar band:  
  
    -   Set the **fMask** member to **RBBIM_IMAGE**, using the bitwise OR operator to include additional flags as necessary.  
  
    -   Set the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member to the image list index of the image to be displayed.  
  
3.  Initialize any remaining data members, such as the size, text, and handle of the contained child window, with the necessary information.  
  
4.  Insert the new band (with the image) with a call to [CReBarCtrl::InsertBand](../vs140/crebarctrl--insertband.md), passing the **REBARBANDINFO** structure.  
  
 The following example assumes that an existing image list object with two images was attached to the rebar control object (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>). A new rebar band (defined by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>), containing the first image, is added with a call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>:  
  
 [!code[NVC_MFCControlLadenDialog#28](../vs140/codesnippet/CPP/using-an-image-list-with-a-rebar-control_1.cpp)]  
  
## See Also  
 [Using CReBarCtrl](../vs140/using-crebarctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)