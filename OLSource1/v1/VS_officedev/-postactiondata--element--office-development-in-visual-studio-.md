---
title: "&lt;postActionData&gt; Element (Office Development in Visual Studio)"
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
  - "<postActionData> element"
  - "application manifests [Office development in Visual Studio], <postActionData> element"
  - "postActionData element"
ms.assetid: e36cbd64-fd27-4413-b293-cf5546fbdfaf
caps.latest.revision: 16
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
# &lt;postActionData&gt; Element (Office Development in Visual Studio)
  The `postActionData` element of the `vstav3` namespace specifies the data associated with any post-deployment action that runs after Office solutions are installed.  
  
## Syntax  
  
```  
<postActionData>  
</postActionData>  
```  
  
## Elements and Attributes  
 The `postActionData` element is optional and is in the `vstav3` namespace. There is one `postActionData` element defined in an application manifest for each post-deployment action.  
  
 The `postActions` element has no attributes.  
  
 `postActions` has no child elements.  
  
## Post-Deployment Action Example  
  
### Description  
 The following code example illustrates the `postAction` element in an application manifest for an Office solution deployed by using [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstav3:postActionData>  
  data in any format  
</vstav3:postActionData>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../VS_officedev/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](../Topic/ClickOnce%20Application%20Manifest.md)  
  
  