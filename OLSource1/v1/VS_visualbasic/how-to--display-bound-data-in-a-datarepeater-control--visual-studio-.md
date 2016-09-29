---
title: "How to: Display Bound Data in a DataRepeater Control (Visual Studio)"
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
  - "DataRepeater, data-binding"
  - "DataRepeater, displaying bound controls"
ms.assetid: 56a15326-1334-4275-af4e-075cad79e6f7
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Display Bound Data in a DataRepeater Control (Visual Studio)
The most common use of the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control is to display bound data from a database or other data source.  
  
 In addition to bound controls, you may want to add other controls, such as a static label or an image that is repeated on each item in the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control. For more information, see [How to: Display Unbound Data in a DataRepeater Control (Visual Basic)](../VS_csharp/how-to--display-unbound-controls-in-a-datarepeater-control--visual-studio-.md).  
  
 You can also bind to a data source at run time by setting the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.VirtualMode*> property to `True` and assigning a data source to the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.DataSource*> property. In this case, you will need to manage all interaction with the data source. For more information, see [Virtual Mode in the DataRepeater Control (Visual Studio)](../VS_csharp/virtual-mode-in-the-datarepeater-control--visual-studio-.md).  
  
 [!INCLUDE[note_settings_general](../VS_csharp/includes/note_settings_general_md.md)]  
  
### To create a data-bound DataRepeater  
  
1.  Drag a <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control from the **Visual Basic PowerPacks** tab in the **Toolbox** to a form or container control.  
  
2.  Drag the sizing and position handles to size and position the control.  
  
     Note that the control has two rectangular regions. The upper region is the *item template*; controls added to the template will be repeated in each item in the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control at run time. The lower region is the *viewport*, where the items will be displayed.  
  
     You can also size and position the control or the item template by changing the **Size** and **Position** properties in the Properties window.  
  
3.  On the **Data** menu, click **Show Data Sources**.  
  
    > [!NOTE]
    >  If the **Data Sources** window is empty, add a data source to it. For more information, see [Data Sources Overview](assetId:///ed28c625-bb89-4037-bfde-cfa435d182a2).  
  
4.  In the **Data Sources** window, select the top-level node for the table that contains the data that you want to bind.  
  
5.  Change the drop type of the table to `Details` by clicking `Details` in the drop-down list on the table node.  
  
6.  Select the table node and drag it onto the item template region of the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control.  
  
     You can specify which types of controls are displayed for each field. For more information, see [How to: Set the Control to be Created when Dragging from the Data Sources Window](assetId:///20597ff8-0c98-43ec-8fb1-05376804ba48).  
  
## See Also  
 <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*>   
 [Introduction to the DataRepeater Control (Visual Basic)](../VS_csharp/introduction-to-the-datarepeater-control--visual-studio-.md)   
 [How to: Display Unbound Data in a DataRepeater Control (Visual Basic)](../VS_csharp/how-to--display-unbound-controls-in-a-datarepeater-control--visual-studio-.md)   
 [How to: Create a Master/Detail Form by Using Two DataRepeater Controls (Visual Basic)](../VS_csharp/how-to--create-a-master-detail-form-by-using-two-datarepeater-controls--visual-studio-.md)   
 [How to: Change the Appearance of a DataRepeater Control (Visual Basic)](../VS_csharp/how-to--change-the-appearance-of-a-datarepeater-control--visual-studio-.md)   
 [Troubleshooting the DataRepeater Control (Visual Basic)](../VS_csharp/troubleshooting-the-datarepeater-control--visual-studio-.md)