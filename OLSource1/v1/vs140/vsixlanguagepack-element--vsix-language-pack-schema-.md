---
title: "VSIXLanguagePack Element (VSIX Language Pack Schema)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 767f5c22-8b87-49ca-92aa-a7a3f026469f
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# VSIXLanguagePack Element (VSIX Language Pack Schema)
Required. Provides the root element for a VSIX language pack. The VSIX language pack provides localized installation information for a VSIX package.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The XML namespace in which the VSIX Language Pack schema is defined.|  
  
## xmlns Attribute  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required. The location of the file that defines the schema for language packs.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[LocalizedName Element](../vs140/localizedname-element--vsix-language-pack-schema-.md)|Required. The localized name of the extension to be installed.|  
|[LocalizedDescription Element](../vs140/localizeddescription-element--vsix-language-pack-schema-.md)|Required. The localized description of the extension to be installed.|  
|[MoreInfoURL Element](../vs140/moreinfourl-element--vsix-language-pack-schema-.md)|Optional. A link to localized information about the extension.|  
|[License Element](../vs140/license-element--vsix-language-pack-schema-.md)|Optional. The path of a localized version of the license file for the extension.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|None||  
  
## Element Information  
  
|||  
|-|-|  
|Namespace|http://schemas.microsoft.com/developer/vsx-schema-lp/2010|  
|Schema Name|VSIX Language Pack Schema|  
|Validation File|VSIXLanguagePackSchema.xsd|  
|Can be Empty|No|  
  
## See Also  
 [VSX Schema for Language Packs](../vs140/vsx-language-pack-schema-reference.md)   
 [Localizing VSIX Packages](../vs140/localizing-vsix-packages.md)   
 [VSIX Extension Schema 1.0 Reference](assetId:///76e410ec-b1fb-4652-ac98-4a4c52e09a2b)