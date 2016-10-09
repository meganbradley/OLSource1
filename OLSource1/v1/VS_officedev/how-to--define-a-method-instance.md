---
title: "How to: Define a Method Instance"
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
  - "Business Data Connectivity service [SharePoint development in Visual Studio], method instance"
  - "BDC [SharePoint development in Visual Studio], method instance"
  - "BDC [SharePoint development in Visual Studio], method"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], method"
ms.assetid: f0c8a686-c0de-414e-8de9-f228f59d1eb3
caps.latest.revision: 14
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
# How to: Define a Method Instance
  You must define at least one method instance for every method in your model.  
  
 Add a method instance by using the **BDC Method Details** window. When you add the method instance, Visual Studio adds a `<MethodInstance>` element to the XML of the model file in your project. For more information about the attributes of a `<MethodInstance>` element, see [MethodInstance](http://go.microsoft.com/fwlink/?LinkID=169282).  
  
### To define a method instance  
  
1.  In the **BDC Method Details** window, expand the node of a method, and then expand the **Instances** node.  
  
2.  In the **Add a Method Instance** list, choose **Create Finder Instance**.  
  
     A new method instance appears beneath the **Instances** node.  
  
3.  On the menu bar, choose **View**, choose **Properties Window**.  
  
4.  In the **Properties** window, set the properties of the method instance. For more information about each property, see [MethodInstance](http://go.microsoft.com/fwlink/?LinkID=169282).  
  
## See Also  
 [BDC Model Design Tools Overview](../VS_officedev/bdc-model-design-tools-overview.md)   
 [How to: Add an Entity to a Model](../VS_officedev/how-to--add-an-entity-to-a-model.md)   
 [How to: Add a Parameter to a Method](../VS_officedev/how-to--add-a-parameter-to-a-method.md)   
 [How to: Define the Type Descriptor of a Parameter](../VS_officedev/how-to--define-the-type-descriptor-of-a-parameter.md)   
 [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md)  
  
  