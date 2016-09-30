---
title: "GetMaxID"
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
  - "GetMaxID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMaxID method"
ms.assetid: a155ec2e-6132-4e40-9b85-d710538778a1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetMaxID
Gets the highest dispid from members of this interface and all of its bases.  
  
## Syntax  
  
```  
  
      function GetMaxID(   
   ointerface    
);  
```  
  
#### Parameters  
 *ointerface*  
 A \<xref:Microsoft.VisualStudio.VCCodeModel.VCCodeInterface*> object.  
  
## Return Value  
 The highest dispid from the members of *oInterface* and all its bases.  
  
## Remarks  
 Call this function to get the highest dispid from the members of the specified interface and all its bases.  
  
## Example  
  
```  
if (strInterfaceType == "custom")  
      window.external.AddSymbol("DISPID_DISABLED", true);  
   else  
   {  
      var nDispID = window.external.FindSymbol("DISPID");  
      if (!nDispID.length)  
      {  
         nDispID = GetMaxID(oInterface) + 1;  
         window.external.AddSymbol("DISPID", nDispID);  
      }  
   }  
```  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)