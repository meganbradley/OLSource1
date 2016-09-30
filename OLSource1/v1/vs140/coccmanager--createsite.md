---
title: "COccManager::CreateSite"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COccManager.CreateSite"
  - "CreateSite"
  - "COccManager::CreateSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COccManager class, overridables"
  - "CreateSite method"
ms.assetid: c3093bc9-796a-492c-920a-32031861c648
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COccManager::CreateSite
Called by the framework to create a control site, hosted by the container pointed to by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the control container hosting the new control site.  
  
## Return Value  
 A pointer to the newly created control site.  
  
## Remarks  
 Override this function to create a custom control site, using your [COleControlSite](../vs140/colecontrolsite-class.md)-derived class.  
  
 Each control container can host multiple sites. Create additional sites with multiple calls to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COccManager Class](../vs140/coccmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)