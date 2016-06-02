---
title: Format Text in a Text Box (Report Builder and SSRS)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: df0794b5-96b0-4034-bd17-1be7f31e29db
---
# Format Text in a Text Box (Report Builder and SSRS)
  You can format any part of the text within a text box independently, and mix placeholder text and static text in one text box. This ability to mix formats and add placeholder text enables you to create mail merges or templates for text in your report. Any expression can be defined and formatted separately using a placeholder.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Token\Other/ssRBRDDup_md.md)]  
  
### To combine multiple formats in a text box  
  
1.  On the **Insert** tab, click **Text Box**. Click the design surface, and then drag to create a box that is the size you want.  
  
2.  Inside the text box, select the text you want to format.  
  
3.  Right\-click the selected text, and click **Text Properties**.  
  
4.  Set formatting options. For example, on the **General** tab:  
  
    -   **Tooltip** Type text or an expression that evaluates to a ToolTip. The ToolTip appears when the user pauses the pointer over the item in a report  
  
    -   **Markup type** Select an option to indicate how the selected text will be rendered:  
  
         **Plain Text** Display the selected text as simple text. HTML will be treated as literal text.  
  
         **HTML**  Display the selected text as HTML. If the expression value of the placeholder contains valid HTML tags, these tags will be rendered as HTML. For more information, see [Importing HTML into a Report &#40;Report Builder and SSRS&#41;](../Topic/Importing%20HTML%20into%20a%20Report%20\(Report%20Builder%20and%20SSRS\).md).  
  
5.  Click **OK**.  
  
6.  Repeat steps 2 through 5 for the remaining text you want to format.  
  
### To format text and placeholders differently in the same text box  
  
1.  On the **Insert** tab, click **List**. Click the design surface, and then drag to create a box that is the size you want. The **Dataset Properties** dialog box opens. You can use a shared dataset or a dataset embedded in your report. For more information, click [Dataset Properties Dialog Box, Query &#40;Report Builder&#41;](../Topic/Dataset%20Properties%20Dialog%20Box,%20Query%20\(Report%20Builder\).md) or [Dataset Properties Dialog Box, Query](../../Topics\TopicNameNotContainA/Dataset-Properties-Dialog-Box,-Query.md).  
  
2.  On the **Insert** tab, click **Text Box**. Click in the list, and then drag to create a box that is the size you want.  
  
3.  Type a label in the text box — for example, **My Field**:.  
  
4.  Drag a field from your dataset into the text box. A placeholder is created for your field.  
  
5.  For basic formatting, select the placeholder text and then click one of the formatting options in the **Font** group on the **Home** tab. For example, click the **Bold** button.  
  
     For more formatting options, right\-click the placeholder text, and then click **Placeholder Properties**.  
  
6.  Click **OK**. In report design view, the text box should contain "**My Field**: \[*FieldName*\]", where *FieldName* is the name of your field.  
  
7.  Click **Run**.  
  
 The list repeats one time for every value in the field, and the *FieldName* placeholder is replaced each time by the value of that field in the dataset.  
  
## See Also  
 [Text Boxes &#40;Report Builder and SSRS&#41;](../Topic/Text%20Boxes%20\(Report%20Builder%20and%20SSRS\).md)   
 [Formatting Text and Placeholders &#40;Report Builder and SSRS&#41;](../Topic/Formatting%20Text%20and%20Placeholders%20\(Report%20Builder%20and%20SSRS\).md)   
 [Expression Uses in Reports &#40;Report Builder and SSRS&#41;](../Topic/Expression%20Uses%20in%20Reports%20\(Report%20Builder%20and%20SSRS\).md)   
 [Expression Examples &#40;Report Builder and SSRS&#41;](../Topic/Expression%20Examples%20\(Report%20Builder%20and%20SSRS\).md)   
 [Add HTML into a Report &#40;Report Builder and SSRS&#41;](../Topic/Add%20HTML%20into%20a%20Report%20\(Report%20Builder%20and%20SSRS\).md)   
 [Tables, Matrices, and Lists &#40;Report Builder and SSRS&#41;](../Topic/Tables,%20Matrices,%20and%20Lists%20\(Report%20Builder%20and%20SSRS\).md)   
 [Formatting Numbers and Dates &#40;Report Builder and SSRS&#41;](../Topic/Formatting%20Numbers%20and%20Dates%20\(Report%20Builder%20and%20SSRS\).md)   
 [Placeholder Properties Dialog Box, General &#40;Report Builder and SSRS&#41;](../Topic/Placeholder%20Properties%20Dialog%20Box,%20General%20\(Report%20Builder%20and%20SSRS\).md)  
  
  