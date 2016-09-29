---
title: "Upgrading Projects Created in Earlier Versions of LightSwitch"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: dc41061d-f7f9-446b-b9c2-44588005380d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Upgrading Projects Created in Earlier Versions of LightSwitch
Projects that were created in an earlier version of LightSwitch use a different file structure, and you must upgrade them before you can open them in the current version of LightSwitch. After you upgrade them, you can no longer open them in the earlier version. You can open most projects after the upgrade without modifying them further. In some cases, you might need to make minor modifications after you upgrade. These exceptions will be noted in a conversion report.  
  
## Preparing to Upgrade  
 You may need to perform several tasks before you upgrade a LightSwitch project. First, you should make sure that you can open and successfully build the project in the earlier version of LightSwitch. If the project has errors, the upgrade is likely to fail.  
  
 If the project uses extensions, they must already be installed on the computer where you are performing the upgrade or the upgrade will fail. This requirement includes any extensions that the project references but doesn't use; you should remove any unused extensions before you upgrade. For more information, see [How to: Add or Remove Extensions](../vs140/how-to--add-or-remove-extensions.md).  
  
## Upgrading a Project  
 When you try to open a project that was created in an earlier version of LightSwitch, the **Review Project and Solution Changes** dialog box appears.  
  
 After you choose the **OK** button, the project files will be converted to the new format, and the project will appear in **Solution Explorer**. A backup copy of the original project will be saved in a **Backup** folder under the **Solution** folder. In addition, an **UpgradeLog** file will be created in the **Solution** folder. This file contains information about the changes that were made and any further modifications that you may need to perform.  
  
 After the upgrade is complete, open the **UpgradeLog** file, and review it for any errors.  
  
## See Also  
 [How to: Add or Remove Extensions](../vs140/how-to--add-or-remove-extensions.md)   
 [Performing Data-Related Tasks by Using Code](../vs140/performing-data-related-tasks-by-using-code.md)   
 [How to: Handle Data Events](../vs140/how-to--handle-data-events.md)   
 [How to: Upgrade a SharePoint-enabled LightSwitch App](../vs140/how-to--upgrade-a-sharepoint-enabled-lightswitch-app.md)