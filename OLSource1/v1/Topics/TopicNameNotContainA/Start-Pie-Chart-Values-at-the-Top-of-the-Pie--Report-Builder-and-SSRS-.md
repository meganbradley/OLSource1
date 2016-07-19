---
title: Start Pie Chart Values at the Top of the Pie (Report Builder and SSRS)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d0e6fb59-ca4e-4d70-97cb-0ad183da21d3
manager: mblythe
---
# Start Pie Chart Values at the Top of the Pie (Report Builder and SSRS)
By default in pie charts, the first value in the dataset starts at 90 degrees from the top of the pie. You may prefer that the first value start from the top.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
### To Start the Pie Chart at the Top of the Pie  
  
1.  Click the pie itself.  
  
2.  If the **Properties** pane is not open, on the **View** tab, click **Properties**.  
  
3.  In the **Properties** pane, under **Custom Attributes**, change **PieStartAngle** from **0** to **270**.  
  
4.  Click **Run** to preview your report.  
  
 The first value now starts at the top of the pie chart.  
  
## See Also  
 [Formatting a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Formatting-a-Chart--Report-Builder-and-SSRS-.md)   
 [Pie Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Pie-Charts--Report-Builder-and-SSRS-.md)