---
title: "SetMergeProxySymbol"
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
  - "SetMergeProxySymbol"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMergeProxySymbol method"
ms.assetid: d6a9db59-2d5b-4431-98bc-785675e0eafe
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SetMergeProxySymbol
This function is called by the wizard to add the _MERGE_PROXYSTUB symbol if needed.  
  
## Syntax  
  
```  
  
      function SetMergeProxySymbol(   
   oProj    
);  
```  
  
#### Parameters  
 `oProj`  
 Selected project object  
  
## Remarks  
 This function is called by the wizard to add the _MERGE_PROXYSTUB symbol if needed.  
  
## Example  
  
```  
SetMergeProxySymbol (selproj);  
```  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)