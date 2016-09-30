---
title: "How to: Add Data to a Screen"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "screens [Visual Studio LightSwitch], adding data"
  - "screens [Visual Studio LightSwitch], adding queries"
ms.assetid: b00a798a-80eb-4b0b-b57f-ee08066f434c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add Data to a Screen
You can add groups of data to a screen. The data can come from any data source in a [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] application.  
  
### To add data to a screen  
  
1.  At the top of the **Screen Designer**, click **Add Data Item**.  
  
2.  In the **Add Data Item** dialog box, select **Query**.  
  
3.  In the list of queries, select a query that returns the data that you want. Queries that end with the label **(All)** return a collection of data. Queries that end with the label **(Single)** return an individual item of data.  
  
4.  In the **Name** box, type a name, and then click **OK**.  
  
     The query that you selected appears in the screen members list.  
  
5.  From the **Screen Members List**, drag the query onto the desired area of the **Screen Content Tree**.  
  
     If the query returns a collection of data, a group appears in the **Screen Content Tree**. This group contains the fields of data returned by the query.  
  
     If the query returns an individual item of data, a control that is appropriate for displaying an individual item of data, such as a text box, appears in the **Screen Content Tree**.  
  
## Next Steps  
 Add commands to the group. For more information, see [How to: Add a Custom Command to a Screen](../vs140/how-to--add-a-custom-command-to-a-silverlight-screen.md) or [How to: Add a Custom Command to an HTML Screen](../vs140/how-to--add-a-button-to-a-mobile-client-for-lightswitch.md).  
  
 Customize how the data in the group is filtered. For more information, see [How to: Filter Data on a Screen](../vs140/how-to--filter-data-on-a-silverlight-screen.md) or [How to: Filter Data on an HTML Screen](../vs140/how-to--filter-data-in-an-html-client-for-a-lightswitch-app.md).  
  
 Move groups to other positions on the screen or change the layout of the data in the group. For more information, see [How to: Design a Screen by Using the Screen Designer](../vs140/how-to--design-a-silverlight-screen-by-using-the-screen-designer.md) or [How to: Design an HTML Screen by Using the Screen Designer](../vs140/how-to--design-an-html-screen-by-using-the-screen-designer.md).  
  
## See Also  
 [Screens: The User Interface of Your Application](../vs140/screens--the-user-interface-of-your-lightswitch-application.md)