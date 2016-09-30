---
title: "Image Menu (Image Editor for Icons)"
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
  - "vc.editors.bitmap"
dev_langs: 
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "Image menu"
ms.assetid: ac2b4d53-1919-4fd1-a0af-d3c085c45af2
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Image Menu (Image Editor for Icons)
The Image menu, which appears only when the Image editor is active, has commands for editing images, managing color palettes, and setting Image Editor window options. In addition, commands for using device images are available when working with icons and cursors.  
  
 **Invert Colors**  
 Inverts your colors. For more information, see [Inverting the Colors in a Selection](../vs140/inverting-the-colors-in-a-selection--image-editor-for-icons-.md).  
  
 **Flip Horizontal**  
 Flips the image or selection horizontally. For more information, see [Flipping an Image](../vs140/flipping-an-image--image-editor-for-icons-.md).  
  
 **Flip Vertical**  
 Flips the image or selection vertically. For more information, see [Flipping an Image](../vs140/flipping-an-image--image-editor-for-icons-.md).  
  
 **Rotate 90 Degrees**  
 Rotates the image or selection 90 degrees. For more information, see [Flipping an Image](../vs140/flipping-an-image--image-editor-for-icons-.md).  
  
 **Show Colors Window**  
 Opens the [Colors window](../vs140/colors-window--image-editor-for-icons-.md), in which you can choose the colors to use for your image. For more information, see [Working with Color](../vs140/working-with-color--image-editor-for-icons-.md).  
  
 **Use Selection as Brush**  
 Enables you to create a custom brush from a portion of an image. Your selection becomes a custom brush that distributes the colors in the selection across the image. Copies of the selection are left along the dragging path. The more slowly you drag, the more copies are made. For more information, see [Creating a Custom Brush](../vs140/creating-a-custom-brush--image-editor-for-icons-.md).  
  
 **Copy and Outline Selection**  
 Creates a copy of the current selection and outlines it. If the background color is contained in the current selection, it will be excluded if you have [transparent](../vs140/choosing-a-transparent-or-opaque-background--image-editor-for-icons-.md) selected.  
  
 **Adjust Colors**  
 Opens the [Custom Color Selector](../vs140/custom-color-selector-dialog-box--image-editor-for-icons-.md), which allows you to customize the colors you use for your image. For more information, see [Customizing or Changing Colors](../vs140/customizing-or-changing-colors--image-editor-for-icons-.md).  
  
 **Load Palette**  
 Opens the [Load Color Palette dialog box](../vs140/load-palette-colors-dialog-box--image-editor-for-icons-.md), which enables you to load palette colors previously saved to a .pal file.  
  
 **Save Palette**  
 Saves the palette colors to a .pal file.  
  
 **Draw Opaque**  
 When selected, makes the current selection opaque. When cleared, makes the current selection transparent. For more information, see [Choosing an Opaque or Transparent Background](../vs140/choosing-a-transparent-or-opaque-background--image-editor-for-icons-.md).  
  
 **Toolbar Editor**  
 Opens the [New Toolbar Resource dialog box](../vs140/new-toolbar-resource-dialog-box.md).  
  
 **Grid Settings**  
 Opens the [Grid Settings dialog box](../vs140/grid-settings-dialog-box--image-editor-for-icons-.md) in which you can specify grids for your image.  
  
 **New Image Type**  
 Opens the [New \<Device> Image Type dialog box](../vs140/new--device--image-type-dialog-box--image-editor-for-icons-.md). A single icon resource can contain several images of different sizes; windows can use the appropriate icon size depending on how it is going to be displayed. A new device type does not modify the size of the icon, but rather creates a new image within the icon. Only applies to icons and cursors.  
  
 **Current Icon/Cursor Image Type**  
 Opens a submenu that lists the first available cursor or icon images (the first nine). The last command on the submenu, **More...**, opens the [Open \<Device> Image dialog box](../vs140/open--device--image-dialog-box--image-editor-for-icons-.md).  
  
 **Delete Image Type**  
 Deletes the selected device image.  
  
 **Tools**  
 Launches a submenu which contains all the tools available from the [Image Editor toolbar](../vs140/toolbar--image-editor-for-icons-.md).  
  
## Requirements  
 None  
  
## See Also  
 [Accelerator Keys](../vs140/accelerator-keys--image-editor-for-icons-.md)   
 [Image Editor for Icons](../vs140/image-editor-for-icons.md)