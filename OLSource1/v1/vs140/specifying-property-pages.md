---
title: "Specifying Property Pages"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ISpecifyPropertyPages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ISpecifyPropertyPages method"
  - "property pages, specifying"
ms.assetid: ee8678cf-c708-49ab-b0ad-fc2db31f1ac3
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Specifying Property Pages
When you create an ActiveX control, you will often want to associate it with property pages that can be used to set the properties of your control. Control containers use the **ISpecifyPropertyPages** interface to find out which property pages can be used to set your control's properties. You will need to implement this interface on your control.  
  
 To implement **ISpecifyPropertyPages** using ATL, take the following steps:  
  
1.  Derive your class from [ISpecifyPropertyPagesImpl](../vs140/ispecifypropertypagesimpl-class.md).  
  
2.  Add an entry for **ISpecifyPropertyPages** to your class's COM map.  
  
3.  Add a [PROP_PAGE](../vs140/prop_page.md) entry to the property map for each page associated with your control.  
  
> [!NOTE]
>  When generating a standard control using the [ATL Control Wizard](../vs140/atl-control-wizard.md), you will only have to add the `PROP_PAGE` entries to the property map. The wizard generates the necessary code for the other steps.  
  
 Well-behaved containers will display the specified property pages in the same order as the `PROP_PAGE` entries in the property map. Generally, you should put standard property page entries after the entries for your custom pages in the property map, so that users see the pages specific to your control first.  
  
## Example  
 The following class for a calendar control uses the **ISpecifyPropertyPages** interface to tell containers that its properties can be set using a custom date page and the stock color page.  
  
 [!code[NVC_ATL_Windowing#72](../vs140/codesnippet/CPP/specifying-property-pages_1.h)]  
  
## See Also  
 [Property Pages](../vs140/atl-com-property-pages.md)   
 [ATLPages Sample](../vs140/visual-c---samples.md)