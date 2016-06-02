---
title: Convert to Package Deployment Model Dialog Box
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9e60a34a-10f7-48d1-966f-b3ff236ab4b7
---
# Convert to Package Deployment Model Dialog Box
  The **Convert to Package Deployment Model** command allows you to convert a package to the package deployment model after checking the project and each package in the project for compatibility with that model. If a package uses features unique to the project deployment model, such as parameters, then the package cannot be converted.  
  
## Task List  
 Converting a package to the package deployment model requires two steps.  
  
1.  When you select the **Convert to Package Deployment Model** command from the **Project** menu, the project and each package are checked for compatibility with this model. The results are displayed in the **Results** table.  
  
     If the project or a package fails the compatibility test, click **Failed** in the **Result** column for more information. Click **Save Report** to save a copy of this information to a text file.  
  
2.  If the project and all packages pass the compatibility test, then click **OK** to convert the package.  
  
> [!NOTE]  
>  To convert a project to the project deployment model, use the **Integration Services Project Conversion Wizard**. For more information, see [Integration Services Project Conversion Wizard](../../Topics\TopicNameNotContainA/Integration-Services-Project-Conversion-Wizard.md).  
  
## See Also  
 [Deployment of Projects and Packages](../../Topics\TopicNameNotContainA/Deployment-of-Projects-and-Packages.md)   
 [Legacy Package Deployment &#40;SSIS&#41;](../Topic/Legacy%20Package%20Deployment%20\(SSIS\).md)   
 [Integration Services Project Conversion Wizard](../../Topics\TopicNameNotContainA/Integration-Services-Project-Conversion-Wizard.md)  
  
  