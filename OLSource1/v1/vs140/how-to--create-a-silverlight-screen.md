---
title: "How to: Create a Silverlight Screen"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - screens [Visual Studio LightSwitch], creating
ms.assetid: 23a28691-5ac7-4099-8671-df5c1bae6131
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Create a Silverlight Screen
Create a screen to display or collect information.  
  
##  <a name="CreatingASCreen"></a> To create a screen  
  
1.  On the **Project** menu, click **Add Screen**.  
  
     The **Add New Screen** dialog box appears.  
  
2.  Under **Select a screen template**, select the type of screen that you want to create.  
  
     To learn more about screen types, see [Choosing a Screen Type](../vs140/choosing-a-screen-type.md).  
  
3.  In the **Screen Name** box, type a name for the screen.  
  
4.  Under **Screen Data**, select a query from the drop-down list.  
  
     This specifies what data appears on the screen.  
  
5.  Under **Additional Data to Include**, select any related data to display on the screen.  
  
     This section lists entities or tables that are related to the data that you selected in the previous step. If you selected a query in the previous step, this section lists entities or tables related to the source data of the query that you selected. For more information about related data, see [How to: Create Relationships between Entities](../vs140/how-to--define-data-relationships-in-lightswitch.md).  
  
    > [!NOTE]
    >  The **Additional Data to Include** section appears in the **Add New Screen** dialog box only if you are creating a **New Data Screen**, a **Details Screen**, or a **List and Details Screen** screen.  
  
6.  Click **OK** to close the **Add New Screen** dialog box.  
  
     [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] creates a new screen and opens the screen in the screen designer.  
  
## See Also  
 [Screens: What the User Sees](../vs140/screens--the-user-interface-of-your-lightswitch-application.md)   
 [Choosing a Screen Type](../vs140/choosing-a-screen-type.md)   
 [How to: Customize a Screen by Using the Screen Designer](../vs140/how-to--design-a-silverlight-screen-by-using-the-screen-designer.md)