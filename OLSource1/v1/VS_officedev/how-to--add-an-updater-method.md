---
title: "How to: Add an Updater Method"
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
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "BDC [SharePoint development in Visual Studio], updating data"
  - "BDC [SharePoint development in Visual Studio], Updater"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], updating data"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], Updater"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], updating entity instances"
  - "BDC [SharePoint development in Visual Studio], updating entity instances"
ms.assetid: c97e443c-58dc-4f8f-8cbd-0d52d8a6a06b
caps.latest.revision: 33
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
# How to: Add an Updater Method
  You can enable users to update business data in a SharePoint external list by creating an *Updater* method. For more information, see [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md).  
  
### To create an Updater method  
  
1.  On the BDC designer, choose an entity.  
  
2.  On the menu bar, choose **View**, **Other Windows**, **BDC Method Details**.  
  
     The BDC Method Details window opens. For more information about this window, see [BDC Model Design Tools Overview](../VS_officedev/bdc-model-design-tools-overview.md).  
  
3.  In the **Add a Method** list, choose **Create Updater Method**.  
  
     Visual Studio adds the following elements to the model. These elements appear in the BDC Method Details window.  
  
    -   A method that's named **Update**.  
  
    -   An input parameter for the method.  
  
    -   A type descriptor for the parameter. By default, Visual Studio uses the entity type descriptor that you defined for the Finder method (for example: Contact).  
  
    -   A method instance for the method.  
  
     For more information, see [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md).  
  
    > [!NOTE]  
    >  If the identifier of the entity type represents a field in a database table that's not automatically generated, set the **Pre-Updater Field** property to **True**.  
  
4.  In **Solution Explorer**, open the shortcut menu of the service code file that was generated for the entity, and then choose **View Code**.  
  
     The entity service code file opens in the Code Editor. For more information about that file, see [Creating a Business Data Connectivity Model](../VS_officedev/creating-a-business-data-connectivity-model.md).  
  
5.  Add code to the Update method to update data. The following example updates information for a contact in the AdventureWorks sample database for SQL Server.  
  
    > [!NOTE]  
    >  Replace the value of the `ServerName` field with the name of your server.  
  
     [!code[SP_BDC#5](../VS_officedev/codesnippet/CSharp/how-to--add-an-updater-method_1.cs)]
[!code[SP_BDC#5](../VS_officedev/codesnippet/VisualBasic/how-to--add-an-updater-method_1.vb)]  
  
## See Also  
 [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md)   
 [How to: Add a Finder Method](../VS_officedev/how-to--add-a-finder-method.md)   
 [How to: Add a Specific Finder Method](../VS_officedev/how-to--add-a-specific-finder-method.md)   
 [How to: Add a Creator Method](../VS_officedev/how-to--add-a-creator-method.md)   
 [How to: Add an Updater Method](../VS_officedev/how-to--add-an-updater-method.md)   
 [How to: Add a Deleter Method](../VS_officedev/how-to--add-a-deleter-method.md)   
 [BDC Model Design Tools Overview](../VS_officedev/bdc-model-design-tools-overview.md)   
 [How to: Add a Parameter to a Method](../VS_officedev/how-to--add-a-parameter-to-a-method.md)   
 [How to: Define a Method Instance](../VS_officedev/how-to--define-a-method-instance.md)  
  
  