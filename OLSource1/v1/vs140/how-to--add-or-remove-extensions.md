---
title: "How to: Add or Remove Extensions"
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
  - "extensions [Visual Studio LightSwitch]"
ms.assetid: e0bf8ede-8dce-4625-a9cb-68e5ab6a47ef
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add or Remove Extensions
Extensions let you add new capabilities to LightSwitch. You can find and download extensions directly from [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] by using the **Extension Manager**. After the download finishes, the extensions appear in the **Extensions** tab of the **Application Designer**. You can enable or disable them as needed.  
  
> [!NOTE]
>  Extensions are only available in Silverlight client projects.  
  
### To download an extension  
  
1.  On the **Tools** menu, choose **Extensions and Updates**.  
  
     The **Extensions and Updates** dialog box opens, and a list of installed extensions is displayed.  
  
2.  In the **Extension Manager**, choose and expand the **Online Gallery** node.  
  
     A list of available extensions appears in the center pane.  
  
3.  Choose the extension that you want to download and then choose the **Download** button.  
  
     A **Download and Install** dialog box aopens.  
  
4.  In the **Download and Install** dialog box, read the license agreement (if any). If you agree with the terms choose the **Install** button.  
  
     The extension is installed and appears in the **Installed Extensions** node of **Extension Manager** group.  
  
5.  Choose the **Restart Now** button to restart Visual Studio.  
  
     Visual Studio closes and restarts. The extension is available but not yet enabled in the **Application Designer**.  
  
### To enable an extension  
  
1.  In **Solution Explorer**, open the shortcut menu for the top-level project node and choose **Properties**.  
  
     The **Application Designer** opens.  
  
2.  In the **Application Designer**, choose the **Extensions** tab.  
  
     The extension that you just installed is listed in the **Extensions** list.  
  
3.  Select the check box to the left of the extension to enable it for use in the current project.  
  
4.  To enable the extension for all future projects, select the **Use in new projects** check box.  
  
### To remove an extension  
  
1.  In **Solution Explorer**, open the shortcut menu for the top-level project node and choose **Properties**.  
  
     The **Application Designer** opens.  
  
2.  In the **Application Designer**, choose the **Extensions** tab.  
  
3.  Choose the extension that you want to remove.  
  
4.  Uncheck the check box to the left of the extension.  
  
## See Also  
 [Extensions: Adding New Capabilities to LightSwitch](../vs140/extensions--adding-new-capabilities-to-lightswitch.md)   
 [How to: Use Extensions in a Project](../vs140/how-to--use-extensions-in-a-lightswitch-project.md)