---
title: "InfoPath Solutions"
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
  - "solutions [Office development in Visual Studio], InfoPath"
  - "templates [Office development in Visual Studio], InfoPath"
  - "InfoPath [Office development in Visual Studio]"
  - "Office development in Visual Studio, InfoPath solutions"
  - "projects [Office development in Visual Studio], InfoPath"
  - "Office solutions [Office development in Visual Studio], InfoPath"
  - "Office projects [Office development in Visual Studio], InfoPath"
ms.assetid: 20ac6bee-b17f-4217-9f78-11304a11236a
caps.latest.revision: 43
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# InfoPath Solutions
  Visual Studio provides project templates you can use to create VSTO Add-ins for Microsoft Office InfoPath 2013 and InfoPath 2010. InfoPath is not available in Office 2016.  
  
> [!NOTE]  
>  You can still create an VSTO Add-in for InfoPath even if you’ve installed Office 2016. Just install InfoPath 2013 or Office 2013 side-by-side with Office 2016.  
  
 [!INCLUDE[appliesto_infoallapp](../VS_officedev/includes/appliesto_infoallapp_md.md)]  
  
> [!NOTE]  
>  Interested in developing solutions that extend the Office experience across [multiple platforms](https://dev.office.com/add-in-availability)? Check out the new [Office Add-ins model](https://dev.office.com/docs/add-ins/overview/office-add-ins). Office Add-ins have a small footprint compared to VSTO add-ins and solutions, and you can build them by using almost any web programming technology, such as HTML5, JavaScript, CSS3, and XML.  
  
 VSTO Add-ins for InfoPath are similar to VSTO Add-ins for other Microsoft Office applications. These types of solutions consist of an assembly that is loaded by the application. End users can have access to the functionality of this assembly no matter which form or form template is open. For more information about VSTO Add-ins, see [Getting Started Programming VSTO Add-ins](../VS_officedev/getting-started-programming-vsto-add-ins.md) and [Architecture of VSTO Add-ins](../VS_officedev/architecture-of-vsto-add-ins.md).  
  
> [!NOTE]  
>  Visual Studio 2015 does not include the InfoPath form template projects that were provided in previous versions of Visual Studio. You also cannot use Visual Studio 2015 to open or edit an InfoPath form template project that was created in a previous version of Visual Studio. However, you can open and edit an InfoPath form template project by using Visual Studio Tools for Applications. For more information, see [Working with VSTO 2008 Projects in InfoPath 2010.](http://go.microsoft.com/fwlink/?LinkID=218903).  
  
## Automating InfoPath by Using an Add-In  
 To access the InfoPath object model from an Office VSTO Add-in created by using Office development tools in Visual Studio, use the `Application` field of the `ThisAddIn` class in your project. The `Application` field returns a \<xref:Microsoft.Office.Interop.InfoPath.Application> object that represents the current instance of InfoPath. For more information, see [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md).  
  
 When you call into the InfoPath object model from an VSTO Add-in, you use types that are provided in the primary interop assembly for InfoPath. The primary interop assembly acts as a bridge between the managed code in the VSTO Add-in and the COM object model in InfoPath. All types in the InfoPath primary interop assembly are defined in the \<xref:Microsoft.Office.Interop.InfoPath> namespace. For more information about the InfoPath primary interop assembly, see [About the Microsoft Office InfoPath Primary Interop Assembly](assetId:///1b3ae03c-6951-49e4-a489-4712d3f7ba72). For more information about primary interop assemblies in general, see [Office Solutions Development Overview &#40;VSTO&#41;](../VS_officedev/office-solutions-development-overview--vsto-.md) and [Office Primary Interop Assemblies](../VS_officedev/office-primary-interop-assemblies.md).  
  
## Customizing the User Interface of InfoPath by Using an Add-In  
 When you create an VSTO Add-in for InfoPath, you have several different UI customization options. The following table lists some of these options.  
  
|Task|For more information|  
|----------|--------------------------|  
|Create a custom task pane.|[Custom Task Panes](../VS_officedev/custom-task-panes.md)|  
|Add custom tabs to the Ribbon in InfoPath.|[Customizing a Ribbon for InfoPath](../VS_officedev/customizing-a-ribbon-for-infopath.md)|  
  
 For more information about customizing the UI of InfoPath and other Microsoft Office applications, see [Office UI Customization](../VS_officedev/office-ui-customization.md).  
  
## See Also  
 [About the Microsoft Office InfoPath Primary Interop Assembly](assetId:///1b3ae03c-6951-49e4-a489-4712d3f7ba72)   
 [Getting Started Programming VSTO Add-ins](../VS_officedev/getting-started-programming-vsto-add-ins.md)   
 [Office Solutions Development Overview &#40;VSTO&#41;](../VS_officedev/office-solutions-development-overview--vsto-.md)   
 [Architecture of VSTO Add-ins](../VS_officedev/architecture-of-vsto-add-ins.md)   
 [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md)   
 [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md)   
 [Writing Code in Office Solutions](../VS_officedev/writing-code-in-office-solutions.md)   
 [Office Primary Interop Assemblies](../VS_officedev/office-primary-interop-assemblies.md)   
 [Office UI Customization](../VS_officedev/office-ui-customization.md)   
 [InfoPath 2010 in Office Development](http://go.microsoft.com/fwlink/?LinkId=199012)  
  
  