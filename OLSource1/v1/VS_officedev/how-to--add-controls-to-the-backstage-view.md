---
title: "How to: Add Controls to the Backstage View"
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
  - "customizing the Ribbon, menus"
  - "controls, Ribbon"
  - "menus, customizing"
  - "Microsoft Office Button"
  - "custom Ribbon, menus"
  - "Ribbon, customizing"
  - "Office button"
  - "Ribbon, menus"
  - "Microsoft Office Menu"
ms.assetid: 4fda1278-9aea-4d54-928a-269a81584494
caps.latest.revision: 30
ms.author: "normesta"
manager: "ghogen"
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
# How to: Add Controls to the Backstage View
  You can use the Ribbon Designer to add controls to the menu that opens when you click the **File** tab. when you run the application, controls that you add to the **File** tab appear a group named **Add-ins**.  
  
 You cannot position controls before or after built-in controls by using the Ribbon designer in Visual Studio. A built-in control is a control that already appears in Backstage view. If you want to position controls before or after built-in controls, you must use a Ribbon XML. For more information about **Ribbon (XML)**, see [Ribbon XML](../VS_officedev/ribbon-xml.md). For more information about customizing the Backstage view, see [Introduction to the Office 2010 Backstage View for Developers](http://go.microsoft.com/fwlink/?LinkId=182189) and [Customizing the Office 2010 Backstage View for Developers](http://go.microsoft.com/fwlink/?LinkId=182188).  
  
 [!INCLUDE[appliesto_ribbon](../VS_officedev/includes/appliesto_ribbon_md.md)]  
  
### To add controls to Backstage View  
  
1.  Open the Ribbon item in Design view.  
  
     For information about how to add a **Ribbon (Visual Designer)** item to your project, see [How to: Get Started Customizing the Ribbon](../VS_officedev/how-to--get-started-customizing-the-ribbon.md).  
  
2.  In the Ribbon Designer, click the **File** tab.  
  
     A menu designer appears. This design surface does not contain any controls.  
  
3.  From the **Office Ribbon Controls** tab of the **Toolbox**, drag any of the following controls onto the menu designer:  
  
    -   Button  
  
    -   CheckBox  
  
    -   Gallery  
  
    -   Menu  
  
    -   Separator  
  
    -   SplitButton  
  
    -   ToggleButton  
  
4.  Drag controls to move them to new positions on the menu.  
  
## See Also  
 [Ribbon Overview](../VS_officedev/ribbon-overview.md)   
 [Ribbon Designer](../VS_officedev/ribbon-designer.md)   
 [Ribbon XML](../VS_officedev/ribbon-xml.md)   
 [How to: Get Started Customizing the Ribbon](../VS_officedev/how-to--get-started-customizing-the-ribbon.md)   
 [Walkthrough: Creating a Custom Tab by Using the Ribbon Designer](../VS_officedev/walkthrough--creating-a-custom-tab-by-using-the-ribbon-designer.md)  
  
  