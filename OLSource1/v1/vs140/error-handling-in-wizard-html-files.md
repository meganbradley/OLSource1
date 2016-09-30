---
title: "Error Handling in Wizard HTML Files"
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
  - "error handling, file error-checking"
  - "HTML, error handling"
ms.assetid: eb428a64-b681-4420-987d-92098bf98455
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Error Handling in Wizard HTML Files
When you create a wizard with a user interface, your project includes .htm files. Use these files to customize your project. See [The HTML Files](../vs140/html-files.md) for more information.  
  
 Your project should include error handling. The following code provides you with an example of such code.  
  
### To handle errors in HTML  
  
1.  When you validate the fields, if you call a validation method in a DLL (which should set the error information), call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with no parameters.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  When you validate fields, if you validate the field using only the HTML script, call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> first and then call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with no parameters.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  Call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with parameters:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  If you must go back to the **New Project** or **Add New Item** dialog box, return **VS_E_WIZBACKBUTTONPRESS**:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Files Created for Your Wizard](../vs140/files-created-for-your-wizard.md)   
 [Customizing Your Wizard](../vs140/customizing-your-wizard.md)