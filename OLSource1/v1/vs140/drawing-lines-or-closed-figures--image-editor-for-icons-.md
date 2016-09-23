---
title: "Drawing Lines or Closed Figures (Image Editor for Icons)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
  - C++
helpviewer_keywords: 
  - closed figures, drawing
  - lines [C++], painting
  - lines [C++], drawing
  - Image editor [C++], drawing lines
  - shapes, drawing
ms.assetid: 7edd86db-77b1-451f-8001-bbfed9c6304f
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Drawing Lines or Closed Figures (Image Editor for Icons)
The Image editor tools for drawing lines and closed figures all work in the same way: you place the insertion point at one point and drag to another. For lines, these points are the endpoints. For closed figures, these points are opposite corners of a rectangle bounding the figure.  
  
 Lines are drawn in a width determined by the current brush selection, and framed figures are drawn in a width determined by the current width selection. Lines and all figures, both framed and filled, are drawn in the current foreground color if you press the left mouse button, or in the current background color if you press the right mouse button.  
  
### To draw a line  
  
1.  On the [Image Editor toolbar](../vs140/toolbar--image-editor-for-icons-.md) (or from the **Image** menu, **Tools** command), click the **Line** tool.  
  
2.  If necessary, select colors and a brush:  
  
    -   In the [Colors palette](../vs140/colors-window--image-editor-for-icons-.md), click the left mouse button to select a foreground color or the right mouse button to select a background color.  
  
    -   In the [Options selector](../vs140/toolbar--image-editor-for-icons-.md), click a shape representing the brush you want to use.  
  
3.  Place the pointer at the line's starting point.  
  
4.  Drag to the line's endpoint.  
  
### To draw a closed figure  
  
1.  On the **Image Editor** toolbar (or from the **Image** menu, **Tools** command), click a **Closed-Figure Drawing** tool.  
  
     The **Closed-Figure Drawing** tools create figures as indicated on their respective buttons.  
  
2.  If necessary, select colors and a line width.  
  
3.  Move the pointer to one corner of the rectangular area in which you want to draw the figure.  
  
4.  Drag the pointer to the diagonally opposite corner.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5) and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 Requirements  
  
 None  
  
## See Also  
 [Accelerator Keys](../vs140/accelerator-keys--image-editor-for-icons-.md)   
 [Editing Graphical Resources](../vs140/editing-graphical-resources--image-editor-for-icons-.md)   
 [Image Editor for Icons](../vs140/image-editor-for-icons.md)   
 [Working with Color](../vs140/working-with-color--image-editor-for-icons-.md)