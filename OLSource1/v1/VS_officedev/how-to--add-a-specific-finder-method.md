---
title: "How to: Add a Specific Finder Method"
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
  - "Business Data Connectivity service [SharePoint development in Visual Studio], Specific Finder"
  - "BDC [SharePoint development in Visual Studio], return an entity"
  - "BDC [SharePoint development in Visual Studio], get an entity"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], return an entity"
  - "BDC [SharePoint development in Visual Studio], Specific Finder"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], get an entity"
ms.assetid: 7bbc5986-2828-4755-96fa-9f1dc0f8dc75
caps.latest.revision: 30
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
# How to: Add a Specific Finder Method
  You can return a single entity instance by creating a *Specific Finder* method. The Business Data Connectivity (BDC) service executes the Specific Finder method when a user chooses an entity in a business data web part or external list. For more information, see [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md).  
  
### To create a Specific Finder method  
  
1.  On the BDC designer, choose an entity.  
  
     For information about how to add an entity to the BDC designer in Visual Studio, see [How to: Add an Entity to a Model](../VS_officedev/how-to--add-an-entity-to-a-model.md).  
  
2.  On the menu bar, choose **View**, **Other Windows**, **BDC Method Details**.  
  
     The **BDC Method Details** window opens. For more information about that window, see [BDC Model Design Tools Overview](../VS_officedev/bdc-model-design-tools-overview.md).  
  
3.  In the **Add a Method** list, choose **Create Specific Finder Method**.  
  
     Visual Studio adds the following elements to the model. These elements appear in the **BDC Method Details** window.  
  
    -   A method.  
  
    -   An input parameter for the method.  
  
    -   A return parameter for the method.  
  
    -   A type descriptor for each parameter.  
  
    -   A method instance for the method.  
  
     For more information, see [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md).  
  
4.  Open the Visual Studio **Properties** window.  
  
5.  Configure the type descriptor of the return parameter as an entity type descriptor. For information about how to create an entity type descriptor, see [How to: Define the Type Descriptor of a Parameter](../VS_officedev/how-to--define-the-type-descriptor-of-a-parameter.md).  
  
    > [!NOTE]  
    >  You don't have to perform this step if you have added a Finder method to the entity. Visual Studio uses the type descriptor that you defined in the Finder method.  
  
    > [!NOTE]  
    >  If the identifier field of the entity type represents a field in a database table that's automatically generated, set the **Read-only** property of the identifier field to **True**.  
  
6.  In the **Method Details** window, choose the method instance of the method.  
  
7.  In the **Properties Window**, set the **Return Parameter Name** property to the name of the return parameter of the method. For more information about method instance properties, see [MethodInstance](http://go.microsoft.com/fwlink/?LinkID=169282).  
  
8.  In **Solution Explorer**, open the shortcut menu of the service code file that was generated for the entity, and then choose **View Code**.  
  
     The entity service code file opens in the Code Editor. For more information about the entity service code file, see [Creating a Business Data Connectivity Model](../VS_officedev/creating-a-business-data-connectivity-model.md).  
  
9. Add code to the Specific Finder method. This code performs the following tasks:  
  
    -   Retrieves a record from a data source.  
  
    -   Returns an entity to the BDC service.  
  
     The following example returns a contact from the AdventureWorks sample database for SQL Server.  
  
    > [!NOTE]  
    >  Replace the value of the `ServerName` field with the name of your server.  
  
     [!code[SP_BDC#3](../VS_officedev/codesnippet/CSharp/how-to--add-a-specific-finder-method_1.cs)]
[!code[SP_BDC#3](../VS_officedev/codesnippet/VisualBasic/how-to--add-a-specific-finder-method_1.vb)]  
  
## See Also  
 [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md)   
 [How to: Add a Finder Method](../VS_officedev/how-to--add-a-finder-method.md)   
 [How to: Add a Creator Method](../VS_officedev/how-to--add-a-creator-method.md)   
 [How to: Add a Deleter Method](../VS_officedev/how-to--add-a-deleter-method.md)   
 [How to: Add an Updater Method](../VS_officedev/how-to--add-an-updater-method.md)   
 [BDC Model Design Tools Overview](../VS_officedev/bdc-model-design-tools-overview.md)   
 [How to: Add a Parameter to a Method](../VS_officedev/how-to--add-a-parameter-to-a-method.md)   
 [How to: Define a Method Instance](../VS_officedev/how-to--define-a-method-instance.md)  
  
  