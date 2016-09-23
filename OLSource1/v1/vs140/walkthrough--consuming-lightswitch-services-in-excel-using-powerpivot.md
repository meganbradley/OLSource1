---
title: "Walkthrough: Consuming LightSwitch Services in Excel Using PowerPivot"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f173f11b-c8da-4af0-ba32-cca9b5269439
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Walkthrough: Consuming LightSwitch Services in Excel Using PowerPivot
By following this walkthrough, you can use [!INCLUDE[Excel_14_long](../vs140/includes/excel_14_long_md.md)] to analyze data from a [!INCLUDE[smb_current_long](../vs140/includes/smb_current_long_md.md)] application. First, you'll create a feed for that data through the OpenData Protocol (OData), which is how [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] applications that are based on the web expose their data. You'll then open the data in PowerPivot, which is an add-in for [!INCLUDE[Excel_14_short](../vs140/includes/excel_14_short_md.md)] and one of many applications that can parse OData information.  
  
## Prerequisites  
 To complete this walkthrough, you must install the following products:  
  
-   [!INCLUDE[vs_dev11_pro_long](../vs140/includes/vs_dev11_pro_long_md.md)]  
  
-   [!INCLUDE[Excel_14_short](../vs140/includes/excel_14_short_md.md)]  
  
-   [PowerPivot for Microsoft Excel 2010](http://go.microsoft.com/fwlink/?LinkID=205332)  
  
 In addition, the walkthrough uses the Vision Clinic sample application, which you can download from the [MSDN Samples Gallery](http://go.microsoft.com/fwlink/?LinkID=208915) or create by completing the steps in [Walkthrough: Creating the Vision Clinic Application](../vs140/walkthrough--creating-the-vision-clinic-application-in-lightswitch.md). As an alternative, you can use your own [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] application by substituting your application name for Vision Clinic and your data source name for PrescriptionContoso where they appear.  
  
### To expose data through an OData feed  
  
1.  In **Solution Explorer**, open the shortcut menu for **Properties** and choose **Open**.  
  
     The Application Designer opens.  
  
2.  On the **Application Type** tab, in the **Client** section, choose the **Web** option button.  
  
     The data from both the **ApplicationData** and **PrescriptionContoso** data sources will be exposed as OData feeds.  
  
3.  Choose the F5 key to run the application.  
  
4.  In the web browser, copy the first part of the URL from the **Address Bar**. It should look like `http://localhost:#####/`, where *#####* is a numeric value.  
  
### To access OData data from PowerPivot  
  
1.  In [!INCLUDE[Excel_14_short](../vs140/includes/excel_14_short_md.md)], on the menu bar, choose **PowerPivot**, **PowerPivot Window**.  
  
     The **PowerPivot for Excel** window opens.  
  
2.  On the menu bar, choose **Get External Data**, **From Data Feeds**.  
  
     The **Table Import Wizard** opens.  
  
3.  In the **Friendly connection name** text box, enter `Vision Clinic Products`.  
  
4.  In the **Data Feed URL** text box, enter the URL that you copied in the previous procedure, and append `PrescriptionContoso.svc` to it. It should look like `http://localhost:#####/PrescriptionContoso.svc`, where `#####` is a numeric value.  
  
    > [!TIP]
    >  You can choose the **Test Connection** button to make sure that you entered the correct URL.  
  
5.  Choose the **Next** button.  
  
6.  On the **Select Tables and Views** page, select the **Products** check box.  
  
7.  Choose the **Finish** button, wait for the data to be imported, and then choose the **Close** button.  
  
     The data appears in the **PowerPivot** window, and you can create PivotTable and PivotChart reports from the data.  
  
## Next Steps  
 For more information about PowerPivot, open Help by choosing the F1 key in the **PowerPivot** window.  
  
## See Also  
 [LightSwitch as a Data Source](../vs140/lightswitch-as-a-data-source.md)   
 [Exposing LightSwitch Application Data](../vs140/exposing-lightswitch-application-data.md)