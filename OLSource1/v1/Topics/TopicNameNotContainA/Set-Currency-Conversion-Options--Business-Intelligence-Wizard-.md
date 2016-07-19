---
title: Set Currency Conversion Options (Business Intelligence Wizard)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a49d4e1f-bdda-4a83-ab4f-ce8c500e1d6d
manager: mblythe
---
# Set Currency Conversion Options (Business Intelligence Wizard)
Use the **Set Currency Conversion** page to define currency conversion calculations for a measure group that contains exchange rates.  
  
> [!NOTE]  
>  This page does not appear if the Business Intelligence Wizard was started from Dimension Designer or by right-clicking a dimension in Solution Explorer in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)].  
  
## Options  
 **Select the measure group that contains exchange rates**  
 Select the measure group that contains the exchange rates that the currency conversion calculations should reference.  
  
 **Specify the pivot currency**  
 Select the member that serves as the pivot currency for the measure group.  
  
 **Select how you entered your exchange rates (select a sample currency)**  
 Select a member representing a sample currency from the currency dimension to change the text for the X pivot currency per 1 sample currency and X sample currency per 1 pivot currency options to better display the exchange rate direction.  
  
 **X pivot currency per 1 sample currency**  
 Select to indicate that the exchange rates in the rate measure group represent a multiplier for the specified pivot currency.  
  
 **X sample currency per 1 pivot currency**  
 Select to indicate that the exchange rates in the rate measure group represent a multiplier for the specified sample currency.  
  
## See Also  
 [Business Intelligence Wizard F1 Help](../../Topics/TopicNameNotContainA/Business-Intelligence-Wizard-F1-Help.md)   
 [Cube Designer (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Cube-Designer--Analysis-Services---Multidimensional-Data-.md)   
 [Dimension Designer (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Dimension-Designer--Analysis-Services---Multidimensional-Data-.md)