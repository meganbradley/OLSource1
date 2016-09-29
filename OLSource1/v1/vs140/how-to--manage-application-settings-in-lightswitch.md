---
title: "How to: Manage Application Settings in LightSwitch"
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
  - "application display name [Visual Studio LightSwitch]"
  - "application icon [Visual Studio LightSwitch]"
  - "application version [Visual Studio LightSwitch]"
  - "theme [Visual Studio LightSwitch]"
  - "culture [Visual Studio LightSwitch]"
  - "version [Visual Studio LightSwitch]"
  - "application settings [Visual Studio LightSwitch]"
  - "icon [Visual Studio LightSwitch]"
  - "application properties [Visual Studio LightSwitch]"
  - "shell [Visual Studio LightSwitch]"
  - "background image [Visual Studio LightSwitch]"
  - "logo image [Visual Studio LightSwitch]"
ms.assetid: 7d4ac834-4572-40fa-a5f0-f875f6c2b846
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Manage Application Settings in LightSwitch
In Visual Studio LightSwitch, you can manage settings that apply to the application instead of an individual screen or entity. You manage these settings in the **Application Designer**, which contains tabs on which you can set general, extensions, access control, and SharePoint properties.  
  
 This topic covers settings on the **General Properties** tab. For information about settings on other tabs, see [Managing Settings in LightSwitch](../vs140/managing-settings-in-lightswitch.md).  
  
> [!NOTE]
>  For desktop client projects, client-specific application settings appear on the **Client Properties** tab, which you access by choosing the **Edit Client properties** link on the **General Properties** tab.  
  
 You can manage the following settings on the **General Properties** tab:  
  
|Setting|Description|  
|-------------|-----------------|  
|**Application version**|Specifies a major and minor version number for the application. The default value of this setting is 1.0. The maximum version number is 65334.9999.|  
|**SQL Database Project**|Specifies the SQL Database project to associate with the application. You can use the project to manage the intrinsic database and specify scripts that run before, during, and after deployment (for example, to populate a table during deployment).|  
|**Default Language**|Specifies a default localization culture for the application. The default value of this setting is the culture of the development computer.<br /><br /> See [Walkthrough: Localizing a LightSwitch Application](../vs140/walkthrough--localizing-a-lightswitch-application.md).|  
  
### To change the application version  
  
1.  In **Solution Explorer**, expand the top-level project node and open the shortcut menu for the **Properties** node, and then choose **Open**.  
  
2.  In the **Application Designer**, choose the **General Properties** tab.  
  
3.  In the **Application version** field, enter a major version number in the first text box, and then enter a minor version number in the second text box.  
  
     You must specify an integer between 0 and 65534.  
  
### To change the culture  
  
1.  In **Solution Explorer**, expand the top-level project node and open the shortcut menu for the **Properties** node, and then choose **Open**.  
  
2.  In the **Application Designer**, choose the **General Properties** tab.  
  
3.  In the **Culture** or **Default Language** list, choose the culture that you want to use as the default culture.  
  
## See Also  
 [How to: Manage Project Settings](../vs140/how-to--manage-application-settings-in-lightswitch.md)   
 [How to: Add or Remove Extensions](../vs140/how-to--add-or-remove-extensions.md)   
 [Walkthrough: Localizing a LightSwitch Application](../vs140/walkthrough--localizing-a-lightswitch-application.md)