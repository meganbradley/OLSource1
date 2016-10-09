---
title: "How to: Change the Position of a Tab on the Ribbon"
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
  - "Ribbon [Office development in Visual Studio], tabs"
ms.assetid: 3f0906e3-9708-4136-ac49-986bc4c92ea4
caps.latest.revision: 26
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
# How to: Change the Position of a Tab on the Ribbon
  You can change the order of custom tabs on a Ribbon by using the **Tab Collection Editor**. You can position custom tabs before or after a built-in tab on the Ribbon. A built-in tab is a tab that is already on the Ribbon of a Microsoft Office application. For example, the **Data** tab is a built-in tab in Excel.  
  
 [!INCLUDE[appliesto_ribbon](../VS_officedev/includes/appliesto_ribbon_md.md)]  
  
### To change the order of tabs on the Ribbon  
  
1.  Select the Ribbon code file (.vb or .cs file) in **Solution Explorer**.  
  
2.  On the **View** menu, click **Designer**.  
  
3.  Right-click the Ribbon Designer, and then click **Properties**.  
  
4.  In the **Properties** window, select the **Tabs** property, and then click the ellipsis button (![ASP.NET Mobile Designer ellipse](../VS_officedev/media/mwellipsis.gif "mwEllipsis")).  
  
     The **Tab Collection Editor** appears.  
  
5.  In the **Tab Collection Editor**, in the **Members** list, select the tab you want to move and click the up or down arrows to change the tab order.  
  
### To position a tab before or after a built-in tab on the Ribbon  
  
1.  In the Ribbon Designer, select a custom tab.  
  
2.  In the **Properties** window, expand the **ControlId** property, and then make sure that the value of the **ControlIdType** property is set to **Custom**.  
  
3.  In the **Properties** window, expand the **Position** property.  
  
4.  Set the **PositionType** property to the appropriate value:  
  
    -   **BeforeOfficeId** positions the group before a specified built-in tab.  
  
    -   **AfterOfficeId** positions the group after a specified built-in tab.  
  
5.  Set the **OfficeId** property to the control ID of a built-in tab.  
  
     For a list of control IDs, see [Office 2010 Help Files: Office Fluent User Interface Control Identifiers](http://go.microsoft.com/fwlink/?LinkID=181052).  
  
## See Also  
 [Ribbon Overview](../VS_officedev/ribbon-overview.md)   
 [Ribbon Designer](../VS_officedev/ribbon-designer.md)   
 [Ribbon XML](../VS_officedev/ribbon-xml.md)   
 [Walkthrough: Creating a Custom Tab by Using the Ribbon Designer](../VS_officedev/walkthrough--creating-a-custom-tab-by-using-the-ribbon-designer.md)   
 [Walkthrough: Creating a Custom Tab by Using Ribbon XML](../VS_officedev/walkthrough--creating-a-custom-tab-by-using-ribbon-xml.md)  
  
  