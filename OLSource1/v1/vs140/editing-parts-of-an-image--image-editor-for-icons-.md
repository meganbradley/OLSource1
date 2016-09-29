---
title: "Editing Parts of an Image (Image Editor for Icons)"
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
  - "C++"
helpviewer_keywords: 
  - "Image editor [C++], editing images"
  - "Clipboard [C++], pasting"
  - "images [C++], editing"
  - "images [C++], deleting selected parts"
  - "images [C++], copying selected parts"
  - "images [C++], moving selected parts"
  - "images [C++], dragging and replicating selected parts"
  - "images [C++], pasting into"
  - "graphics [C++], editing"
ms.assetid: ff4f5fef-71a4-4fd8-825e-049399fed391
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Editing Parts of an Image (Image Editor for Icons)
You can perform standard editing operations — cutting, copying, clearing, and moving — on a [selection](../vs140/selecting-an-area-of-an-image--image-editor-for-icons-.md), whether the selection is the entire image or just a part of it. Because the Image editor uses the Windows Clipboard, you can transfer images between the Image editor and other applications for Windows.  
  
 In addition, you can resize the selection, whether it includes the entire image or just a part.  
  
### To cut the current selection and move it to the clipboard  
  
1.  Click **Cut** on the **Edit** menu.  
  
### To copy the selection  
  
1.  Position the pointer inside the selection border or anywhere on it except the sizing handles.  
  
2.  Hold down the **CTRL** key as you drag the selection to a new location. The area of the original selection is unchanged.  
  
3.  To copy the selection into the image at its current location, click outside the selection cursor.  
  
### To paste the clipboard contents into an image  
  
1.  From the **Edit** menu, choose **Paste**.  
  
     The Clipboard contents, surrounded by the selection border, appear in the upper-left corner of the pane.  
  
2.  Position the pointer within the selection border and drag the image to the desired location on the image.  
  
3.  To anchor the image at its new location, click outside of the selection border.  
  
### To delete the current selection without moving it to the clipboard  
  
1.  From the **Edit** menu, choose **Delete**.  
  
     The original area of the selection is filled with the current background color.  
  
    > [!NOTE]
    >  You can access the Cut, Copy, Paste, and Delete commands by right clicking in the Resource View window.  
  
### To move the selection  
  
1.  Position the pointer inside the selection border or anywhere on it except the sizing handles.  
  
2.  Drag the selection to its new location.  
  
3.  To anchor the selection in the image at its new location, click outside the selection border.  
  
 For more information on drawing with a selection, see [Creating a Custom Brush](../vs140/creating-a-custom-brush--image-editor-for-icons-.md).  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5) and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 Requirements  
  
 None  
  
## See Also  
 [Accelerator Keys](../vs140/accelerator-keys--image-editor-for-icons-.md)   
 [Editing Graphical Resources](../vs140/editing-graphical-resources--image-editor-for-icons-.md)   
 [Image Editor for Icons](../vs140/image-editor-for-icons.md)