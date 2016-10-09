---
title: "IManagedAddin::Unload"
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
  - "Unload method"
  - "IManagedAddin::Unload"
ms.assetid: 40a73f07-2605-4745-8ac5-0a0189167fd7
caps.latest.revision: 8
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
# IManagedAddin::Unload
  Called just before a managed VSTO Add-in is unloaded.  
  
## Syntax  
  
```  
HRESULT Unload();  
```  
  
## Return Value  
 An HRESULT value that indicates whether the method completed successfully.  
  
## Remarks  
 This method is not called by current versions of Microsoft Office. This method is reserved for future use.  
  
## See Also  
 [IManagedAddin Interface](../VS_officedev/imanagedaddin-interface.md)   
 [IManagedAddin::Load](../VS_officedev/imanagedaddin--load.md)  
  
  