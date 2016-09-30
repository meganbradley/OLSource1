---
title: "Error Handling in Wizard JScript Files"
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
  - "JScript, handling errors"
  - "Wizard JScript error handling"
  - "error handling, JScript"
ms.assetid: 6df3ba46-7ab6-484c-ac45-b08f4b6a5900
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Error Handling in Wizard JScript Files
When you create a wizard, your project includes the Default.js and Common.js files. Use these files to customize your project. See [The JScript File](../vs140/jscript-file.md) for more information.  
  
 Your project should include error handling. The following code provides you with an example of such code.  
  
### To handle errors in JScript  
  
1.  To catch errors when the user clicks **Finish**, enter the following code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Throw <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> from any helper script functions called in the script:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  If the parameter **PREPROCESS_FUNCTION** is in [the .vsz file](../vs140/.vsz-file--project-control-.md), the wizard calls [CanAddATLClass](../vs140/jscript-functions-for-c---wizards.md). Use [SetErrorInfo](../vs140/seterrorinfo.md) in case of failure and return **false**:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  If you must go back to the **New Project** or **Add New Item** dialog box, return **VS_E_WIZBACKBUTTONPRESS**:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Files Created for Your Wizard](../vs140/files-created-for-your-wizard.md)   
 [Customizing Your Wizard](../vs140/customizing-your-wizard.md)