---
title: "Reporting and Printing in LightSwitch"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 3634b67f-1c9b-4542-aa6b-665027b84d04
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reporting and Printing in LightSwitch
[!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] doesn’t include built-in reporting and printing functionality, but you can incorporate reporting and printing into a [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] application in several ways.  
  
## Export to Excel  
 In many cases, you can report and print information if you first export it to Excel. Define a query to return the data for your report, create a screen that's based on the query, and then enable the **Export to Excel** button on the screen. End users can choose the button to export the on-screen data, format the data in Excel, and print it. For more information, see [Exporting Data to Microsoft Excel](../vs140/exporting-data-to-microsoft-excel.md).  
  
> [!NOTE]
>  Export to Excel functionality is available only in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] desktop applications.  
  
## Silverlight User Control  
 For repetitive reporting and printing tasks such as printing an invoice, you might want to create a Silverlight user control. You can lay out fields in the control, bind them to [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] data, and use XAML code to define the appearance. You can then use the resulting control on a screen in your [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] application. For more information, see [Walkthrough: Printing an Invoice](../vs140/walkthrough--printing-an-invoice-from-a-lightswitch-application.md).  
  
> [!NOTE]
>  Silverlight supports vector printing, but best results require a printer that supports PostScript.  
  
## SQL Server Reporting Services  
 You can create, deploy, and manage reports for your organization by using SQL Server Reporting Services, and you can extend and customize your reporting functionality by using programming features. Even if you don’t have a full version of SQL Server, you can still create reports by using Reporting Services in SQL Server Express with Advanced Services. For more information, see [How to: View a SQL Server Reporting Services Report in LightSwitch](../vs140/how-to--view-a-sql-server-reporting-services-report-in-lightswitch.md), [SQL Server Reporting Services](http://go.microsoft.com/fwlink/?LinkId=261815), or [Reporting Services in SQL Server Express with Advanced Services](http://go.microsoft.com/fwlink/?LinkId=261814).  
  
## Office Automation  
 Office provides many built-in solutions for reporting and printing, but you can also use the Office development tools in [!INCLUDE[vs_dev11_pro_long](../vs140/includes/vs_dev11_pro_long_md.md)] to automate the creation of reports and display or print them from your [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] application. For more information, see [Walkthrough: Creating a Report](../vs140/walkthrough--creating-a-report.md).  
  
## Solutions from other vendors  
 You can acquire several [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] extensions that provide reporting and printing capabilities from vendors other than Microsoft. Among other options, you can find and download extensions from the Visual Studio Gallery.  
  
#### To download extensions  
  
1.  On the menu bar, choose **Tools**, **Extensions and Updates**.  
  
2.  In the **Extensions and Updates** dialog box, expand the **Online** node, and then choose **Visual Studio Gallery**.  
  
3.  In the **Search Visual Studio Gallery** text box, enter **LightSwitch**.  
  
4.  In the list that appears, choose an extension, and then choose the **Download** button.  
  
     You will be either prompted to install the extension or directed to the website of the vendor for the extension.