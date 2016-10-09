---
title: "&lt;entryPoint&gt; Element (Office Development in Visual Studio)"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "application manifests [Office development in Visual Studio], <entryPoint> element"
  - "<entryPoint> element"
  - "entryPoint element"
ms.assetid: 0c9d22d0-0852-4260-89c6-b83f24e48793
caps.latest.revision: 23
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
# &lt;entryPoint&gt; Element (Office Development in Visual Studio)
  Each `entryPoint` element of the `vstav3` namespace identifies a customization assembly that should be run when this [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)] application is installed.  
  
## Syntax  
  
```  
<entryPoint class>  
    <assemblyIdentity />  
</entryPoint>  
```  
  
## Elements and Attributes  
 The `entryPoint` element is required and is in the `vstav3` namespace.  
  
 Each `entryPoint` element can contain only one customization assembly. There can be multiple `entryPoint` elements defined in an application manifest.  
  
 The `entryPoint` element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`class`|Required. Identifies a customization assembly to be executed. The syntax for this attribute is *NamespaceName.ClassName*.|  
  
 `entryPoint` has the following element.  
  
### assemblyIdentity  
 Required. The `assemblyIdentity` element in the `vstav3` namespace refers to an existing `assemblyIdentity` element in the [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)] application manifest.  
  
 The role of `assemblyIdentity` and its attributes is defined in [&#60;assemblyIdentity&#62; Element &#40;ClickOnce Application&#41;](../Topic/%3CassemblyIdentity%3E%20Element%20(ClickOnce%20Application).md).  
  
## Document-Level Customization Example  
  
### Description  
 The following code example illustrates `entryPoint` elements in an application manifest for a document-level Office solution deployed using [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstav3:entryPoint   
  class="ContosoExcelWorkbook.ThisWorkbook">  
  <assemblyIdentity   
    name="ContosoExcelWorkbook"   
    version="1.0.0.0"   
    language="neutral"   
    processorArchitecture="msil" />  
</vstav3:entryPoint>  
<vstav3:entryPoint   
  class="ContosoExcelWorkbook.Sheet1">  
  <assemblyIdentity   
    name="ContosoExcelWorkbook"   
    version="1.0.0.0"   
    language="neutral"   
    processorArchitecture="msil" />  
</vstav3:entryPoint>  
<vstav3:entryPoint   
  class="ContosoExcelWorkbook.Sheet2">  
  <assemblyIdentity   
    name="ContosoExcelWorkbook"   
    version="1.0.0.0"   
    language="neutral"   
    processorArchitecture="msil" />  
</vstav3:entryPoint>  
<vstav3:entryPoint   
  class="ContosoExcelWorkbook.Sheet3">  
  <assemblyIdentity   
    name="ContosoExcelWorkbook"   
    version="1.0.0.0"   
    language="neutral"   
    processorArchitecture="msil" />  
</vstav3:entryPoint>  
```  
  
## VSTO Add-in Example  
  
### Description  
 The following code example illustrates an `entryPoint` element in an application manifest for an application-level Office solution deployed using [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstav3:entryPoint   
  class="ContosoOutlookAddIn.ThisAddIn">  
  <assemblyIdentity   
    name="ContosoOutlookAddIn"   
    version="1.0.0.0"   
    language="neutral"   
    processorArchitecture="msil" />  
</vstav3:entryPoint>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../VS_officedev/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](../Topic/ClickOnce%20Application%20Manifest.md)  
  
  