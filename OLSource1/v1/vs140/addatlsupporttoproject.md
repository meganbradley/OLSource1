---
title: "AddATLSupportToProject"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddATLSupportToProject method
ms.assetid: 26708f22-1e9b-4432-83b2-ed94c765b753
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AddATLSupportToProject
Adds ATL support to an MFC project.  
  
## Syntax  
  
```  
  
      function AddATLSupportToProject(   
   oProj   
);  
```  
  
#### Parameters  
 `oProj`  
 The selected project.  
  
## Return Value  
 **true** if ATL support was successfully added to the MFC project.  
  
## Remarks  
 Use this function to add ATL support to an MFC project created by the wizard.  
  
 The wizard displays a message box to confirm adding ATL support to the MFC project. Upon confirmation, the wizard checks for existing support and adds all the necessary GUIDs, templates, headers, and additional functionality so that the MFC project created by the wizard supports ATL.  
  
## Example  
  
```  
var oCM = selProj.CodeModel;  
var L_TRANSACTION_Text = "Add ATL Support To Project";  
oCM.StartTransaction(L_TRANSACTION_Text);  
var bRet = AddATLSupportToProject(selProj);  
if (bRet)  
   oCM.CommitTransaction();  
else  
   oCM.AbortTransaction();  
return bRet;  
```  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)   
 [CanAddATLClass](../vs140/canaddatlclass.md)   
 [IsMFCProject](../vs140/ismfcproject.md)   
 [Introduction to ATL](../vs140/introduction-to-atl.md)