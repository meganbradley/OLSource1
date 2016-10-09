---
title: "How to: Add a Parameter to a Method"
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
  - "Business Data Connectivity service [SharePoint development in Visual Studio], adding a method to a parameter"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], parameter"
  - "BDC [SharePoint development in Visual Studio], adding a method to a parameter"
  - "BDC [SharePoint development in Visual Studio], parameter"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], method parameters"
  - "BDC [SharePoint development in Visual Studio], method parameters"
ms.assetid: c5b6fd32-bf85-4b2a-a01e-f9199f0fb26e
caps.latest.revision: 16
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
# How to: Add a Parameter to a Method
  Use a parameter to pass information into the method or to return information from a method. All methods must have at least one parameter. For more information about how to design a parameter to support the type of method that you want to create, see [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md).  
  
 When you add a parameter to a method, Visual Studio adds the `<Parameter>` element to the XML of the model file in your project. For more information about the attributes of a `<Parameter>` element, see [Parameter](http://go.microsoft.com/fwlink/?LinkId=169284).  
  
### To add a parameter to a method  
  
1.  Add a method to an entity.  
  
2.  On the menu bar, choose **View**, **Other Windows**, **BDC Method Details**.  
  
     The **BDC Method Details** window opens. For more information, see [BDC Model Design Tools Overview](../VS_officedev/bdc-model-design-tools-overview.md).  
  
3.  In the **BDC Method Details** window, expand the node of the method, and then expand the **Parameters** node.  
  
4.  In the **Add a Parameter** list, choose **Create Parameter**.  
  
     A new parameter appears beneath the **Parameters** node.  
  
5.  On the menu bar, choose **View**, **Properties Window**.  
  
6.  In the **Properties** window, set the **Name** property to any name that makes sense. For example, if the method will return customers, you might name the method **GetCustomers**.  
  
7.  In the **BDC Method Details** window, open the list that appears for the direction of the parameter, and then choose **In**, **InOut**, **Out**, or **Return**.  
  
     For more information about which direction to choose for the type method that you are creating, see [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md).  
  
8.  Modify the type descriptor of the parameter. For more information, see [How to: Define the Type Descriptor of a Parameter](../VS_officedev/how-to--define-the-type-descriptor-of-a-parameter.md).  
  
## See Also  
 [BDC Model Design Tools Overview](../VS_officedev/bdc-model-design-tools-overview.md)   
 [How to: Add an Entity to a Model](../VS_officedev/how-to--add-an-entity-to-a-model.md)   
 [How to: Define the Type Descriptor of a Parameter](../VS_officedev/how-to--define-the-type-descriptor-of-a-parameter.md)   
 [How to: Define a Method Instance](../VS_officedev/how-to--define-a-method-instance.md)   
 [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md)  
  
  