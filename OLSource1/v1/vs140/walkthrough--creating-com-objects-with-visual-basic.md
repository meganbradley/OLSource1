---
title: "Walkthrough: Creating COM Objects with Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "COM interop, creating COM objects"
  - "COM objects, creating"
  - "COM interop, walkthroughs"
  - "object creation, COM objects"
  - "COM objects, walkthroughs"
ms.assetid: 7b07a463-bc72-4392-9ba0-9dfcb697a44f
caps.latest.revision: 34
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating COM Objects with Visual Basic
When creating new applications or components, it is best to create .NET Framework assemblies. However, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] also makes it easy to expose a .NET Framework component to COM. This enables you to provide new components for earlier application suites that require COM components. This walkthrough demonstrates how to use [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] to expose [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] objects as COM objects, both with and without the COM class template.  
  
 The easiest way to expose COM objects is by using the COM class template. The COM class template creates a new class, and then configures your project to generate the class and interoperability layer as a COM object and register it with the operating system.  
  
> [!NOTE]
>  Although you can also expose a class created in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] as a COM object for unmanaged code to use, it is not a true COM object and cannot be used by [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]. For more information, see [COM Interoperability in .NET Framework Applications](../vs140/com-interoperability-in-.net-framework-applications--visual-basic-.md).  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
### To create a COM object by using the COM class template  
  
1.  Open a new Windows Application project from the **File** menu by clicking **New Project**.  
  
2.  In the **New Project** dialog box under the **Project Types** field, check that Windows is selected. Select **Class Library** from the **Templates** list, and then click **OK**. The new project is displayed.  
  
3.  Select **Add New Item** from the **Project** menu. The **Add New Item** dialog box is displayed.  
  
4.  Select **COM Class** from the **Templates** list, and then click **Add**. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] adds a new class and configures the new project for COM interop.  
  
5.  Add code such as properties, methods, and events to the COM class.  
  
6.  Select **Build ClassLibrary1** from the **Build** menu. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] builds the assembly and registers the COM object with the operating system.  
  
## Creating COM Objects without the COM Class Template  
 You can also create a COM class manually instead of using the COM class template. This procedure is helpful when you are working from the command line or when you want more control over how COM objects are defined.  
  
#### To set up your project to generate a COM object  
  
1.  Open a new Windows Application project from the **File** menu by clicking **NewProject**.  
  
2.  In the **New Project** dialog box under the **Project Types** field, check that Windows is selected. Select **Class Library** from the **Templates** list, and then click **OK**. The new project is displayed.  
  
3.  In **Solution Explorer**, right-click your project, and then click **Properties**. The **Project Designer** is displayed.  
  
4.  Click the **Compile** tab.  
  
5.  Select the **Register for COM Interop** check box.  
  
#### To set up the code in your class to create a COM object  
  
1.  In **Solution Explorer**, double-click **Class1.vb** to display its code.  
  
2.  Rename the class to `ComClass1`.  
  
3.  Add the following constants to `ComClass1`. They will store the Globally Unique Identifier (GUID) constants that the COM objects are required to have.  
  
     [!code[VbVbalrInterop#2](../vs140/codesnippet/VisualBasic/walkthrough--creating-com-objects-with-visual-basic_1.vb)]  
  
4.  On the **Tools** menu, click **Create Guid**. In the **Create GUID** dialog box, click **Registry Format** and then click **Copy**. Click **Exit**.  
  
5.  Replace the empty string for the `ClassId` with the GUID, removing the leading and trailing braces. For example, if the GUID provided by Guidgen is `"{2C8B0AEE-02C9-486e-B809-C780A11530FE}"` then your code should appear as follows.  
  
     [!code[VbVbalrInterop#3](../vs140/codesnippet/VisualBasic/walkthrough--creating-com-objects-with-visual-basic_2.vb)]  
  
6.  Repeat the previous steps for the `InterfaceId` and `EventsId` constants, as in the following example.  
  
     [!code[VbVbalrInterop#4](../vs140/codesnippet/VisualBasic/walkthrough--creating-com-objects-with-visual-basic_3.vb)]  
  
    > [!NOTE]
    >  Make sure that the GUIDs are new and unique; otherwise, your COM component could conflict with other COM components.  
  
7.  Add the `ComClass` attribute to `ComClass1`, specifying the GUIDs for the Class ID, Interface ID, and Events ID as in the following example:  
  
     [!code[VbVbalrInterop#5](../vs140/codesnippet/VisualBasic/walkthrough--creating-com-objects-with-visual-basic_4.vb)]  
  
8.  COM classes must have a parameterless `Public Sub New()` constructor, or the class will not register correctly. Add a parameterless constructor to the class:  
  
     [!code[VbVbalrInterop#6](../vs140/codesnippet/VisualBasic/walkthrough--creating-com-objects-with-visual-basic_5.vb)]  
  
9. Add properties, methods, and events to the class, ending it with an `End Class` statement. Select **Build Solution** from the **Build** menu. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] builds the assembly and registers the COM object with the operating system.  
  
    > [!NOTE]
    >  The COM objects you generate with [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] cannot be used by other [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] applications because they are not true COM objects. Attempts to add references to such COM objects will raise an error. For details, see [COM Interoperability in .NET Framework Applications](../vs140/com-interoperability-in-.net-framework-applications--visual-basic-.md).  
  
## See Also  
 <xref:Microsoft.VisualBasic.ComClassAttribute*>   
 [COM Interop](../vs140/com-interop--visual-basic-.md)   
 [Walkthrough: Implementing Inheritance with COM Objects](../vs140/walkthrough--implementing-inheritance-with-com-objects--visual-basic-.md)   
 [#Region Directive](../vs140/sharpregion-directive.md)   
 [COM Interoperability in .NET Framework Applications](../vs140/com-interoperability-in-.net-framework-applications--visual-basic-.md)   
 [Troubleshooting Interoperability](../vs140/troubleshooting-interoperability--visual-basic-.md)