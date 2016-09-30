---
title: "How to: Change the Layout of a DataRepeater Control (Visual Studio)"
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
  - "DataRepeater, changing layout style"
  - "DataRepeater, changing orientation"
ms.assetid: 33aa8fd5-ac63-4bd0-ba13-8c2ab17e7824
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Change the Layout of a DataRepeater Control (Visual Studio)
The \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control can be displayed in either a vertical (items scroll vertically) or horizontal (items scroll horizontally) orientation. You can change the orientation at design time or at run time by changing the \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.LayoutStyle*> property. If you change the \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.LayoutStyle*> property at run time, you may also want to resize the \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemTemplate*> and reposition the child controls.  
  
> [!NOTE]
>  If you reposition controls on the \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemTemplate*> at run time, you will need to call the \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.BeginResetItemTemplate*> and \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.EndResetItemTemplate*> methods at the beginning and end of the code block that repositions the controls.  
  
### To change the layout at design time  
  
1.  In the Windows Forms Designer, select the \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control.  
  
    > [!NOTE]
    >  You must select the outer border of the \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control by clicking in the lower region of the control, not in the upper \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemTemplate*> region.  
  
2.  In the Properties window, set the \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.LayoutStyle*> property to either \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeaterLayoutStyles.Vertical*> or \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeaterLayoutStyles.Horizontal*>.  
  
### To change the layout at run time  
  
1.  Add the following code to a button or menu <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> event handler:  
  
     [!code[VbPowerPacksDataRepeaterLayout#1](../vs140/codesnippet/CSharp/how-to--change-the-layout-of-a-datarepeater-control--visual-studio-_1.cs)]
[!code[VbPowerPacksDataRepeaterLayout#1](../vs140/codesnippet/VisualBasic/how-to--change-the-layout-of-a-datarepeater-control--visual-studio-_1.vb)]  
  
2.  In most cases, you will want to add code similar to that shown in the Example section to resize the \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemTemplate*> and rearrange controls to fit the new orientation.  
  
## Example  
 The following example shows how to respond to the \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.LayoutStyleChanged*> event in an event handler. This example requires that you have a \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control named <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> on a form and that its \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemTemplate*> contain two \<xref:System.Windows.Forms.TextBox*> controls named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [!code[VbPowerPacksDataRepeaterLayout#2](../vs140/codesnippet/CSharp/how-to--change-the-layout-of-a-datarepeater-control--visual-studio-_2.cs)]
[!code[VbPowerPacksDataRepeaterLayout#2](../vs140/codesnippet/VisualBasic/how-to--change-the-layout-of-a-datarepeater-control--visual-studio-_2.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*>   
 \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.LayoutStyle*>   
 \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.BeginResetItemTemplate*>   
 \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.EndResetItemTemplate*>   
 [Introduction to the DataRepeater Control (Visual Basic)](../vs140/introduction-to-the-datarepeater-control--visual-studio-.md)   
 [Troubleshooting the DataRepeater Control (Visual Basic)](../vs140/troubleshooting-the-datarepeater-control--visual-studio-.md)   
 [How to: Change the Appearance of a DataRepeater Control (Visual Basic)](../vs140/how-to--change-the-appearance-of-a-datarepeater-control--visual-studio-.md)