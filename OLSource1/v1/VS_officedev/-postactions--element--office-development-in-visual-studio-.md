---
title: "&lt;postActions&gt; Element (Office Development in Visual Studio)"
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
  - "application manifests [Office development in Visual Studio], <postActions> element"
  - "postActions element"
  - "<postActions> element"
ms.assetid: 6e487549-fdd6-49bd-be7a-b91f1f964594
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
# &lt;postActions&gt; Element (Office Development in Visual Studio)
  The `postActions` element of the `vstav3` namespace contains all the `postAction` elements that describe post-deployment actions, which run after Office solutions are installed.  
  
## Syntax  
  
```  
<postActions>  
  <postAction>  
    <entryPoint>  
    </entryPoint>  
    <postActionData>  
    </postActionData>  
  </postAction>  
</postActions>  
```  
  
## Elements and Attributes  
 The `postActions` element is optional and it is in the `vstav3` namespace. There is only one `postActions` element defined in an application manifest.  
  
 The `postActions` element has no attributes.  
  
 `postActions` has the following element.  
  
### postAction  
 Optional. The role of the `postAction` element in the `vstav3` namespace is defined in [&#60;postAction&#62; Element &#40;Office Development in Visual Studio&#41;](../VS_officedev/-postaction--element--office-development-in-visual-studio-.md).  
  
## Post-Deployment Action Example  
  
### Description  
 The following code example illustrates the `postActions` element in an application manifest for an Office solution deployed by using [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstav3:postActions>  
  <vstav3:postAction>  
    <vstav3:entryPoint   
      class="PostDeploymentAction.PostDeploymentActionSample">  
      <assemblyIdentity   
        name="PostDeploymentAction"   
        version="1.0.0.0"   
        language="neutral"   
        processorArchitecture="msil" />  
    </vstav3:entryPoint>  
    <vstav3:postActionData>  
    </vstav3:postActionData>  
  </vstav3:postAction>  
</vstav3:postActions>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../VS_officedev/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](../Topic/ClickOnce%20Application%20Manifest.md)  
  
  