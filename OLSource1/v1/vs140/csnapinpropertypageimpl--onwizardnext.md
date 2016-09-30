---
title: "CSnapInPropertyPageImpl::OnWizardNext"
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
  - "OnWizardNext"
  - "CSnapInPropertyPageImpl::OnWizardNext"
  - "CSnapInPropertyPageImpl.OnWizardNext"
  - "ATL::CSnapInPropertyPageImpl::OnWizardNext"
  - "ATL.CSnapInPropertyPageImpl.OnWizardNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnWizardNext method"
ms.assetid: 03f88118-1951-444d-8917-b4e21c7941a9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInPropertyPageImpl::OnWizardNext
This member function is called when the user clicks the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> button in a wizard.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
  
-   0 to automatically advance to the next page.  
  
-   –1 to prevent the page from changing.  
  
 To jump to a page other than the next one, return the identifier of the dialog box to be displayed.  
  
## Remarks  
 Override this member function to specify some action the user must take when the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> button is clicked.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInPropertyPageImpl Class](../vs140/csnapinpropertypageimpl-class.md)