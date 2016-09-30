---
title: "Custom Parameters in the Wizard .Vsz File"
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
  - "PRODUCT_INSTALLATION_DIR macro"
  - "HTML_FILTER macro"
  - "SCRIPT_FILTER macro"
  - "IMAGES_PATH macro"
  - "custom wizards, .vsz file"
  - "WIZARD_NAME macro"
  - "PROJECT_TEMPLATE_PATH macro"
  - "PROJECT_TEMPLATE_NAME macro"
  - "SCRIPT_PATH macro"
  - "START_PATH macro"
  - "RELATIVE_PATH macro"
  - "ABSOLUTE_PATH macro"
  - "SCRIPT_COMMON_PATH macro"
  - "HTML_PATH macro"
  - "WIZARD_UI macro"
  - "PRODUCT macro"
  - "TEMPLATES_PATH macro"
  - "IMAGE_FILTER macro"
  - "MISC_FILTER macro"
  - "TEMPLATE_FILTER macro"
ms.assetid: 560dd5c0-7cff-4974-b856-5ca25b0669b8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Custom Parameters in the Wizard .Vsz File
In its first two lines, the .vsz file identifies the wizard version and the ProgID or CLSID of the wizard to be cocreated. The .vsz file can also include optional context parameters and custom parameters that are added to the symbol table (along with the symbols supplied in the HTML symbol section).  
  
 The [M:Microsoft.VisualStudio.VsWizard.VsWizardClass.Execute(System.Object,System.Int32,System.Object\[\]@,System.Object\[\]@,EnvDTE.wizardResult@)](assetId:///M:Microsoft.VisualStudio.VsWizard.VsWizardClass.Execute(System.Object,System.Int32,System.Object[]@,System.Object[]@,EnvDTE.wizardResult@)?qualifyHint=False&autoUpgrade=True) method displays the wizard, which takes an array of the context and custom parameters defined in the .vsz file as its parameters.  
  
 The following commonly used symbols are specified as custom parameters in either the [.vsz file](../vs140/.vsz-file--project-control-.md) or the .htm files and can be used in wizard HTML, script, or template files.  
  
## Example  
 As the following .vsz file entries indicate, the wizard named MyProjWiz contains a user interface.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Symbols for Custom Parameters in the Wizard .vsz File  
  
|Symbol|Definition|  
|------------|----------------|  
|ABSOLUTE_PATH|The location of the wizard files.|  
|HTML_FILTER|Specified in the .vsz file. File types that are placed in the HTML Files folder in **Solution Explorer**. Usually specified as "htm".|  
|HTML_PATH|Specified in the .vsz file. The location of the wizard's [HTML files](../vs140/html-files.md). By default, it is START_PATH\HTML\\*LANGUAGE* (where *LANGUAGE* is the locale specified by your system registry). **Note:**  You can specify a different language by setting the \<LangID> to the decimal value of HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\7.0\General\UILanguage. See [Localizing a Wizard to Multiple Languages](../vs140/localizing-a-wizard-to-multiple-languages.md) for more information. For a list of decimal language values, see [Wizard Support for Other Languages](../vs140/wizard-support-for-other-languages.md).|  
|IMAGE_FILTER|Specified in the .vsz file. File types that are placed in the Image Files folder in Solution Explorer. Usually specified as "bmp;gif".|  
|IMAGES_PATH|Specified in the .vsz file. The location of the image files used in the html files. By default, it is START_PATH\Images.|  
|MISC_FILTER|Specified in the .vsz file. File types that are placed in the Misc folder in Solution Explorer. Usually specified as "vsz;vsdir;ico;vcproj;csproj;css;inf".|  
|PRODUCT|By default, set to Visual C++; however, you can set this value to Visual Basic to create Visual Basic wizards, and so on.|  
|PRODUCT_INSTALLATION_DIR|The directory listed in the registry at HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\7.0\Setup\\<Product\>\ ProductDir.|  
|PROJECT_TEMPLATE_NAME|Specified in the .vsz file. The project template file that your wizard uses to create projects. Usually specified as "txt".|  
|PROJECT_TEMPLATE_PATH|The directory containing the project's [template files](../vs140/template-files.md). For Visual C++, it is PRODUCT_INSTALLATION_DIR\VCWizards, by default.|  
|RELATIVE_PATH|If ABSOLUTE_PATH is not found, then RELATIVE_PATH is considered. This is the path relative to PRODUCT_INSTALLATION_DIR. For Visual C++, the RELATIVE_PATH is PRODUCT_INSTALLATION_DIR\VCWizards.|  
|SCRIPT_COMMON_PATH|The directory name relative to PRODUCT_INSTALLATION_DIR, where the common script file can be found. For example, for Visual C++, this is VCWizards.|  
|SCRIPT_FILTER|Specified in the .vsz file. File types that are be placed in the Script Files folder in Solution Explorer. Usually specified as either "js" (JScript) or "vbs" (VBScript).|  
|SCRIPT_PATH|The location of the wizard's [JScript file](../vs140/jscript-file.md). By default, it is START_PATH\Scripts|  
|START_PATH|Specified in the .vsz file. This is not set by the user, but used internally to identify either RELATIVE_PATH or ABSOLUTE_PATH. The wizard name (WIZARD_NAME) is appended to this value.|  
|TEMPLATE_FILTER|Specified in the .vsz file. File types that are placed in the Template Files folder in Solution Explorer. Usually specified as "txt".|  
|TEMPLATES_PATH|Specified in the .vsz file. The location of the wizard's template files. By default, it is START_PATH\Templates\\<LangID\>. **Note:**  See HTML_PATH for more information on LangID.|  
|WIZARD_NAME|Specifies the wizard name. Located in the .vsz and used by the rest of the symbols.|  
|WIZARD_UI|Specified in the .vsz file. A Boolean value indicating whether the wizard contains a user interface. Specify **TRUE** for a user interface or **FALSE** for no user interface.|  
  
## See Also  
 \<xref:EnvDTE.IDTWizard.Execute*>   
 [Files Created for Your Wizard](../vs140/files-created-for-your-wizard.md)   
 [Custom Wizard](../vs140/custom-wizard.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)