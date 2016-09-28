---
title: "How to: Draw Lines with the LineShape Control (Visual Studio)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "LineShape control"
  - "lines, drawing"
ms.assetid: 83e71b4e-aa76-4f9b-b547-8704309fd1e5
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Draw Lines with the LineShape Control (Visual Studio)
You can use the <xref:Microsoft.VisualBasic.PowerPacks.LineShape*> control to draw horizontal, vertical, or diagonal lines on a form or container, both at design time and at run time.  
  
 **Note** Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To draw a line at design time  
  
1.  Drag the <xref:Microsoft.VisualBasic.PowerPacks.LineShape*> control from the **Visual Basic PowerPacks** tab in the **Toolbox** drag to a form or container control.  
  
2.  Drag the sizing and move handles to size and position the line.  
  
     You can also size and position the line by changing the `X1`, `X2`, `Y1`, and `Y2` properties in the **Properties** window.  
  
3.  In the **Properties** window, optionally set additional properties such as `BorderStyle` or `BorderColor` to change the appearance of the line.  
  
### To draw a line at run time  
  
1.  On the **Project** menu, click **Add Reference**.  
  
2.  In the **Add Reference** dialog box, select **Microsoft.VisualBasic.PowerPacks.VS**, and then click **OK**.  
  
3.  In the **Code Editor**, add an `Imports` or `using` statement at the top of the module:  
  
    ```vb#  
    Imports Microsoft.VisualBasic.PowerPacks  
    ```  
  
    ```c#  
    using Microsoft.VisualBasic.PowerPacks;  
    ```  
  
4.  Add the following code in an `Event` procedure:  
  
     [!code[VbPowerPacksLine#1](../vs140/codesnippet/CSharp/how-to--draw-lines-with-the-lineshape-control--visual-studio-_1.cs)][!code[VbPowerPacksLine#1](../vs140/codesnippet/VisualBasic/how-to--draw-lines-with-the-lineshape-control--visual-studio-_1.vb)]  
  
## See Also  
 <xref:Microsoft.VisualBasic.PowerPacks.LineShape*>   
 [Introduction to the Line and Shape Controls (Visual Basic)](../vs140/introduction-to-the-line-and-shape-controls--visual-studio-.md)   
 [How to: Draw Shapes with the OvalShape and RectangleShape Controls (Visual Basic)](../vs140/how-to--draw-shapes-with-the-ovalshape-and-rectangleshape-controls--visual-studio-.md)