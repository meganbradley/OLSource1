---
title: "How to: Expose Code to VBA in a Visual C# Project"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Visual C# [Office development in Visual Studio], exposing code to VBA"
  - "VBA [Office development in Visual Studio], exposing code in document-level customizations"
  - "document-level customizations [Office development in Visual Studio], exposing code"
  - "exposing code to VBA"
ms.assetid: 56d5894b-4823-42f4-8c7e-d8739b859c52
caps.latest.revision: 25
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Expose Code to VBA in a Visual C# Project
  You can expose code in a Visual C# project to Visual Basic for Applications (VBA) code if you want the two types of code to interact with each other.  
  
 The Visual C# process is different from the Visual Basic process. For more information, see [How to: Expose Code to VBA in a Visual Basic Project](../VS_officedev/how-to--expose-code-to-vba-in-a-visual-basic-project.md).  
  
 [!INCLUDE[appliesto_alldoc](../VS_officedev/includes/appliesto_alldoc_md.md)]  
  
## Exposing Code in a Visual C# Project  
 To enable VBA code to call code in a Visual C# project, modify the code so it is visible to COM, and then set the **ReferenceAssemblyFromVbaProject** property to **True** in the designer.  
  
 For a walkthrough that demonstrates how to call a method in a Visual C# project from VBA, see [Walkthrough: Calling Code from VBA in a Visual C&#35; Project](../VS_officedev/walkthrough--calling-code-from-vba-in-a-visual-csharp-project.md).  
  
#### To expose code in a Visual C# project to VBA  
  
1.  Open or create a document-level project that is based on a Word document, Excel workbook, or Excel template that supports macros, and that already contains VBA code.  
  
     For more information about the document file formats that support macros, see [Combining VBA and Document-Level Customizations](../VS_officedev/combining-vba-and-document-level-customizations.md).  
  
    > [!NOTE]  
    >  This feature cannot be used in Word template projects.  
  
2.  Ensure that VBA code in the document is allowed to run without prompting the user to enable macros. You can trust VBA code to run by adding the location of the Office project to the list of trusted locations in the Trust Center settings for Word or Excel.  
  
3.  Add the member that you want to expose to VBA to a public class in your project, and declare the new member as **public**.  
  
4.  Apply the following \<xref:System.Runtime.InteropServices.ComVisibleAttribute> and \<xref:System.Runtime.InteropServices.ClassInterfaceAttribute> attributes to the class that you are exposing to VBA. These attributes make the class visible to COM, but without generating a class interface.  
  
    ```c#  
    [System.Runtime.InteropServices.ComVisible(true)]  
    [System.Runtime.InteropServices.ClassInterface(  
        System.Runtime.InteropServices.ClassInterfaceType.None)]  
    ```  
  
5.  Override the **GetAutomationObject** method of a host item class in your project to return an instance of the class that you are exposing to VBA:  
  
    -   If you are exposing a host item class to VBA, override the **GetAutomationObject** method that belongs to this class, and return the current instance of the class.  
  
        ```c#  
        protected override object GetAutomationObject()  
        {  
            return this;  
        }  
        ```  
  
    -   If you are exposing a class that is not a host item to VBA, override the **GetAutomationObject** method of any host item in your project, and return an instance of the non-host item class. For example, the following code assumes that you are exposing a class named `DocumentUtilities` to VBA.  
  
        ```c#  
        protected override object GetAutomationObject()  
        {  
            return new DocumentUtilities();  
        }  
        ```  
  
     For more information about host items, see [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md).  
  
6.  Extract an interface from the class that you are exposing to VBA. In the **Extract Interface** dialog box, select the public members that you want to include in the interface declaration. For more information, see [Extract Interface Refactoring &#40;C&#35;&#41;](../Topic/Extract%20Interface%20Refactoring%20(C%23).md).  
  
7.  Add the **public** keyword to the interface declaration.  
  
8.  Make the interface visible to COM by adding the following \<xref:System.Runtime.InteropServices.ComVisibleAttribute> attribute to the interface.  
  
    ```c#  
    [System.Runtime.InteropServices.ComVisible(true)]  
    ```  
  
9. Open the document (for Word) or worksheet (for Excel) in the designer in [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)].  
  
10. In the **Properties** window, select the **ReferenceAssemblyFromVbaProject** property, and change the value to **True**.  
  
    > [!NOTE]  
    >  If the workbook or document does not already contain VBA code or if VBA code in the document is not trusted to run, you will receive an error message when you set the **ReferenceAssemblyFromVbaProject** property to **True**. This is because Visual Studio cannot modify the VBA project in the document in this situation.  
  
11. Click **OK** in the message that is displayed. This message reminds you that if you add VBA code to the workbook or document when running the project from [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)], the VBA code will be lost the next time that you build the project. This is because the document in the build output folder is overwritten every time that you build the project.  
  
     At this point, Visual Studio configures the project so that the VBA project can call into the assembly. Visual Studio also adds a method named `GetManagedClass` to the VBA project. You can call this method from anywhere in the VBA project to access the class that you exposed to VBA.  
  
12. Build the project.  
  
## See Also  
 [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md)   
 [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md)   
 [Combining VBA and Document-Level Customizations](../VS_officedev/combining-vba-and-document-level-customizations.md)   
 [Walkthrough: Calling Code from VBA in a Visual C&#35; Project](../VS_officedev/walkthrough--calling-code-from-vba-in-a-visual-csharp-project.md)   
 [How to: Expose Code to VBA in a Visual Basic Project](../VS_officedev/how-to--expose-code-to-vba-in-a-visual-basic-project.md)  
  
  