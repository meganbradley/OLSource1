---
title: "Template Directives"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "endloop directive ([!endloop])"
  - "endif directive ([!endif])"
  - "loop directive ([!loop])"
  - "[!endif] template directive"
  - "[!output] template directive"
  - "if directive ([!if])"
  - "template directives"
  - "[!endloop] template directive"
  - "directives, template directives"
  - "output directive ([!output])"
  - "custom wizards, template directives"
  - "else directive ([!else])"
  - "[!loop] template directive"
  - "[!if] template directive"
  - "[!else] template directive"
ms.assetid: b6204153-813a-423c-b044-e39c352cc5af
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Template Directives
You can use the following template directives in a wizard [template file](../vs140/template-files.md) and the [Templates.inf file](../vs140/templates.inf-file.md) to customize the wizard.  
  
|Directive|Description|  
|---------------|-----------------|  
|[! if ]|Begins a control structure to check for a condition.|  
|[! else ]|Part of the [! if ] control structure. Checks for another condition.|  
|[! endif ]|Ends the definition of an [! if ] control structure.|  
|[! output ]|Can be used in the following two ways:\<br />\<br /> -   [! output "string" ] gives you the string.\<br />-   [! output SYMBOL_STRING ] gives you the value of the symbol SYMBOL_STRING.|  
|[! loop ]|Can be used in the following two ways:\<br />\<br /> -   [! loop = 5 ]\<br />-   [! loop = *NUM_OF_PAGES* ] where *NUM_OF_PAGES* is a symbol with a numeric value.|  
|[! endloop ]|Ends a loop structure.|  
  
 The left bracket ([) followed immediately by an exclamation mark (!) indicates the beginning of a template directive. The right bracket indicates the end of a template directive. This is the required syntax:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 A space or a non-identifier character is required only between *directive* and *params*.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can use the following operators with the above directives in a template file.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Files Created for Your Wizard](../vs140/files-created-for-your-wizard.md)   
 [Custom Wizard](../vs140/custom-wizard.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)