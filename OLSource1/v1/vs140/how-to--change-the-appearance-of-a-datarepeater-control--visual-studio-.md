---
title: "How to: Change the Appearance of a DataRepeater Control (Visual Studio)"
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
  - "DataRepeater, customizing"
  - "DataRepeater, changing run time appearance"
ms.assetid: 2af6dfce-760b-489e-b863-8da967f315c3
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Change the Appearance of a DataRepeater Control (Visual Studio)
You can change the appearance of a <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control at design time by setting properties or at run time by handling the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.DrawItem*> event.  
  
 Properties that you set at design time when the item template section of the control is selected will be repeated for each <xref:Microsoft.VisualBasic.PowerPacks.DataRepeaterItem*> at run time. Appearance-related properties of the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control itself will be visible at run time only if a part of the container is left uncovered (for example, if the <xref:System.Windows.Forms.Control.Padding*> property is set to a large value).  
  
 At run time, appearance-related properties can be set based on conditions. For example, in a scheduling application, you might change the background color of an item to warn users when an item is past due. In the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.DrawItem*> event handler, if you set a property in a conditional statement such as `If…Then`, you must also use an `Else` clause to specify the appearance when the condition is not met.  
  
### To change the appearance at design time  
  
1.  In the Windows Forms Designer, select the item template (upper) region of the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control.  
  
2.  In the Properties window, select a property and change the value. Common properties that affect appearance include <xref:System.Windows.Forms.Control.BackColor*>, <xref:System.Windows.Forms.Control.BackgroundImage*>, <xref:System.Windows.Forms.Panel.BorderStyle*>, and <xref:System.Windows.Forms.Control.ForeColor*>.  
  
### To change the appearance at run time  
  
1.  In the Code Editor, in the Event drop-down list, click **DrawItem**.  
  
2.  In the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.DrawItem*> event handler, add code to set the properties:  
  
     [!code[VbPowerPacksDataRepeaterAppearance#1](../vs140/codesnippet/CSharp/how-to--change-the-appearance-of-a-datarepeater-control--visual-studio-_1.cs)]
[!code[VbPowerPacksDataRepeaterAppearance#1](../vs140/codesnippet/VisualBasic/how-to--change-the-appearance-of-a-datarepeater-control--visual-studio-_1.vb)]  
  
## Example  
 Some common customizations for the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control include displaying the rows in alternating colors and changing the color of a field based on a condition. The following example shows how to perform these customizations. This example assumes that you have a <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control that is bound to the Products table in the Northwind database.  
  
 [!code[VbPowerPacksDataRepeaterAlternateBackColor#1](../vs140/codesnippet/VisualBasic/how-to--change-the-appearance-of-a-datarepeater-control--visual-studio-_2.vb)]
[!code[VbPowerPacksDataRepeaterAlternateBackColor#1](../vs140/codesnippet/CSharp/how-to--change-the-appearance-of-a-datarepeater-control--visual-studio-_2.cs)]  
  
 Note that for both of these customizations, you must provide code to set the properties for both sides of the condition. If you do not specify the `Else` condition, you will see unexpected results at run time.  
  
## See Also  
 <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*>   
 <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.DrawItem*>   
 [Introduction to the DataRepeater Control (Visual Basic)](../vs140/introduction-to-the-datarepeater-control--visual-studio-.md)   
 [Troubleshooting the DataRepeater Control (Visual Basic)](../vs140/troubleshooting-the-datarepeater-control--visual-studio-.md)   
 [How to: Display Bound Data in a DataRepeater Control (Visual Basic)](../vs140/how-to--display-bound-data-in-a-datarepeater-control--visual-studio-.md)   
 [How to: Display Unbound Data in a DataRepeater Control (Visual Basic)](../vs140/how-to--display-unbound-controls-in-a-datarepeater-control--visual-studio-.md)   
 [How to: Display Item Headers in a DataRepeater Control (Visual Basic)](../vs140/how-to--display-item-headers-in-a-datarepeater-control--visual-studio-.md)