---
title: "CanAddNonAttributed"
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
  - "CanAddNonAttributed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanAddNonAttributed method"
ms.assetid: a2b0143e-f84b-40f3-8f51-23a492f651f8
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CanAddNonAttributed
Indicates that the ATL project supports nonattributed objects.  
  
## Syntax  
  
```  
  
function CanAddNonAttributed( );  
  
```  
  
## Return Value  
 **true** if the project supports nonattributed and attributed ATL objects; **false** if the project supports only attributed projects.  
  
## Remarks  
 Call this function to indicate whether the project supports both nonattributed and attributed objects.  
  
## Example  
  
```  
// Check if attributed project using CanAddNonAttributed  
window.external.Load(document);  
if (IsAttributedProject(window.external))  
{  
   ATTRIBUTED.checked = true;  
   if (!CanAddNonAttributed())  
      ATTRIBUTED.disabled = true;  
}  
```  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../VS_csharp/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../VS_csharp/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../VS_csharp/creating-a-custom-wizard.md)   
 [Designing a Wizard](../VS_csharp/designing-a-wizard.md)   
 [Concepts](../VS_csharp/attributed-programming-concepts.md)   
 [CanAddClass](../VS_csharp/canaddclass.md)