---
title: "HTML Files"
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
  - "wizards [C++], user interface for custom wizards"
  - "user interface for wizards"
  - "custom wizards, HTML files"
  - "custom wizards, user interface"
  - "HTML pages, user interface for custom wizards"
  - "files [C++], created by Custom Wizard"
ms.assetid: 3b6ed080-6560-418b-b908-d84d71bdf145
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HTML Files
A wizard can contain a user interface, which is an HTML interface. Along with Default.htm, a wizard can contain any number of .htm files, which you can indicate in the **Number of Pages** box in the [Custom Wizard](../vs140/custom-wizard.md). Each .htm file represents an HTML page of your wizard, and the HTML page is accessible using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and **Back** buttons, tabs, or any other format you specify in your wizard design.  
  
 The HTML contains:  
  
-   The SYMBOL tag, which identifies the default for user-defined options. Symbols are written into the symbol table when the user clicks **Finish**, such as:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the wizard user interface (UI), the text box identified in the symbol table as "HEADER_FILE" contains the default text "MyHeader.h". You can change this value in the wizard UI, and the resulting value is written to the project's symbol table when you click **Finish**, such as:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the wizard UI, the check box identified in the symbol table as "CHECKBOX1" is cleared by default. You can select this box in the HTML UI, and the resulting value is written to the symbol table when you click **Finish**.  
  
 Each .htm file records user selections to the symbols table.  
  
-   An include for [Common.js](../vs140/customizing-c---wizards-with-common-jscript-functions.md), which contains commonly used and helpful JScript functions, and Default.js.  
  
-   References to the project's images to display in the HTML.  
  
-   HTML text and formatting that customize the appearance of the wizard's user interface  
  
-   JScript functions that access the Visual C++ Wizard Object Model to provide customized behavior from within the wizard. These functions are in the HTML page section headed \<SCRIPT LANGUAGE='JSCRIPT'>, as shown in the following example.  
  
    > [!NOTE]
    >  To access the Wizard and Environment Object Models from HTML, prepend the object model item with "window.external."  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following is a sample console application wizard:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Files Created for Your Wizard](../vs140/files-created-for-your-wizard.md)   
 [Custom Wizard](../vs140/custom-wizard.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)