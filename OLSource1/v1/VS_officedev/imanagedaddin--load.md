---
title: "IManagedAddin::Load"
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
  - "IManagedAddin::Load"
  - "Load method"
ms.assetid: 3faf9312-8ab4-4960-b2e7-8ca9859a3dcf
caps.latest.revision: 9
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
# IManagedAddin::Load
  Called when a managed VSTO Add-in is loaded.  
  
## Syntax  
  
```  
HRESULT Load([in] BSTR bstrManifestURL,   
             [in] IDispatch *pdispApplication);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|*bstrManifestURL*|The full path of the manifest for the VSTO Add-in.|  
|*pdispApplication*|A pointer to an IDispatch that represents the host application that is loading the VSTO Add-in.|  
  
## Return Value  
 An HRESULT value that indicates whether the method completed successfully.  
  
## Remarks  
 A manifest is a file (typically, an XML file) that provides information that is used to help load the VSTO Add-in. For example, a manifest can specify the location of the VSTO Add-in assembly and the entry point class to instantiate when the VSTO Add-in is loaded.  
  
 The *bstrManifestURL* parameter contains the value of the `Manifest` entry under the HKEY_CURRENT_USER\Software\Microsoft\Office\\*\<application name>*\Addins\\*\<add-in ID>* registry key for the VSTO Add-in. For more information, see [IManagedAddin Interface](../VS_officedev/imanagedaddin-interface.md).  
  
 Implement the [IManagedAddIn::Load](../VS_officedev/imanagedaddin--load.md) method to perform tasks such as configuring the application domain and security policy for the VSTO Add-in that is being loaded.  
  
## See Also  
 [IManagedAddin Interface](../VS_officedev/imanagedaddin-interface.md)   
 [IManagedAddin::Unload](../VS_officedev/imanagedaddin--unload.md)  
  
  