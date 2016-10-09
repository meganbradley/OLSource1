---
title: "How to: Show Add-in User Interface Errors"
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
  - "add-ins [Office development in Visual Studio], user interface errors"
  - "errors [Office development in Visual Studio], user interface errors"
  - "user interfaces [Office development in Visual Studio], errors"
  - "application-level add-ins [Office development in Visual Studio], user interface errors"
ms.assetid: aa82cc04-e616-4501-940c-79d11fb393cc
caps.latest.revision: 27
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
# How to: Show Add-in User Interface Errors
  By default, if an VSTO Add-in attempts to manipulate the Microsoft Office user interface (UI) and fails, no error message is displayed. However, you can configure Microsoft Office applications to display messages for errors that relate to the UI. You can use these messages to help determine why a custom Ribbon does not appear, or why a Ribbon appears but no controls appear.  
  
 [!INCLUDE[appliesto_ribbon](../VS_officedev/includes/appliesto_ribbon_md.md)]  
  
### To show VSTO Add-in user interface errors  
  
1.  Start the application.  
  
2.  Click the **File** tab.  
  
3.  Click **Options**.  
  
4.  In the categories pane, click **Advanced**.  
  
5.  In the details pane, select **Show VSTO Add-in user interface errors**, and then click **OK**.  
  
    > [!NOTE]  
    >  For Outlook, the **Show VSTO Add-in user interface errors** checkbox is located in the **Developer** section of the details pane. For other applications, the checkbox is located in the **General** section of the details pane.  
  
## See Also  
 [Office UI Customization](../VS_officedev/office-ui-customization.md)   
 [Creating Outlook Form Regions](../VS_officedev/creating-outlook-form-regions.md)   
 [Ribbon Overview](../VS_officedev/ribbon-overview.md)   
 [Actions Pane Overview](../VS_officedev/actions-pane-overview.md)  
  
  