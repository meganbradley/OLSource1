---
title: "Event Logging for Office Solutions"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Office applications [Office development in Visual Studio], event viewer"
  - "ClickOnce deployment [Office development in Visual Studio], event viewer"
  - "deploying applications [Office development in Visual Studio], event viewer"
  - "Office development in Visual Studio, event viewer"
ms.assetid: 31a246fe-ce1c-4f0e-9a21-9cf974c247fe
caps.latest.revision: 33
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Event Logging for Office Solutions
  You can use the event viewer in Windows to see exception messages that are captured by the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] when you install or uninstall Office solutions. You can use these messages from the event logger to resolve installation and deployment problems.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
## Reading the Event Log  
 Open **Event Viewer** and filter for the events you want to see.  
  
#### To read the event log in Windows Server 2003 and Windows XP  
  
1.  In Control Panel, open **Administrative Tools**.  
  
2.  Start **Event Viewer**.  
  
3.  In the list of event logs, select **Application**.  
  
4.  On the **View** menu, click **Filter**.  
  
5.  In the **Event source** list, select **VSTO 4.0**.  
  
6.  For installation events, in the **Event ID** box, type **4096**.  
  
7.  Click **OK** to see the filtered view.  
  
#### To read the event log in Windows 7, Windows Vista, and Windows Server 2008  
  
1.  In Control Panel, open **Administrative Tools**.  
  
2.  Start **Event Viewer**.  
  
3.  Expand **Windows Logs**.  
  
4.  In the list of event logs, select **Application**.  
  
5.  On the **Action** menu, click **Filter Current Log**.  
  
6.  In the **Event source** list, select **VSTO 4.0**.  
  
7.  For installation events, in the **Event ID** box, type **4096**.  
  
8.  Click **OK** to see the filtered view.  
  
 The event viewer includes the following information:  
  
-   The location of the deployment manifest for the solution.  
  
-   A message that describes the cause of the error or exception.  
  
 These exception messages can help you determine the reason for an installation problem, such as an untrusted certificate, an untrusted document location, or an invalid deployment manifest.  
  
 After an Office solution is uninstalled, the exception messages remain in the event log.  
  
 To show or log exception messages when an Office solution is running, see [Debugging Office Projects](../VS_officedev/debugging-office-projects.md) and [Debugging Office Projects](../VS_officedev/debugging-office-projects.md).  
  
### Localization  
 The language of the exception message is determined by the Visual Studio Tools for Office runtime language. For instance, if the end user computer has the Japanese language pack installed, the exception message is written to the event log in Japanese.  
  
## Disabling the Event Logger  
 By default, the event logger is enabled when you install or uninstall Office solutions. You can disable the event logger by setting the VSTO_EVENTLOGDISABLED environment variable to "1" (one).  
  
#### To disable the event log  
  
1.  In Control Panel, open **System**.  
  
2.  On the **Advanced** tab, click **Environment Variables**.  
  
3.  In the **System variables** pane, click **New**.  
  
4.  In the **New System Variable** dialog box, type **VSTO_EVENTLOGDISABLED** in the **Variable name** box.  
  
5.  In the **Variable value** box, type **1**.  
  
6.  Click **OK**.  
  
## See Also  
 [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md)   
 [Troubleshooting Office Solution Deployment](../VS_officedev/troubleshooting-office-solution-deployment.md)  
  
  