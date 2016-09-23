---
title: "RequiredPlatformVersion Element (Visual Studio Templates)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6f0e4986-3157-4bba-aed3-c28413ebe976
caps.latest.revision: 10
translation.priority.mt: 
  - de-de
  - ja-jp
---
# RequiredPlatformVersion Element (Visual Studio Templates)
Specifies the minimum version of the operating system that the project template requires to work correctly. This element is used to for project templates that create [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps.  
  
 The `RequiredPlatformVersion` value is compared directly with the version of the operating system. If the `RequiredPlatformVersion` is higher than the operating system version, the template does not appear in the **New Project** dialog box. To specify a template for [!INCLUDE[win8](../vs140/includes/win8_md.md)] or higher, set `RequiredPlatformVersion` to 6.2.0. To specify a template for [!INCLUDE[win81](../vs140/includes/win81_md.md)] or higher, set RequiredPlatformVersion to 6.3.0.  
  
 Templates that specify `RequiredPlatformVersion`=8 are compatible with previous customer [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] templates.  
  
 VSTemplate  
TemplateData  
…..TargetPlatformName  
RequiredPlatformVersion  
  
## Syntax  
  
```xml  
<RequiredPlatformVersion> OperatingSystem </RequiredPlatformVersion>  
```  
  
## Attributes and Elements  
 None.  
  
### Attributes  
 None.  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplatePlatformName](../vs140/templatedata-element--visual-studio-templates-.md)|Specifies the platform that the project template targets.|  
  
## Text Value  
 A text value is required.  
  
## Remarks  
 This text specifies the minimum operating system version required by the template.  
  
## Example  
 This example specifies that the project template targets [!INCLUDE[win8](../vs140/includes/win8_md.md)] or later.  
  
```xml  
<VSTemplate Type="Project" Version="3.0.0"    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <TargetPlatformName>Windows</TargetPlatformName>  
            <RequiredPlatformVersion>6.3.0</RequiredPlatformVersion>  
  
    </TemplateData>  
    <TemplateContent>  
  
    </TemplateContent>  
</VSTemplate>  
```  
  
## See Also  
 [TemplatePlatformName](../vs140/targetplatformname-element--visual-studio-templates-.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)