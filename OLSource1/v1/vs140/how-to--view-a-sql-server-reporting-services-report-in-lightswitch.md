---
title: "How to: View a SQL Server Reporting Services Report in LightSwitch"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 2d33eabf-ef74-431b-8231-23af51daf802
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: View a SQL Server Reporting Services Report in LightSwitch
LightSwitch doesn’t have built-in reporting capabilities, but you can use SQL Server Reporting Services to create reports and view them from a LightSwitch application. Reports appear in a browser window from which you can print and export them to several file formats.  
  
 You can create, deploy, and manage reports for your organization by using SQL Server Reporting Services, and you can extend and customize your reporting functionality by using a variety of programming features. Even if you don’t have a full version of SQL Server, you can still create reports by using [Reporting Services in SQL Server Express with Advanced Services](http://go.microsoft.com/fwlink/?LinkId=261812), which you can download for free.  
  
### To view a report  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Client** project node, and then choose **Add Reference**.  
  
2.  In the **Add Reference** dialog box, expand the **Assemblies** node, choose the **Framework** node, select the **System.Windows.Browser** check box, and then choose the **OK** button.  
  
3.  In **Solution Explorer**, open the shortcut menu for your screen, and then choose **Open**.  
  
4.  In the screen designer, expand the **Screen Command Bar** node, choose the **Add** node, and then choose **New Button**.  
  
5.  In the **Add Button** dialog box, choose the **New Method** option button, name the button that you're creating, and then choose the **OK** button.  
  
6.  In the screen designer, open the shortcut menu for the new button, and then choose **Edit Execute Code**.  
  
7.  In the **Code Editor**, add the following **Imports** or **using** statements:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
8.  Add the following code to open the report, replacing the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with the URL for your report and replacing <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> with the name of your button:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     The report appears in a new browser window.  
  
    > [!TIP]
    >  You can construct a URL for a report that includes report parameters, passwords, rendering format, and more. For more information, see [URL Access](http://go.microsoft.com/fwlink/?LinkId=261808).  
  
## See Also  
 [SQL Server Reporting Services](http://go.microsoft.com/fwlink/?LinkId=261815)   
 [Reporting Services in SQL Server Express with Advanced Services](http://go.microsoft.com/fwlink/?LinkId=261814)   
 [Reporting and Printing in LightSwitch](../vs140/reporting-and-printing-in-lightswitch.md)