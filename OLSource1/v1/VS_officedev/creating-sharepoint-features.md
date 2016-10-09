---
title: "Creating SharePoint Features"
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
  - "SharePoint development in Visual Studio, features"
  - "features [SharePoint development in Visual Studio]"
ms.assetid: 2e211fb3-94f4-4921-ba77-2ba6717a3e41
caps.latest.revision: 20
ms.author: "kempb"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Creating SharePoint Features
  You can use a SharePoint Feature to group related SharePoint project items for easier deployment. You can create Features, set scopes, and mark other Features as dependencies by using the SharePoint Feature Designer. The designer also generates a manifest, an XML file that describes each Feature.  
  
## Adding Features to the SharePoint Solution  
 You can add a Feature to the SharePoint solution by using Solution Explorer or the Packaging Explorer. You can use one of the following methods to add a Feature.  
  
-   In **Solution Explorer**, open the shortcut menu for **Features**, and then choose **Add Feature**.  
  
-   In **Packaging Explorer**, open the shortcut menu for the package, and then choose **Add Feature**.  
  
## Using the Feature Designer  
 A SharePoint solution can contain one or more SharePoint Features, which are grouped under the Feature node in Solution Explorer. Each Feature has its own **Feature Designer** that you can use to customize the Feature properties. For more information, see [How to: Customize a SharePoint Feature](../VS_officedev/how-to--customize-a-sharepoint-feature.md).  
  
 To distinguish Features from one another, you can configure the Feature properties such as the title, description, version, and scope. For more information, see [NIB: Building SharePoint Solutions with Team Foundation Server](assetId:///700a570a-e98e-4425-aadd-34c014868d43).  
  
### Feature Designer Options  
 After you create a Feature, you can use the Feature Designer to customize it.  
  
 The following table describes the Feature properties that are displayed in the Feature Designer.  
  
|Property|Description|  
|--------------|-----------------|  
|Title|Optional. The default title of the Feature is set to *SolutionName**FeatureName*.|  
|Description|Optional. The description of the SharePoint Feature.|  
|Scope|Required. If a Feature is created by using **Solution Explorer**, the scope is set to Web by default.<br /><br /> - Farm: Activate a Feature for an entire server farm.<br /><br /> - Site: Activate a Feature for all web sites in a site collection.<br /><br /> - Web: Activate a Feature for a specific web site.<br /><br /> - WebApplication: Activate a Feature for all web sites in a web application.|  
|Items in the Solution|All SharePoint Items that can be added to the Feature.|  
|Items in the Feature|The SharePoint project items that have been added to the Feature.|  
  
## Adding and Removing SharePoint Project Items  
 You can select which SharePoint project items that you want to add a SharePoint Feature to for deployment. Use the **Feature Designer** to add and remove items to Features, and view the Feature manifest. For more information, see [How to: Add and Remove Items to SharePoint Features](../VS_officedev/how-to--add-and-remove-items-to-sharepoint-features.md).  
  
## Adding Feature Dependencies  
 You can configure the Feature manifest so that the SharePoint server activates certain Features before your Feature is activated. For example, if your SharePoint Feature depends on other Features for functionality or data, the SharePoint server can first try to activate any of the Features that your feature depends on. For more information, see [How to: Add and Remove Feature Dependencies](../VS_officedev/how-to--add-and-remove-feature-dependencies.md).  
  
## See Also  
 [How to: Customize a SharePoint Feature](../VS_officedev/how-to--customize-a-sharepoint-feature.md)   
 [How to: Add and Remove Items to SharePoint Features](../VS_officedev/how-to--add-and-remove-items-to-sharepoint-features.md)   
 [How to: Add and Remove Feature Dependencies](../VS_officedev/how-to--add-and-remove-feature-dependencies.md)  
  
  